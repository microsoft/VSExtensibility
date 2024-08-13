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
/// A sample command for querying the project system for output groups by project.
/// </summary>
[VisualStudioContribution]
public class QueryOutputGroupByProjectCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.QueryOutputGroupByProjectCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();

        var result = await querySpace.QueryProjectsAsync(
            project => project.With(p => p.Name)
                              .With(p => p.ActiveConfigurations
                              .With(c => c.Name)
                              .With(c => c.OutputGroups.With(g => g.Name))),
            cancellationToken);

        StringBuilder message = new StringBuilder($"\n \n === Querying OutputGroups by Project === \n");

        foreach (var project in result)
        {
            _ = message.Append(CultureInfo.CurrentCulture, $"{project.Name}\n");

            foreach (var config in project.ActiveConfigurations)
            {
                _ = message.Append(CultureInfo.CurrentCulture, $" \t {config.Name}\n");

                foreach (var group in config.OutputGroups)
                {
                    _ = message.Append(CultureInfo.CurrentCulture, $"\t \t {group.Name}\n");
                }
            }
        }

        await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
    }
}
