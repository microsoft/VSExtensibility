// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowExtension;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Definitions;

/// <summary>
/// A sample command for showing a tool window.
/// </summary>
[Command("ToolWindowExtension.MyToolWindowCommand", "My Tool Window", placement: CommandPlacement.ToolsMenu)]
[CommandIcon(KnownMonikers.ToolWindow, IconSettings.IconAndText)]
public class MyToolWindowCommand : Command
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MyToolWindowCommand" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	/// <param name="name">
	/// Command identifier.
	/// </param>
	public MyToolWindowCommand(VisualStudioExtensibility extensibility, string name)
		: base(extensibility, name)
	{
	}

	/// <inheritdoc />
	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		await this.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
	}
}
