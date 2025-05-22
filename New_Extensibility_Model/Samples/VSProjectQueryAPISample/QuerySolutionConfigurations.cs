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
/// A sample command for querying solution configurations.
/// </summary>
[VisualStudioContribution]
public class QuerySolutionConfigurations : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.QuerySolutionConfigurations.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var results = await this.Extensibility.Workspaces().QuerySolutionAsync(
            solution => solution.With(solution => solution.SolutionConfigurations
            .With(c => c.Name)),
            cancellationToken);

        StringBuilder message = new StringBuilder();

        message.Append($"\n \n === Querying Solution Configurations === \n");

        foreach (var solution in results)
        {
            foreach (var solutionConfiguration in solution.SolutionConfigurations)
            {
                message.Append(CultureInfo.CurrentCulture, $"\t \t {solutionConfiguration.Name}\n");
            }
        }

        await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
    }
}
