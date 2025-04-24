// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace TaggersSample;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

// A tagger that highlights each section title in a markdown file
internal class MarkdownTextMarkerTagger : TextViewTagger<TextMarkerTag>
{
    private readonly MarkdownTextMarkerTaggerProvider provider;
    private readonly Uri documentUri;

    public MarkdownTextMarkerTagger(MarkdownTextMarkerTaggerProvider provider, Uri documentUri)
    {
        this.provider = provider;
        this.documentUri = documentUri;
    }

    public override void Dispose()
    {
        this.provider.RemoveTagger(this.documentUri, this);
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
            allRequestedRanges.Intersect(// Use Intersect to only create tags for ranges that VS has previously expressed interested in.
                edits.Select(e =>
                    EnsureNotEmpty(// Fix empty ranges to be at least 1 character long so that they are not ignored when intersected (empty ranges are the result of text deletion).
                        e.Range.TranslateTo(textView.Document, TextRangeTrackingMode.ExtendForwardAndBackward))))); // Translate the range to the new document version.
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
                // Convert the requested range to line numbers.
                var startLine = r.Document.GetLineNumberFromPosition(r.Start);
                var endLine = r.Document.GetLineNumberFromPosition(r.End);
                return Enumerable.Range(startLine, endLine - startLine + 1);

            // Use Distinct to avoid processing the same line multiple times.
            }).Distinct())
        {
            var line = document.Lines[lineNumber];
            if (line.Text.StartsWith("#"))
            {
                int len = line.Text.Length;
                if (len > 0)
                {
                    // VisualStudio.Extensibility doesn't support defining new TextMarker types yet, so we use
                    // the built-in FindHighlight TextMarker type.
                    tags.Add(new(
                        new(document, line.Text.Start, len, TextRangeTrackingMode.ExtendForwardAndBackward),
                        new("MarkerFormatDefinition/FindHighlight")));
                }
            }

            // Add the range to the list of ranges we have calculated tags for. We add the range even if no tags
            // were created for it, this takes care of clearing any tags that were previously created for this
            // range and are not valid anymore.
            ranges.Add(new(document, line.TextIncludingLineBreak.Start, line.TextIncludingLineBreak.Length));
        }

        // Return the ranges we have calculated tags for and the tags themselves.
        await this.UpdateTagsAsync(ranges, tags, CancellationToken.None);
    }
}
