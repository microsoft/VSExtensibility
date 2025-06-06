﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for unloading a project.
/// </summary>
[VisualStudioContribution]
public class UnloadProjectCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.UnloadProjectCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        const string projectPath = "ConsoleApp1\\\\ConsoleApp1.csproj";

        var solutionQueryResults = await this.Extensibility.Workspaces().QuerySolutionAsync(
            solution => solution.With(solution => solution.BaseName),
            cancellationToken);

        var solutionName = solutionQueryResults.First().BaseName;

        await this.Extensibility.Workspaces().UpdateSolutionAsync(
            solution => solution.Where(solution => solution.BaseName == solutionName),
            solution => solution.UnloadProject(projectPath),
            cancellationToken);

        await this.Extensibility.Shell().ShowPromptAsync($"Unloaded a project called {projectPath} in solution {solutionName}.", PromptOptions.OK, cancellationToken);
    }
}
