// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleRemoteCommandSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

/// <summary>
/// A sample command handler showing how to declare command definition and simple placement.
/// </summary>
[VisualStudioContribution]
public class CommandHandler : Command
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CommandHandler"/> class.
	/// </summary>
	/// <param name="extensibility">Extensibility object instance.</param>
	public CommandHandler(VisualStudioExtensibility extensibility)
		: base(extensibility)
	{
	}

	/// <inheritdoc />
	public override CommandConfiguration CommandConfiguration => new("%SimpleRemoteCommandSample.CommandHandler.DisplayName%")
	{
		Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
		Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
	};

	/// <inheritdoc />
	public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		// Do any work you want your command handler to do here
		return Task.CompletedTask;
	}
}
