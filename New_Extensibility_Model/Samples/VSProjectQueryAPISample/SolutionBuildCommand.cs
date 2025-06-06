﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for building the solution.
/// </summary>
[VisualStudioContribution]
public class SolutionBuildCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.SolutionBuildCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        IQueryResults<ISolutionSnapshot> solutions = await this.Extensibility.Workspaces().QuerySolutionAsync(s => s, cancellationToken);
        foreach (var solution in solutions)
        {
            await solution.AsQueryable().BuildAsync(cancellationToken);
        }

        await this.Extensibility.Shell().ShowPromptAsync($"Building the solution.", PromptOptions.OK, cancellationToken);
    }
}
