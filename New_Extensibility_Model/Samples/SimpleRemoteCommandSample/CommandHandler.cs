// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleRemoteCommandSample
{
	using System.Diagnostics;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;

	/// <summary>
	/// A sample command handler showing how to declare command definition and simple placement.
	/// </summary>
	[CommandIcon("Extension", IconSettings.IconAndText)]
	[Command(CommandName, "Sample Remote Command", placement: KnownCommandPlacement.ToolsMenu)]
	public class CommandHandler : Command
	{
		private const string CommandName = "SimpleRemoteCommandSample.Command";

		/// <summary>
		/// Initializes a new instance of the <see cref="CommandHandler"/> class.
		/// </summary>
		/// <param name="extensibility">Extensibility object instance.</param>
		/// <param name="id">Command identifier.</param>
		public CommandHandler(VisualStudioExtensibility extensibility, string name)
			: base(extensibility, name)
		{
		}

		/// <inheritdoc />
		public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			// Do any work you want your command handler to do here
			return Task.CompletedTask;
		}
	}
}
