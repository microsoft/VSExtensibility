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
	[Command("VSProjectQueryAPISample.QueryOutputGroupByName", "Query Output Group By Name", placement: CommandPlacement.ToolsMenu)]
	internal class QueryOutputGroupByName : Command
	{
		private TraceSource traceSource;

		public QueryOutputGroupByName(VisualStudioExtensibility extensibility, TraceSource traceSource, string id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.DisplayName = "Query Output Group By Name";
			StringBuilder message = new StringBuilder();

			var serviceBroker = context.Extensibility.ServiceBroker;
			ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);

			//// Querying Output Groups
			var result = querySpace.Projects
				.With(p => p.Name)
				.With(p => p.ActiveConfigurations
					.With(c => c.Name)
					.With(c => c.OutputGroupsByName("Built", "XmlSerializer", "SourceFiles", "RandomNameShouldntBePickedUp")
					.With(g => g.Name)))
				.QueryAsync(CancellationToken.None);

			message.Append($"\n \n === Querying OutputGroups by Name === \n");

			await foreach (var project in result)
			{
				_ = message.Append($"{project.Value.Name}\n");

				foreach (var config in project.Value.ActiveConfigurations)
				{
					_ = message.Append($" \t {config.Name}\n");

					foreach (var group in config.OutputGroups)
					{
						_ = message.Append($"\t \t {group.Name}\n");
					}
				}
			}

			await context.ShowPromptAsync(message.ToString(), PromptOptions.OK, cancellationToken);
		}
	}
}
