// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace UserPromptSample;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;

[VisualStudioContribution]
public class SampleCommand : Command
{
	public SampleCommand(VisualStudioExtensibility extensibility)
		: base(extensibility)
	{
	}

	/// <inheritdoc />
	public override CommandConfiguration CommandConfiguration => new("%UserPromptSample.SampleCommand.DisplayName%")
	{
		TooltipText = "%UserPromptSample.SampleCommand.ToolTip%",
		Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
	};

	public enum TokenThemeResult
	{
		None,
		Solarized,
		OneDark,
		GruvBox,
	}

	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
	{
		// Asking the user to confirm an operation.
		if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel, ct))
		{
			return;
		}

		// Asking the user to confirm a dangerous operation.
		if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel.WithCancelAsDefault(), ct))
		{
			return;
		}

		// OK-only prompt
		await context.ShowPromptAsync("The extension must reload.", PromptOptions.OK, ct);

		// Custom prompt
		var themeResult = await context.ShowPromptAsync(
			"Which theme should be used for the generated output?",
			new PromptOptions<TokenThemeResult>
			{
				Choices =
				{
			{ "Solarized Is Awesome", TokenThemeResult.Solarized },
			{ "OneDark Is The Best", TokenThemeResult.OneDark },
			{ "GruvBox Is Groovy", TokenThemeResult.GruvBox },
				},
				DismissedReturns = TokenThemeResult.None,
				DefaultChoiceIndex = 2,
			},
			ct);

		Debug.WriteLine($"Selected Token Theme: {themeResult}");
	}
}
