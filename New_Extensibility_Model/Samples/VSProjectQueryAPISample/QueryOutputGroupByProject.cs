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
	[Command("VSProjectQueryAPISample.QueryOutputGroupByProject", "Query Output Group By Project", placement: CommandPlacement.ToolsMenu)]
	internal class QueryOutputGroupByProject : Command
	{
		private TraceSource traceSource;

		public QueryOutputGroupByProject(VisualStudioExtensibility extensibility, TraceSource traceSource, string id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.DisplayName = "Query Output Group By Project";
			StringBuilder message = new StringBuilder();

			var serviceBroker = context.Extensibility.ServiceBroker;
			ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);

			//// Querying Output Groups
			var result = querySpace.Projects
							   .With(p => p.Name)
							   .With(p => p.ActiveConfigurations
								   .With(c => c.Name)
								   .With(c => c.OutputGroups
									   .With(g => g.Name)))
							   .QueryAsync(CancellationToken.None);

			message.Append($"\n \n === Querying OutputGroups by Project === \n");

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
