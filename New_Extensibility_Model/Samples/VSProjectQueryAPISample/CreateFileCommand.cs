﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for adding a file.
/// </summary>
[VisualStudioContribution]
public class CreateFileCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.CreateFileCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Workspaces().UpdateProjectsAsync(
            project => project.Where(project => project.Name == "ConsoleApp1"),
            project => project.CreateFile("CreatedFile.txt"),
            cancellationToken);

        await this.Extensibility.Shell().ShowPromptAsync("Created new file in ConsoleApp1.", PromptOptions.OK, cancellationToken);
    }
}
