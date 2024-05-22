// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FilePickerSample;

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell.FileDialog;

[VisualStudioContribution]
public class OpenMultipleFilesCommand(VisualStudioExtensibility extensibility) : Command(extensibility)
{
    public override CommandConfiguration CommandConfiguration => new("%FilePickerSample.OpenMultipleFilesCommand.DisplayName%")
    {
        TooltipText = "%FilePickerSample.OpenMultipleFilesCommand.TooltipText%",
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.OpenFileDialog, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
    {
        FileDialogOptions options = new()
        {
            InitialFileName = "test.cs",
            Filters = new DialogFilters(
                new("Log Files", "*.txt", "*.log"),
                new("CSharp Files", "*.cs")),
        };

        IReadOnlyList<string>? filePaths = await this.Extensibility.Shell().ShowOpenMultipleFilesDialogAsync(options, ct);
        Debug.WriteLine($"Selected file paths: {string.Join('\n', filePaths ?? [])}");
    }
}
