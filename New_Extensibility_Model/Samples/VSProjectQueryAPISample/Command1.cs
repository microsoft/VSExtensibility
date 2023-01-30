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
	[Command("VSProjectQueryAPISample.QueryFile", "Query File", placement: CommandPlacement.ToolsMenu)]
	internal class QueryFile : Command
	{
		private TraceSource traceSource;

		public QueryFile(VisualStudioExtensibility extensibility, TraceSource traceSource, string id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.DisplayName = "Query File";
			StringBuilder message = new StringBuilder();

			var serviceBroker = context.Extensibility.ServiceBroker;
			ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);

			//// Querying Project Files
			var result = querySpace.Projects
					 .With(project => project.Name)
					 .With(project => project.Path)
					 .With(project => project.Files
						.With(file => file.FileName))
			.QueryAsync(CancellationToken.None);

			message.Append($"\n \n === Querying File === \n");

			await foreach (var project in result)
			{
				_ = message.Append($"{project.Value.Name}\n");

				foreach (var file in project.Value.Files)
				{
					_ = message.Append($" \t {file.FileName}\n");
				}
			}

			await context.ShowPromptAsync(
		   message.ToString(),
		   PromptOptions.OK,
		   cancellationToken);
		}
	}
}
