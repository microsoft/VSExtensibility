namespace CommentRemover;

using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.Extensibility.VSSdkCompatibility;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.TextManager.Interop;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

[VisualStudioContribution]
internal class RemoveRegions : CommentRemoverCommand
{
	private const string CommandDescription = "%CommentRemover.RemoveRegions.DisplayName%";

	public RemoveRegions(
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
		Icon = new(ImageMoniker.Custom("DeleteRegions"), IconSettings.IconAndText),
		EnabledWhen = CommandEnabledWhen,
	};

	public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		if (!await this.Extensibility.Shell().ShowPromptAsync("All regions will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
		{
			return;
		}

		using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);

		await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

		// Not using context.GetActiveTextViewAsync here because VisualStudio.Extensibility doesn't support classification yet.
		var view = await this.GetCurentTextViewAsync();
		var dte = await this.Dte.GetServiceAsync();
		try
		{
			dte.UndoContext.Open(CommandDescription);

			this.RemoveRegionsFromBuffer(view);
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

	private void RemoveRegionsFromBuffer(IWpfTextView view)
	{
		using (var edit = view.TextBuffer.CreateEdit())
		{
			foreach (var line in view.TextBuffer.CurrentSnapshot.Lines.Reverse())
			{
				if (line.Extent.IsEmpty)
				{
					continue;
				}

				string text = line.GetText()
								  .TrimStart('/', '*')
								  .Replace("<!--", string.Empty)
								  .TrimStart();

				if (text.StartsWith("#region", StringComparison.OrdinalIgnoreCase) ||
					text.StartsWith("#endregion", StringComparison.OrdinalIgnoreCase) ||
					text.StartsWith("#end region", StringComparison.OrdinalIgnoreCase))
				{
					// Strip next line if empty
					if (view.TextBuffer.CurrentSnapshot.LineCount > line.LineNumber + 1)
					{
						var next = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(line.LineNumber + 1);

						if (IsLineEmpty(next))
						{
							edit.Delete(next.Start, next.LengthIncludingLineBreak);
						}
					}

					edit.Delete(line.Start, line.LengthIncludingLineBreak);
				}
			}

			edit.Apply();
		}
	}
}
