﻿namespace CommentRemover;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

internal static class ExtensionCommandConfiguration
{
	[VisualStudioContribution]
	public static MenuConfiguration CommentRemoverMenu => new("%CommentRemover.CommentRemoverMenu.DisplayName%")
	{
		Priority = 1,
		Placements = new[]
		{
			CommandPlacement.KnownPlacements.ExtensionsMenu,
		},
		Children = new[]
		{
			MenuChild.Command<RemoveAllComments>(),
			MenuChild.Command<RemoveXmlDocComments>(),
			MenuChild.Command<RemoveAllExceptXmlDocComments>(),
			MenuChild.Separator,
			MenuChild.Command<RemoveTasks>(),
			MenuChild.Command<RemoveAllExceptTaskComments>(),
			MenuChild.Separator,
			MenuChild.Command<RemoveRegions>(),
		},
	};
}
