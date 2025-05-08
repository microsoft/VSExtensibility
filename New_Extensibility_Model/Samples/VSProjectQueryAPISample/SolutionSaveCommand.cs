// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for saving the solution.
/// </summary>
[VisualStudioContribution]
public class SolutionSaveCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.SolutionSaveCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();
        IQueryResults<ISolutionSnapshot> solutions = await querySpace.QuerySolutionAsync(s => s, cancellationToken);
        foreach (var solution in solutions)
        {
            await solution.SaveAsync(cancellationToken);
        }

        await this.Extensibility.Shell().ShowPromptAsync($"Saving the solution.", PromptOptions.OK, cancellationToken);
    }
}
