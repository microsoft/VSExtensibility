// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamObjectSource;

using System.IO;
using Microsoft.VisualStudio.DebuggerVisualizers;

/// <summary>
/// Object source class for the MemoryStreamVisualizer.
/// </summary>
public class MemoryStreamVisualizerObjectSource : VisualizerObjectSource
{
    /// <summary>
    /// How many rows will be transfered, at most, responding to a single request.
    /// </summary>
    public const int RowsCountPerRequest = 1024;

    /// <summary>
    /// How many bytes will be transfered for each row.
    /// </summary>
    public const int RowLength = 16;

    /// <inheritdoc/>
    public override void TransferData(object target, Stream incomingData, Stream outgoingData)
    {
        if (target is MemoryStream memoryStream)
        {
            using BinaryReader binaryReader = new(incomingData);
            var index = binaryReader.ReadInt32(); // The extension will send the offset (Int32) to start reading from

            using BinaryWriter binaryWriter = new(outgoingData);
            var backupPosition = memoryStream.Position;

            // Will reply with the current MemoryStream.Position (Int64),
            // followed by MemoryStream.Length (Int64),
            // followed by up to 16KB of data retrieved from the MemoryStream
            binaryWriter.Write(backupPosition);
            binaryWriter.Write(memoryStream.Length);
            if (index < memoryStream.Length)
            {
                try
                {
                    var data = new byte[RowsCountPerRequest * RowLength];
                    memoryStream.Seek(index, SeekOrigin.Begin);
                    var count = memoryStream.Read(data, 0, data.Length);
                    binaryWriter.Write(data, 0, count);
                }
                finally
                {
                    // Make sure to restore the MemoryStream to its original position
                    memoryStream.Seek(backupPosition, SeekOrigin.Begin);
                }
            }

            binaryWriter.Flush();
        }
    }
}
