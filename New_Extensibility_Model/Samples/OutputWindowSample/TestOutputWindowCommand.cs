// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Documents;

/// <summary>
/// A sample command for displaying a test message in the output window.
/// </summary>
[VisualStudioContribution]
#pragma warning disable VSEXTPREVIEW_OUTPUTWINDOW // Type is for evaluation purposes only and is subject to change or removal in future updates.
public class TestOutputWindowCommand : Command
{
    private OutputChannel? outputChannel;

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%OutputWindowSample.TestOutputWindowCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task InitializeAsync(CancellationToken cancellationToken)
    {
        this.outputChannel = await this.GetOutputChannelAsync(cancellationToken);
        await base.InitializeAsync(cancellationToken);
    }

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        if (this.outputChannel != null)
        {
            await this.outputChannel.WriteLineAsync("Testing the output channel.");

            await this.outputChannel.Writer.WriteLineAsync("Testing the output channel TextWriter.");

            var rom = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes("Testing the output channel PipeWriter."));
            await this.outputChannel.PipeWriter.WriteAsync(rom, cancellationToken);
        }
    }

    private async Task<OutputChannel?> GetOutputChannelAsync(CancellationToken cancellationToken)
    {
        string displayNameResourceId = nameof(Strings.OutputWindowDisplayName);
        return await this.Extensibility.Views().Output.CreateOutputChannelAsync(displayNameResourceId, cancellationToken);
    }
}
#pragma warning restore VSEXTPREVIEW_OUTPUTWINDOW // Type is for evaluation purposes only and is subject to change or removal in future updates.
