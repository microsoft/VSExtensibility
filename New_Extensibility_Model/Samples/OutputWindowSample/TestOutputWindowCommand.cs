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
public class TestOutputWindowCommand : Command
{
    private OutputWindow? outputWindow;

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%OutputWindowSample.TestOutputWindowCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
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
#pragma warning disable VSEXTAPI0001 // This API is marked as Preview.
            await this.outputWindow.Writer.WriteLineAsync("This is a test of the output window.");
#pragma warning restore VSEXTAPI0001 // This API is marked as Preview.
        }
    }

    private async Task<OutputWindow?> GetOutputWindowAsync(CancellationToken cancellationToken)
    {
        string id = "MyOutputWindow";
        string displayNameResourceId = nameof(Strings.OutputWindowDisplayName);
#pragma warning disable VSEXTAPI0001 // This API is marked as Preview.
        return await this.Extensibility.Views().Output.GetChannelAsync(id, displayNameResourceId, cancellationToken);
#pragma warning restore VSEXTAPI0001 // This API is marked as Preview.
    }
}
