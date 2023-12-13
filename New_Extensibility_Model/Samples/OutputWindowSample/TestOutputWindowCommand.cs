// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

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
    private OutputWindow? outputWindow;

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%OutputWindowSample.TestOutputWindowCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task InitializeAsync(CancellationToken cancellationToken)
    {
        this.outputWindow = await this.GetOutputWindowAsync(cancellationToken);
        await base.InitializeAsync(cancellationToken);
    }

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        if (this.outputWindow != null)
        {
            await this.outputWindow.Writer.WriteLineAsync("This is a test of the output window.");
        }
    }

    private async Task<OutputWindow?> GetOutputWindowAsync(CancellationToken cancellationToken)
    {
        string id = "MyOutputWindow";
        string displayNameResourceId = nameof(Strings.OutputWindowDisplayName);
        return await this.Extensibility.Views().Output.GetChannelAsync(id, displayNameResourceId, cancellationToken);
    }
}
#pragma warning restore VSEXTPREVIEW_OUTPUTWINDOW // Type is for evaluation purposes only and is subject to change or removal in future updates.
