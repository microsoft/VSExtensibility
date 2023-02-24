namespace CommentRemover;

using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Extensibility.VSSdkCompatibility;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.TextManager.Interop;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

[VisualStudioContribution]
internal class RemoveTasks : CommentRemoverCommand
{
	private const string CommandDescription = "%CommentRemover.RemoveTasks.DisplayName%";

	public RemoveTasks(
		VisualStudioExtensibility extensibility,
		TraceSource traceSource,
		AsyncServiceProviderInjection<DTE, DTE2> dte,
		MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
		MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
		AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
		: base(extensibility, traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager)
	{
	}

	/// <inheritdoc />
	public override CommandConfiguration CommandConfiguration => new(CommandDescription)
	{
		Icon = new(ImageMoniker.KnownValues.DeleteTaskList, IconSettings.IconAndText),
		EnabledWhen = CommandEnabledWhen,
	};

	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		if (!await context.ShowPromptAsync("All tasks comment will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
		{
			return;
		}

		using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);

		await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

		// Not using context.GetActiveTextViewAsync here because the classification feature is not supported by VisualStudio.Extensibility yet.
		var view = await this.GetCurentTextViewAsync();
		var mappingSpans = await this.GetClassificationSpansAsync(view, "comment");
		if (!mappingSpans.Any())
		{
			return;
		}

		var dte = await this.Dte.GetServiceAsync();
		try
		{
			dte.UndoContext.Open(CommandDescription);

			this.RemoveCommmentsFromBuffer(view, mappingSpans);
		}
		catch (Exception ex)
		{
			this.TraceSource.TraceInformation(ex.ToString());
		}
		finally
		{
			dte.UndoContext.Close();
		}
	}

	private void RemoveCommmentsFromBuffer(IWpfTextView view, IEnumerable<IMappingSpan> mappingSpans)
	{
		var affectedSpans = new List<Span>();
		var affectedLines = new List<int>();

		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var mappingSpan in mappingSpans)
			{
				var start = mappingSpan.Start.GetPoint(view.TextBuffer, PositionAffinity.Predecessor);
				var end = mappingSpan.End.GetPoint(view.TextBuffer, PositionAffinity.Successor);

				if (!start.HasValue || !end.HasValue)
				{
					continue;
				}

				var span = new Span(start.Value, end.Value - start.Value);
				var line = view.TextBuffer.CurrentSnapshot.Lines.First(l => l.Extent.IntersectsWith(span));

				if (ContainsTaskComment(line))
				{
					edit.Delete(span);

					if (!affectedLines.Contains(line.LineNumber))
					{
						affectedLines.Add(line.LineNumber);
					}
				}
			}

			edit.Apply();
		}

		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var lineNumber in affectedLines)
			{
				var line = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(lineNumber);

				if (IsLineEmpty(line))
				{
					edit.Delete(line.Start, line.LengthIncludingLineBreak);
				}
			}

			edit.Apply();
		}
	}
}
