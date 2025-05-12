// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using System.Globalization;
using System.Text;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command adding solution configurations.
/// </summary>
[VisualStudioContribution]
public class AddSolutionConfigurationCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.AddSolutionConfigurationCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();

        var queryResults = await querySpace.QuerySolutionAsync(
            solution => solution.With(solution => solution.BaseName),
            cancellationToken);

        var solutionName = queryResults.First().BaseName;

        await querySpace.UpdateSolutionAsync(
            solution => solution.Where(solution => solution.BaseName == solutionName),
            solution => solution.AddSolutionConfiguration("Foo", "Debug", false),
            cancellationToken);

        await this.Extensibility.Shell().ShowPromptAsync($"Adding solution configuration called 'Foo'.", PromptOptions.OK, cancellationToken);
    }
}
