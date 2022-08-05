// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Extensions.MarkdownLinter
{
	using System;
	using System.Diagnostics;
	using System.Linq;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;
	using Microsoft.VisualStudio.ProjectSystem.Query;

	/// <summary>
	/// A command to execute linter on the current file selected in Solution Explorer.
	/// </summary>
	/// <remarks>
	/// This command utilizes <see cref="CommandEnabledWhenAttribute"/> to describe when commmand state is enabled.
	/// </remarks>
	[Command(
		"VisualStudio.Extensions.MarkdownLinter.RunLinterOnActiveDocument",
		"Run Linter on open file",
		containerType: typeof(MarkdownLinterExtension),
		placement: CommandPlacement.ToolsMenu)]
	[CommandEnabledWhen(
		"FileSelected",
		new string[] { "FileSelected" },
		new string[] { "ClientContext:Shell.ActiveSelectionFileName=.+" })]
	[CommandIcon("MarkdownIcon", IconSettings.IconAndText)]
	internal class RunLinterOnCurrentFileCommand : Command
	{
		private readonly TraceSource logger;
		private MarkdownDiagnosticsService diagnosticsProvider;

		/// <summary>
		/// Initializes a new instance of the <see cref="RunLinterOnCurrentFileCommand"/> class.
		/// </summary>
		/// <param name="extensibility">Extensibility object.</param>
		/// <param name="traceSource">Logger instance that can be used to log extension actions.</param>
		/// <param name="diagnosticsProvider">Local diagnostics provider service instance.</param>
		/// <param name="id">Command identifier.</param>
		public RunLinterOnCurrentFileCommand(VisualStudioExtensibility extensibility, TraceSource traceSource, MarkdownDiagnosticsService diagnosticsProvider, string id)
			: base(extensibility, id)
		{
			this.logger = Requires.NotNull(traceSource, nameof(traceSource));
			this.diagnosticsProvider = Requires.NotNull(diagnosticsProvider, nameof(diagnosticsProvider));

			this.logger.TraceEvent(TraceEventType.Information, 0, $"Initializing {nameof(RunLinterOnCurrentFileCommand)} instance.");
		}

		/// <inheritdoc />
		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			try
			{
				// Get the selected item URIs from IDE context that reprents the state when command was executed.
				var selectedItemPaths = new Uri[] { await context.GetSelectedPathAsync(cancellationToken) };

				// Enumerate through each selection and run linter on each selected item.
				foreach (var selectedItem in selectedItemPaths.Where(p => p.IsFile))
				{
					await this.diagnosticsProvider.ProcessFileAsync(selectedItem, cancellationToken);
				}
			}
			catch (InvalidOperationException ex)
			{
				this.logger.TraceEvent(TraceEventType.Error, 0, ex.ToString());
			}
		}
	}
}
