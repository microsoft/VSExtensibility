// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilePickerSample;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell.FileDialog;

[VisualStudioContribution]
public class OpenFolderCommand(VisualStudioExtensibility extensibility) : Command(extensibility)
{
    public override CommandConfiguration CommandConfiguration => new("%FilePickerSample.OpenFolderCommand.DisplayName%")
    {
        TooltipText = "%FilePickerSample.OpenFolderCommand.TooltipText%",
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.OpenFileDialog, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
    {
        FolderDialogOptions options = new();
        string? folderPath = await this.Extensibility.Shell().ShowOpenFolderDialogAsync(options, ct);
        Debug.WriteLine($"Selected folder path: {folderPath ?? "No selection"}");
    }
}
