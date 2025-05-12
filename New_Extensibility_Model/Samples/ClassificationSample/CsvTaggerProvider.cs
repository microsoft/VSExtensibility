// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ClassificationSample;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

[VisualStudioContribution]
internal class CsvTaggerProvider : ExtensionPart, ITextViewTaggerProvider<ClassificationTag>, ITextViewChangedListener
{
    private readonly object lockObject = new();
    private readonly Dictionary<Uri, List<CsvTagger>> taggers = new();

    [VisualStudioContribution]
    public static DocumentTypeConfiguration CsvDocumentType => new("csv")
    {
        FileExtensions = new[] { ".csv" },
        BaseDocumentType = DocumentType.KnownValues.PlainText,
    };

    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(CsvDocumentType)],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        List<Task> tasks = new();
        lock (this.lockObject)
        {
            if (this.taggers.TryGetValue(args.AfterTextView.Uri, out var taggers))
            {
                foreach (var tagger in taggers)
                {
                    tasks.Add(tagger.TextViewChangedAsync(args.AfterTextView, args.Edits, cancellationToken));
                }
            }
        }

        await Task.WhenAll(tasks);
    }

    Task<TextViewTagger<ClassificationTag>> ITextViewTaggerProvider<ClassificationTag>.CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new CsvTagger(this, textView.Document.Uri);
        lock (this.lockObject)
        {
            if (!this.taggers.TryGetValue(textView.Document.Uri, out var taggers))
            {
                taggers = new();
                this.taggers[textView.Document.Uri] = taggers;
            }

            taggers.Add(tagger);
        }

        return Task.FromResult<TextViewTagger<ClassificationTag>>(tagger);
    }

    internal void RemoveTagger(Uri documentUri, CsvTagger toBeRemoved)
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
