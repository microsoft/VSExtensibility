namespace CommentRemover;

using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Definitions;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.TextManager.Interop;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

[CommandIcon("DeleteRegions", IconSettings.IconAndText)]
[Command("GladstoneCommentRemover.RemoveRegions", CommandDescription)]
[CommandEnabledWhen(
	"IsValidFile",
	new string[] { "IsValidFile" },
	new string[] { "ClientContext:Shell.ActiveSelectionFileName=(.cs|.vb|.fs)$" })]
public class RemoveRegions : BaseCommand
{
	private const string CommandDescription = "Remove Regions";

	public RemoveRegions(
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
		if (!await context.ShowPromptAsync("All regions will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
			return;

		using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);

		await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

		var view = await this.GetCurentTextViewAsync();
		var dte = await this.Dte.GetServiceAsync();
		try
		{
			dte.UndoContext.Open(CommandDescription);

			this.RemoveRegionsFromBuffer(view);
		}
		catch (Exception ex)
		{
			Debug.Write(ex);
		}
		finally
		{
			dte.UndoContext.Close();
		}
	}

	private void RemoveRegionsFromBuffer(IWpfTextView view)
	{
		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var line in view.TextBuffer.CurrentSnapshot.Lines.Reverse())
			{
				if (line.Extent.IsEmpty)
					continue;

				string text = line.GetText()
								  .TrimStart('/', '*')
								  .Replace("<!--", string.Empty)
								  .TrimStart()
								  .ToLowerInvariant();

				if (text.StartsWith("#region") || text.StartsWith("#endregion") || text.StartsWith("#end region"))
				{
					// Strip next line if empty
					if (view.TextBuffer.CurrentSnapshot.LineCount > line.LineNumber + 1)
					{
						var next = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(line.LineNumber + 1);

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
