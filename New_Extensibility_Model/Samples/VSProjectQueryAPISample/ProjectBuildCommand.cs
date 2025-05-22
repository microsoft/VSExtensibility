// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for building a project.
/// </summary>
[VisualStudioContribution]
public class ProjectBuildCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.ProjectBuildCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        const string projectName = "ConsoleApp1";

        var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
            project => project.Where(p => p.Name == projectName),
            cancellationToken);

        await result.First().BuildAsync(cancellationToken);

        await this.Extensibility.Shell().ShowPromptAsync($"Building project {projectName}.", PromptOptions.OK, cancellationToken);
    }
}
