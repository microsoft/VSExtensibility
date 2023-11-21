namespace CommentRemover;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
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

[VisualStudioContribution]
internal class RemoveXmlDocComments : CommentRemoverCommand
{
    private const string CommandDescription = "%CommentRemover.RemoveXmlDocComments.DisplayName%";

    public RemoveXmlDocComments(
        TraceSource traceSource,
        AsyncServiceProviderInjection<DTE, DTE2> dte,
        MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
        MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
        AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
        : base(traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager)
    {
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new(CommandDescription)
    {
        Icon = new(ImageMoniker.KnownValues.ClearDictionary, IconSettings.IconAndText),
        EnabledWhen = CommandEnabledWhen,
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        if (!await this.Extensibility.Shell().ShowPromptAsync("All Xml Docs comments will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
        {
            return;
        }

        using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);

        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

        // Not using context.GetActiveTextViewAsync here because VisualStudio.Extensibility doesn't support classification yet.
        var view = await this.GetCurrentTextViewAsync();
        var mappingSpans = await this.GetClassificationSpansAsync(view, "comment");
        if (!mappingSpans.Any())
        {
            return;
        }

        var dte = await this.Dte.GetServiceAsync();
        try
        {
            dte.UndoContext.Open(CommandDescription);

            this.RemoveCommentsFromBuffer(view, mappingSpans);
        }
#pragma warning disable CA1031 // Do not catch general exception types
        catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
        {
            this.TraceSource.TraceInformation(ex.ToString());
        }
        finally
        {
            dte.UndoContext.Close();
        }
    }

    private void RemoveCommentsFromBuffer(IWpfTextView view, IEnumerable<IMappingSpan> mappingSpans)
    {
        var affectedLines = new List<int>();

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

            if (!affectedLines.Contains(line.LineNumber))
            {
                affectedLines.Add(line.LineNumber);
            }
        }

        using var edit = view.TextBuffer.CreateEdit();
        foreach (var lineNumber in affectedLines)
        {
            var line = view.TextBuffer.CurrentSnapshot.GetLineFromLineNumber(lineNumber);
            edit.Delete(line.Start, line.LengthIncludingLineBreak);
        }

        edit.Apply();
    }
}
