// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace TaggersSample;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

[VisualStudioContribution]
internal class MarkdownCodeLensTaggerProvider : ExtensionPart, ITextViewTaggerProvider<CodeLensTag>, ITextViewChangedListener
{
    private readonly object lockObject = new();
    private readonly Dictionary<Uri, List<MarkdownCodeLensTagger>> taggers = new();

    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        List<Task> tasks = new();
        lock (this.lockObject)
        {
            if (this.taggers.TryGetValue(args.AfterTextView.Uri, out var textMarkerTaggers))
            {
                foreach (var textMarkerTagger in textMarkerTaggers)
                {
                    tasks.Add(textMarkerTagger.TextViewChangedAsync(args.AfterTextView, args.Edits, cancellationToken));
                }
            }
        }

        await Task.WhenAll(tasks);
    }

    public Task<TextViewTagger<CodeLensTag>> CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new MarkdownCodeLensTagger(this, textView.Document.Uri);
        lock (this.lockObject)
        {
            if (!this.taggers.TryGetValue(textView.Document.Uri, out var taggers))
            {
                taggers = new();
                this.taggers[textView.Document.Uri] = taggers;
            }

            taggers.Add(tagger);
        }

        return Task.FromResult<TextViewTagger<CodeLensTag>>(tagger);
    }

    internal void RemoveTagger(Uri documentUri, MarkdownCodeLensTagger toBeRemoved)
    {
        lock (this.lockObject)
        {
            if (this.taggers.TryGetValue(documentUri, out var taggers))
            {
                taggers.Remove(toBeRemoved);
                if (taggers.Count == 0)
                {
                    this.taggers.Remove(documentUri);
                }
            }
        }
    }
}
