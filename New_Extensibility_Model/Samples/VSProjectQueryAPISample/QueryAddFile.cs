namespace VSProjectQueryAPISample
{
	using System.Diagnostics;
	using System.Text;
	using Microsoft;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;
	using Microsoft.VisualStudio.Extensibility.Shell;
	using Microsoft.VisualStudio.ProjectSystem.Query;

	[CommandIcon(KnownMonikers.Extension, IconSettings.IconAndText)]
	[Command("VSProjectQueryAPISample.QueryAddFile", "Query Add File", placement: CommandPlacement.ToolsMenu)]
	internal class QueryAddFile : Command
	{
		private TraceSource traceSource;

		public QueryAddFile(VisualStudioExtensibility extensibility, TraceSource traceSource, string id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.DisplayName = "Add File";
			StringBuilder message = new StringBuilder();

			var serviceBroker = context.Extensibility.ServiceBroker;
			ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);

			//// Adding CreatedFile.txt to ConsoleApp2
			var result = querySpace.Projects
					 .Where(project => project.Name == "ConsoleApp1")
					 .AsUpdatable()
					 .CreateFile("CreatedFile.txt")
			.ExecuteAsync();

			message.Append("\n \n === New File Added to ConsoleApp1 === \n");

			await context.ShowPromptAsync(
		   message.ToString(),
		   PromptOptions.OK,
		   cancellationToken);
		}
	}
}
