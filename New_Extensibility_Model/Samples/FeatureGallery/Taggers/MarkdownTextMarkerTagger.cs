// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

internal class MarkdownTextMarkerTagger : TextViewTagger<TextMarkerTag>
{
    private readonly MarkdownTaggerProvider provider;
    private readonly Uri documentUri;

    public MarkdownTextMarkerTagger(MarkdownTaggerProvider provider, Uri documentUri)
    {
        this.provider = provider;
        this.documentUri = documentUri;
    }

    public override void Dispose()
    {
        this.provider.RemoveTextMarkerTagger(this.documentUri, this);
        base.Dispose();
    }

    public async Task TextViewChangedAsync(ITextViewSnapshot textView, IReadOnlyList<TextEdit> edits, CancellationToken cancellationToken)
    {
        if (edits.Count == 0)
        {
            return;
        }

        var allRequestedRanges = await this.GetAllRequestedRangesAsync(textView.Document, cancellationToken);
        await this.CreateTagsAsync(
            textView.Document,
            allRequestedRanges
                .Intersect(edits.Select(e => EnsureNotEmpty(e.Range.TranslateTo(textView.Document, TextRangeTrackingMode.EdgeInclusive)))));
    }

    protected override async Task RequestTagsAsync(NormalizedTextRangeCollection requestedRanges, bool recalculateAll, CancellationToken cancellationToken)
    {
        if (requestedRanges.Count == 0)
        {
            return;
        }

        await this.CreateTagsAsync(requestedRanges.TextDocumentSnapshot!, requestedRanges);
    }

    private static TextRange EnsureNotEmpty(TextRange range)
    {
        if (range.Length > 0)
        {
            return range;
        }

        int start = Math.Max(0, range.Start - 1);
        int end = Math.Min(range.Document.Length, range.Start + 1);

        return new(range.Document, start, end - start);
    }

    private async Task CreateTagsAsync(ITextDocumentSnapshot document, IEnumerable<TextRange> requestedRanges)
    {
        List<TaggedTrackingTextRange<TextMarkerTag>> tags = new();
        List<TextRange> ranges = new();
        foreach (var lineNumber in requestedRanges.SelectMany(r =>
            {
                var startLine = r.Document.GetLineNumberFromPosition(r.Start);
                var endLine = r.Document.GetLineNumberFromPosition(r.End);
                return Enumerable.Range(startLine, endLine - startLine + 1);
            }).Distinct())
        {
            var line = document.Lines[lineNumber];
            if (line.Text.StartsWith("#"))
            {
                int len = line.Text.Length;
                if (len > 0)
                {
                    tags.Add(new(new(document, line.Text.Start, len, TextRangeTrackingMode.EdgeInclusive), new("MarkerFormatDefinition/FindHighlight")));
                }
            }

            ranges.Add(new(document, line.TextIncludingLineBreak.Start, line.TextIncludingLineBreak.Length));
        }

        await this.UpdateTagsAsync(ranges, tags, CancellationToken.None);
    }
}
