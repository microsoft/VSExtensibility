namespace CommentRemover;

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
using System.Text.RegularExpressions;

internal abstract class CommentRemoverCommand : Microsoft.VisualStudio.Extensibility.Commands.Command
{
	private static readonly string[] TaskCaptions = { "TODO", "HACK", "UNDONE", "UNRESOLVEDMERGECONFLICT" };

	public CommentRemoverCommand(
		VisualStudioExtensibility extensibility,
		TraceSource traceSource,
		AsyncServiceProviderInjection<DTE, DTE2> dte,
		MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
		MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
		AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager,
		string id)
		: base(extensibility, id)
	{
		this.TraceSource = traceSource;
		this.Dte = dte;
		this.BufferTagAggregatorFactoryService = bufferTagAggregatorFactoryService;
		this.EditorAdaptersFactoryService = editorAdaptersFactoryService;
		this.TextManager = textManager;
	}

	protected AsyncServiceProviderInjection<DTE, DTE2> Dte { get; private set; }

	protected MefInjection<IBufferTagAggregatorFactoryService> BufferTagAggregatorFactoryService { get; private set; }

	protected MefInjection<IVsEditorAdaptersFactoryService> EditorAdaptersFactoryService { get; private set; }

	protected AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> TextManager { get; private set; }

	protected TraceSource TraceSource { get; private set; }

	protected static bool IsLineEmpty(ITextSnapshotLine line)
	{
		var text = line.GetText().Trim();

		return string.IsNullOrWhiteSpace(text)
			   || text == "<!--"
			   || text == "-->"
			   || text == "<%%>"
			   || text == "<%"
			   || text == "%>"
			   || Regex.IsMatch(text, @"<!--(\s+)?-->");
	}

	protected static bool IsXmlDocComment(ITextSnapshotLine line)
	{
		var text = line.GetText().Trim();
		Microsoft.VisualStudio.Utilities.IContentType contentType = line.Snapshot.TextBuffer.ContentType;

		if (contentType.IsOfType("CSharp") && text.StartsWith("///", StringComparison.Ordinal))
		{
			return true;
		}

		if (contentType.IsOfType("FSharp") && text.StartsWith("///", StringComparison.Ordinal))
		{
			return true;
		}

		if (contentType.IsOfType("Basic") && text.StartsWith("'''", StringComparison.Ordinal))
		{
			return true;
		}

		return false;
	}

	protected static bool ContainsTaskComment(ITextSnapshotLine line)
	{
		string text = line.GetText().ToUpperInvariant();

		foreach (var task in TaskCaptions)
		{
			if (text.Contains(task + ":"))
			{
				return true;
			}
		}

		return false;
	}

	protected async Task<IEnumerable<IMappingSpan>> GetClassificationSpansAsync(IWpfTextView view, string classificationName)
	{
		if (view is null)
		{
			return Enumerable.Empty<IMappingSpan>();
		}

		IBufferTagAggregatorFactoryService bufferTagAggregatorFactoryService = await this.BufferTagAggregatorFactoryService.GetServiceAsync();
		ITagAggregator<IClassificationTag> classifier = bufferTagAggregatorFactoryService.CreateTagAggregator<IClassificationTag>(view.TextBuffer);
		var snapshot = new SnapshotSpan(view.TextBuffer.CurrentSnapshot, 0, view.TextBuffer.CurrentSnapshot.Length);

		return from s in classifier.GetTags(snapshot).Reverse()
			   where s.Tag.ClassificationType.Classification.IndexOf(classificationName, StringComparison.OrdinalIgnoreCase) > -1
			   select s.Span;
	}

	protected async Task<IWpfTextView> GetCurentTextViewAsync()
	{
		IVsEditorAdaptersFactoryService editorAdapter = await this.EditorAdaptersFactoryService.GetServiceAsync();
		var view = editorAdapter.GetWpfTextView(await this.GetCurrentNativeTextViewAsync());
		Assumes.Present(view);
		return view;
	}

	protected async Task<IVsTextView> GetCurrentNativeTextViewAsync()
	{
		var textManager = await this.TextManager.GetServiceAsync();
		ErrorHandler.ThrowOnFailure(textManager.GetActiveView(1, null, out IVsTextView activeView));
		return activeView;
	}
}
