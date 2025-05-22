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
/// A sample command for querying the project system.
/// </summary>
[VisualStudioContribution]
public class QueryFileCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.QueryFileCommand.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
            project => project.With(project => project.Name)
                              .With(project => project.Path)
                              .With(project => project.Files.With(file => file.FileName)),
            cancellationToken);

        StringBuilder message = new StringBuilder($"\n \n === Querying File === \n");

        foreach (var project in result)
        {
            _ = message.Append(CultureInfo.CurrentCulture, $"{project.Name}\n");

            foreach (var file in project.Files)
            {
                _ = message.Append(CultureInfo.CurrentCulture, $" \t {file.FileName}\n");
            }
        }

        await this.Extensibility.Shell().ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
    }
}
