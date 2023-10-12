// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamVisualizer;

using MemoryStreamObjectSource;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.Extensibility.UI;
using Microsoft.VisualStudio.RpcContracts.DebuggerVisualizers;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

/// <summary>
/// Remote UI user control for the MemoryStreamVisualizer,
/// </summary>
internal class MemoryStreamVisualizerUserControl : RemoteUserControl
{
    private readonly VisualizerTarget visualizerTarget;
    private readonly MemoryStreamData dataContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryStreamVisualizerUserControl"/> class.
    /// </summary>
    /// <param name="visualizerTarget">The visualizer target to be used to retrieve data from.</param>
    public MemoryStreamVisualizerUserControl(VisualizerTarget visualizerTarget)
        : base(new MemoryStreamData())
    {
        visualizerTarget.StateChanged += this.VisualizerTargetStateChangedAsync;

        this.dataContext = (MemoryStreamData)this.DataContext!;
        this.visualizerTarget = visualizerTarget;
    }

    private Task VisualizerTargetStateChangedAsync(object? sender, VisualizerTargetStateNotification args)
    {
        if (args == VisualizerTargetStateNotification.Available || args == VisualizerTargetStateNotification.ValueUpdated)
        {
            this.dataContext.Data.Clear();
            this.dataContext.Position = 0;
            this.dataContext.Length = 0;
            this.dataContext.LoadingVisibility = Visibility.Visible;

            return this.RetrieveDataAsync();
        }

        return Task.CompletedTask;
    }

    private async Task RetrieveDataAsync()
    {
        ReadOnlySequence<byte> data;
        do
        {
            using MemoryStream memoryStream = new(sizeof(int));
            using BinaryWriter binaryWriter = new(memoryStream);
            int index = this.dataContext.Data.Count * MemoryStreamVisualizerObjectSource.RowLength;
            if (index >= 1024 * 1024)
            {
                break; // Let's not retrieve more than 1MB of data
            }

            binaryWriter.Write(index);
            binaryWriter.Flush();
            try
            {
                data = (await this.visualizerTarget.ObjectSource.RequestDataAsync(new ReadOnlySequence<byte>(memoryStream.ToArray()), CancellationToken.None)).Value;
            }
            catch (Exception)
            {
                // I can get an exception if the debug session is unpaused, so I need to handle it gracefully
                break;
            }
        }
        while (data.Length > 0 && this.Read(data));

        this.dataContext.LoadingVisibility = Visibility.Hidden;
    }

    private bool Read(ReadOnlySequence<byte> data)
    {
        int byteInRowCount = 0;
        StringBuilder binaryText = new();
        StringBuilder asciiText = new();

        SequenceReader<byte> reader = new(data);
        if (!reader.TryReadLittleEndian(out long position) || !reader.TryReadLittleEndian(out long length))
        {
            return false;
        }

        this.dataContext.Position = position;
        this.dataContext.Length = length;

        if (reader.UnreadSpan.Length == 0)
        {
            return false; // We always receive data unless we are at the end of the MemoryStream
        }

        List<HexEditorRow> rows = new(MemoryStreamVisualizerObjectSource.RowsCountPerRequest);
        byte[] tmp = new byte[1];
        while (reader.TryRead(out byte b))
        {
            byteInRowCount++;
            if (byteInRowCount > 1)
            {
                binaryText.Append(' ');
            }

            binaryText.Append(b.ToString("X2", CultureInfo.InvariantCulture));
            tmp[0] = b;
            asciiText.Append(char.IsControl((char)b) || b == 0xAD ? '•' : Encoding.Latin1.GetChars(tmp)[0]);

            if (byteInRowCount == MemoryStreamVisualizerObjectSource.RowLength)
            {
                CompleteRow();
            }
        }

        if (byteInRowCount > 0)
        {
            CompleteRow();
            this.dataContext.Data.AddRange(rows);
            return false; // We only receive partial rows at the end of the MemoryStream
        }

        this.dataContext.Data.AddRange(rows);
        return true;

        void CompleteRow()
        {
            rows.Add(new HexEditorRow(
                index: (this.dataContext.Data.Count + rows.Count) * MemoryStreamVisualizerObjectSource.RowLength,
                data: binaryText.ToString(),
                ascii: asciiText.ToString()));

            byteInRowCount = 0;
            binaryText.Clear();
            asciiText.Clear();
        }
    }
}
