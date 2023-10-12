// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DialogSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

/// <summary>
/// A sample command for showing a dialog.
/// </summary>
[VisualStudioContribution]
public class MyDialogCommand : Command
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MyDialogCommand" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	/// <param name="name">
	/// Command identifier.
	/// </param>
	public MyDialogCommand(VisualStudioExtensibility extensibility)
		: base(extensibility)
	{
	}

	/// <inheritdoc />
	public override CommandConfiguration CommandConfiguration => new("%DialogSample.MyDialogCommand.DisplayName%")
	{
		Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu() },
		Icon = new(ImageMoniker.KnownValues.Dialog, IconSettings.IconAndText),
	};

	/// <inheritdoc />
	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		// Ownership of the RemoteUserControl is transferred to VisualStudio, so it should not be disposed by the extension
		#pragma warning disable CA2000 // Dispose objects before losing scope
		var control = new MyDialogControl(null);
		#pragma warning restore CA2000 // Dispose objects before losing scope

		await this.Extensibility.Shell().ShowDialogAsync(control, cancellationToken);
	}
}
