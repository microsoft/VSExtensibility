// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using System.Text;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for querying the project system for output groups by ID.
/// </summary>
[VisualStudioContribution]
public class QueryOutputGroupByIdCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.QueryOutputGroupByIdCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu() },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        StringBuilder message = new StringBuilder();

        var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
            project => project.With(p => p.Name)
                              .With(p => p.ActiveConfigurations.With(c => c.Name)),
            cancellationToken);

        message.Append($"\n \n === Querying OutputGroups by Id === \n");

        foreach (var project in result)
        {
            message.Append($"{project.Name}\n");

            foreach (var config in project.ActiveConfigurations)
            {
                message.Append($" \t {config.Name}\n");

                foreach (var group in config.OutputGroups)
                {
                    // This is needed for byId:
                    var newResult = await group
                        .AsQueryable()
                        .With(g => g.Name)
                        .ExecuteQueryAsync();

                    message.Append($"\t \t {newResult.First().Name}\n");
                }
            }
        }

        await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
    }
}
