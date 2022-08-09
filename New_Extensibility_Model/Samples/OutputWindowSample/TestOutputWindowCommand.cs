// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Definitions;
using Microsoft.VisualStudio.Extensibility.Documents;

/// <summary>
/// A sample command for displaying a test message in the output window.
/// </summary>
[Command("TestOutputWindowCommand", "Test the Output Window", placement: CommandPlacement.ToolsMenu)]
[CommandIcon(KnownMonikers.ToolWindow, IconSettings.IconAndText)]
public class TestOutputWindowCommand : Command
{
	private OutputWindow? outputWindow;

	/// <summary>
	/// Initializes a new instance of the <see cref="TestOutputWindowCommand" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	/// <param name="id">
	/// Command identifier.
	/// </param>
	public TestOutputWindowCommand(VisualStudioExtensibility extensibility, string id)
		: base(extensibility, id)
	{
	}

	/// <inheritdoc />
	public override async Task InitializeAsync(CancellationToken cancellationToken)
	{
		this.outputWindow = await this.GetOutputWindowAsync(cancellationToken);
		await base.InitializeAsync(cancellationToken);
	}

	/// <inheritdoc />
	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		if (this.outputWindow != null)
		{
			await this.outputWindow.Writer.WriteLineAsync("This is a test of the output window.");
		}
	}

	private async Task<OutputWindow?> GetOutputWindowAsync(CancellationToken cancellationToken)
	{
		string id = "MyOutputWindow";
		string displayNameResourceId = nameof(Strings.OutputWindowDisplayName);
		return await this.Extensibility.Views().Output.GetChannelAsync(id, displayNameResourceId, cancellationToken);
	}
}
