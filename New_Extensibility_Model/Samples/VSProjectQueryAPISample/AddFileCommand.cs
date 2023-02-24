// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.ProjectSystem.Query;

/// <summary>
/// A sample command for adding a file.
/// </summary>
[VisualStudioContribution]
public class AddFileCommand : Command
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddFileCommand" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	public AddFileCommand(VisualStudioExtensibility extensibility)
		: base(extensibility)
	{
	}

	/// <inheritdoc />
	public override CommandConfiguration CommandConfiguration => new("%VSProjectQueryAPISample.AddFileCommand.DisplayName%")
	{
		Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
		Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
	};

	/// <inheritdoc />
	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		await this.Extensibility.Workspaces().UpdateProjectsAsync(
			project => project.Where(project => project.Name == "ConsoleApp1"),
			project => project.AddFile("CreatedFile.txt"),
			cancellationToken);

		await context.ShowPromptAsync("Created new file in ConsoleApp1.", PromptOptions.OK, cancellationToken);
	}
}
