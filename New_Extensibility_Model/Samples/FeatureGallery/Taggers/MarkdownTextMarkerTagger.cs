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
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

internal class MarkdownTextMarkerTagger : TextViewTagger<TextMarkerTag>
{
    [VisualStudioContribution]
    private static TextMarkerStyleConfiguration HeaderStyle { get; } = new(
#if INPROC
        "MarkerFormatDefinition/InProcFeatureGallery.MarkdownHeader",
        "%InProcFeatureGallery.MarkdownTextMarkerTagger.HeaderStyle.DisplayName%")
#else
        "MarkerFormatDefinition/FeatureGallery.MarkdownHeader",
        "%FeatureGallery.MarkdownTextMarkerTagger.HeaderStyle.DisplayName%")
#endif
    {
        BorderDashStyle = PenDashStyle.Dash,
        BorderThickness = 2,
        ThemedColors = new()
        {
            [Theme.KnownValues.Light] = new(
                BackgroundColor: UIColor.KnownColors.LightSeaGreen,
                BorderColor: 0xFFFF0000),
            [Theme.KnownValues.Dark] = new(
                BackgroundColor: UIColor.KnownColors.Teal,
                BorderColor: UIColor.Rgb(r: byte.MaxValue, 0, 0)),
            [Theme.KnownValues.HighContrast] = new(
                BackgroundColor: UIColor.SysColors.COLOR_HIGHLIGHT,
                BorderColor: UIColor.SysColors.COLOR_HIGHLIGHTTEXT),
        },
    };

    protected override async Task OnTextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        if (args.Edits.Count == 0)
        {
            return;
        }

        var allRequestedRanges = await this.GetAllRequestedRangesAsync(args.AfterTextView.Document, cancellationToken);
        await this.CreateTagsAsync(
            args.AfterTextView.Document,
            allRequestedRanges.Intersect(// Use Intersect to only create tags for ranges that VS has previously expressed interested in.
                args.Edits.Select(e =>
                    EnsureNotEmpty(// Fix empty ranges to be at least 1 character long so that they are not ignored when intersected (empty ranges are the result of text deletion).
                        e.RangeAfterEdit)))); // Translate the range to the new document version.
    }

    protected override Task OnRequestTagsAsync(NormalizedTextRangeCollection requestedRanges, bool recalculateAll, CancellationToken cancellationToken)
    {
        if (requestedRanges.Count == 0)
        {
            return Task.CompletedTask;
        }

        return this.CreateTagsAsync(requestedRanges.TextDocumentSnapshot!, requestedRanges);
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
                        new(HeaderStyle)));
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
