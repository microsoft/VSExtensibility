using EnvDTE;
using EnvDTE80;
using Microsoft;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Threading;
using System.Diagnostics;

namespace CommentRemover;

public abstract class BaseCommand : Microsoft.VisualStudio.Extensibility.Commands.Command
{
    protected AsyncServiceProviderInjection<DTE, DTE2> Dte { get; private set; }

    protected MefInjection<IBufferTagAggregatorFactoryService> BufferTagAggregatorFactoryService { get; private set; }

    protected MefInjection<IVsEditorAdaptersFactoryService> EditorAdaptersFactoryService { get; private set; }

    protected AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> TextManager { get; private set; }

    protected TraceSource TraceSource { get; private set; }

    public BaseCommand(
        VisualStudioExtensibility extensibility,
        TraceSource traceSource,
        AsyncServiceProviderInjection<DTE, DTE2> dte,
        MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
        MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
        AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager,
        string id)
        : base(extensibility, id)
    {
        TraceSource = traceSource;
        Dte = dte;
        BufferTagAggregatorFactoryService = bufferTagAggregatorFactoryService;
        EditorAdaptersFactoryService = editorAdaptersFactoryService;
        TextManager = textManager;
    }

    protected async Task<IEnumerable<IMappingSpan>> GetClassificationSpansAsync(IWpfTextView view, string classificationName)
    {
        if (view is null)
        {
            return Enumerable.Empty<IMappingSpan>();
        }

        IBufferTagAggregatorFactoryService bufferTagAggregatorFactoryService = await BufferTagAggregatorFactoryService.GetServiceAsync();
        ITagAggregator<IClassificationTag> classifier = bufferTagAggregatorFactoryService.CreateTagAggregator<IClassificationTag>(view.TextBuffer);
        var snapshot = new SnapshotSpan(view.TextBuffer.CurrentSnapshot, 0, view.TextBuffer.CurrentSnapshot.Length);

        return from s in classifier.GetTags(snapshot).Reverse()
               where s.Tag.ClassificationType.Classification.IndexOf(classificationName, StringComparison.OrdinalIgnoreCase) > -1
               select s.Span;
    }

    protected async Task<IWpfTextView> GetCurentTextViewAsync()
    {
        IVsEditorAdaptersFactoryService editorAdapter = await EditorAdaptersFactoryService.GetServiceAsync();
        var view = editorAdapter.GetWpfTextView(await GetCurrentNativeTextViewAsync());
        Assumes.Present(view);
        return view;
    }

    protected async Task<IVsTextView> GetCurrentNativeTextViewAsync()
    {
        var textManager = await TextManager.GetServiceAsync();
        ErrorHandler.ThrowOnFailure(textManager.GetActiveView(1, null, out IVsTextView activeView));
        return activeView;
    }
}
