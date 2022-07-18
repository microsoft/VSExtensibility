namespace CommentRemover;

using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Definitions;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.TextManager.Interop;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

[CommandIcon(KnownMonikers.Uncomment, IconSettings.IconAndText)]
[CommandShortcut(mod1: "Control", key1: "K", mod2: "Control", key2: "Q")]
[Command("CommentRemover.RemoveAllComment", CommandDescription)]
[CommandEnabledWhen(
	"IsValidFile",
	new string[] { "IsValidFile" },
	new string[] { @"ClientContext:Shell.ActiveSelectionFileName=\.(cs|vb|fs)$" })]
internal class RemoveAllComments : CommentRemoverCommand
{
	private const string CommandDescription = "Remove All";

	public RemoveAllComments(
		VisualStudioExtensibility extensibility,
		TraceSource traceSource,
		AsyncServiceProviderInjection<DTE, DTE2> dte,
		MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
		MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
		AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager,
		string id)
		: base(extensibility, traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager, id)
	{
	}

	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		if (!await context.ShowPromptAsync("All comments will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
			return;

		using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);

		await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

		// Not using context.GetActiveTextViewAsync here because VisualStudio.Extensibility doesn't support classification yet.
		var view = await this.GetCurentTextViewAsync();
		var mappingSpans = await this.GetClassificationSpansAsync(view, "comment");
		if (!mappingSpans.Any())
			return;

		var dte = await this.Dte.GetServiceAsync();
		try
		{
			dte.UndoContext.Open(CommandDescription);

			DeleteFromBuffer(view, mappingSpans);
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

	private static void DeleteFromBuffer(IWpfTextView view, IEnumerable<IMappingSpan> mappingSpans)
	{
		var affectedLines = new List<int>();

		RemoveCommentSpansFromBuffer(view, mappingSpans, affectedLines);
		RemoveAffectedEmptyLines(view, affectedLines);
	}

	private static void RemoveCommentSpansFromBuffer(IWpfTextView view, IEnumerable<IMappingSpan> mappingSpans, IList<int> affectedLines)
	{
		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var mappingSpan in mappingSpans)
			{
				var start = mappingSpan.Start.GetPoint(view.TextBuffer, PositionAffinity.Predecessor);
				var end = mappingSpan.End.GetPoint(view.TextBuffer, PositionAffinity.Successor);

				if (!start.HasValue || !end.HasValue)
					continue;

				var span = new Span(start.Value, end.Value - start.Value);
				var lines = view.TextBuffer.CurrentSnapshot.Lines.Where(l => l.Extent.IntersectsWith(span));

				foreach (var line in lines)
				{
					if (IsXmlDocComment(line))
					{
						edit.Replace(line.Start, line.Length, string.Empty.PadLeft(line.Length));
					}

					if (!affectedLines.Contains(line.LineNumber))
						affectedLines.Add(line.LineNumber);
				}

				var mappingText = view.TextBuffer.CurrentSnapshot.GetText(span.Start, span.Length);
				string empty = Regex.Replace(mappingText, "([\\S]+)", string.Empty);

				edit.Replace(span.Start, span.Length, empty);
			}

			edit.Apply();
		}
	}

	private static void RemoveAffectedEmptyLines(IWpfTextView view, IList<int> affectedLines)
	{
		if (!affectedLines.Any())
			return;

		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var lineNumber in affectedLines)
			{
				var line = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(lineNumber);

				if (IsLineEmpty(line))
				{
					// Strip next line if empty
					if (view.TextBuffer.CurrentSnapshot.LineCount > line.LineNumber + 1)
					{
						var next = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(lineNumber + 1);

						if (IsLineEmpty(next))
							edit.Delete(next.Start, next.LengthIncludingLineBreak);
					}

					edit.Delete(line.Start, line.LengthIncludingLineBreak);
				}
			}

			edit.Apply();
		}
	}
}
