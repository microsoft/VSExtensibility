// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for renaming a project.
/// </summary>
[VisualStudioContribution]
public class RenameProjectCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.RenameProjectCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var serviceBroker = context.Extensibility.ServiceBroker;
        ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);
        var result = await querySpace.Projects
            .Where(p => p.Name == "ConsoleApp1")
            .AsUpdatable()
            .Rename("NewProjectName")
            .ExecuteAsync(cancellationToken);

        await this.Extensibility.Shell().ShowPromptAsync("Renamed Project to NewProjectName.", PromptOptions.OK, cancellationToken);
    }
}
