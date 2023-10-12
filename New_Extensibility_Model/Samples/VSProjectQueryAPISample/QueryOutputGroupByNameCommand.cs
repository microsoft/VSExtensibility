// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using System.Text;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for querying the project system for output groups by name.
/// </summary>
[VisualStudioContribution]
public class QueryOutputGroupByNameCommand : Command
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryOutputGroupByNameCommand" /> class.
    /// </summary>
    /// <param name="extensibility">
    /// Extensibility object instance.
    /// </param>
    public QueryOutputGroupByNameCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.QueryOutputGroupByNameCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu() },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
            project => project.With(p => p.Name)
                              .With(p => p.ActiveConfigurations
                              .With(c => c.Name)
                              .With(c => c.OutputGroupsByName("Built", "XmlSerializer", "SourceFiles", "RandomNameShouldntBePickedUp")
                              .With(g => g.Name))),
            cancellationToken);

        StringBuilder message = new StringBuilder($"\n \n === Querying OutputGroups by Name === \n");

        foreach (var project in result)
        {
            _ = message.Append($"{project.Name}\n");

            foreach (var config in project.ActiveConfigurations)
            {
                _ = message.Append($" \t {config.Name}\n");

                foreach (var group in config.OutputGroups)
                {
                    _ = message.Append($"\t \t {group.Name}\n");
                }
            }
        }

        await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
    }
}
