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
	[Command("VSProjectQueryAPISample.QueryOutputGroupById", "Query Output Group By Id", placement: CommandPlacement.ToolsMenu)]
	internal class QueryOutputGroupById : Command
	{
		private TraceSource traceSource;

		public QueryOutputGroupById(VisualStudioExtensibility extensibility, TraceSource traceSource, string id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.DisplayName = "Query Output Group By Id";
			StringBuilder message = new StringBuilder();

			var serviceBroker = context.Extensibility.ServiceBroker;
			ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);

			//// Querying Output Groups
			var result = querySpace.Projects
					.With(p => p.Name)
					.With(p => p.ActiveConfigurations
						.With(c => c.Name)
						.With(c => c.OutputGroups))
					.QueryAsync(CancellationToken.None);

			message.Append($"\n \n === Querying OutputGroups by Id === \n");

			await foreach (var project in result)
			{
				message.Append($"{project.Value.Name}\n");

				foreach (var config in project.Value.ActiveConfigurations)
				{
					message.Append($" \t {config.Name}\n");

					foreach (var group in config.OutputGroups)
					{
						// This is needed for byId:
						var newResult = await group.AsQueryable()
						   .With(g => g.Name)
						  .ExecuteQueryAsync();

						message.Append($"\t \t {newResult.First().Name}\n");
					}
				}
			}

			await context.ShowPromptAsync(
		   message.ToString(),
		   PromptOptions.OK,
		   cancellationToken);
		}
	}
}
