namespace CommandParentingSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

internal static class ExtensionCommandConfiguration
{
	[VisualStudioContribution]
	public static ToolbarConfiguration ToolBar => new("%ToolBar.DisplayName%")
	{
		Children = new[]
		{
			ToolbarChild.Command<SampleCommand>(),
		},
	};
}
