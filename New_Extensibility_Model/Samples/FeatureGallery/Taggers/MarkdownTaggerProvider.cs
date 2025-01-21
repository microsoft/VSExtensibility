// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

[VisualStudioContribution]
internal class MarkdownTaggerProvider : ExtensionPart, ITextViewTaggerProvider<TextMarkerTag>, ITextViewTaggerProvider<CodeLensTag>, ITextViewChangedListener
{
    private readonly object lockObject = new();
    private readonly Dictionary<Uri, List<MarkdownTextMarkerTagger>> textMarkerTaggers = new();
    private readonly Dictionary<Uri, List<MarkdownCodeLensTagger>> codeLensTaggers = new();

    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(TaggerTest.MyMarkdownDocumentType)],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        List<Task> tasks = new();
        lock (this.lockObject)
        {
            if (this.textMarkerTaggers.TryGetValue(args.AfterTextView.Uri, out var textMarkerTaggers))
            {
                foreach (var textMarkerTagger in textMarkerTaggers)
                {
                    tasks.Add(textMarkerTagger.TextViewChangedAsync(args.AfterTextView, args.Edits, cancellationToken));
                }
            }

            if (this.codeLensTaggers.TryGetValue(args.AfterTextView.Uri, out var codeLensTaggers))
            {
                foreach (var codeLensTagger in codeLensTaggers)
                {
                    tasks.Add(codeLensTagger.TextViewChangedAsync(args.AfterTextView, args.Edits, cancellationToken));
                }
            }
        }

        await Task.WhenAll(tasks);
    }

    Task<TextViewTagger<TextMarkerTag>> ITextViewTaggerProvider<TextMarkerTag>.CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new MarkdownTextMarkerTagger(this, textView.Document.Uri);
        lock (this.lockObject)
        {
            if (!this.textMarkerTaggers.TryGetValue(textView.Document.Uri, out var taggers))
            {
                taggers = new();
                this.textMarkerTaggers[textView.Document.Uri] = taggers;
            }

            taggers.Add(tagger);
        }

        return Task.FromResult<TextViewTagger<TextMarkerTag>>(tagger);
    }

    Task<TextViewTagger<CodeLensTag>> ITextViewTaggerProvider<CodeLensTag>.CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new MarkdownCodeLensTagger(this, textView.Document.Uri);
        lock (this.lockObject)
        {
            if (!this.codeLensTaggers.TryGetValue(textView.Document.Uri, out var taggers))
            {
                taggers = new();
                this.codeLensTaggers[textView.Document.Uri] = taggers;
            }

            taggers.Add(tagger);
        }

        return Task.FromResult<TextViewTagger<CodeLensTag>>(tagger);
    }

    internal void RemoveTextMarkerTagger(Uri documentUri, MarkdownTextMarkerTagger toBeRemoved)
    {
        lock (this.lockObject)
        {
            if (this.textMarkerTaggers.TryGetValue(documentUri, out var taggers))
            {
                taggers.Remove(toBeRemoved);
                if (taggers.Count == 0)
                {
                    this.textMarkerTaggers.Remove(documentUri);
                }
            }
        }
    }

    internal void RemoveCodeLensTagger(Uri documentUri, MarkdownCodeLensTagger toBeRemoved)
    {
        lock (this.lockObject)
        {
            if (this.codeLensTaggers.TryGetValue(documentUri, out var taggers))
            {
                taggers.Remove(toBeRemoved);
                if (taggers.Count == 0)
                {
                    this.codeLensTaggers.Remove(documentUri);
                }
            }
        }
    }
}
