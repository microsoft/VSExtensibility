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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.Editor;

internal class CsvTagger : TextViewTagger<ClassificationTag>
{
    private const string QuoteMatchName = "quote";
    private const string EscapedQuoteMatchName = "escapedQuote";
    private const string SeparatorMatchName = "separator";
    private const string FieldTextMatchName = "fieldText";

    // Matches any sequence of characters, not containing '"' and ','. It also matches any
    // sequence of characters enclosed in '"' as long as they don't contain other '"'
    // characters, unless they are escaped (doubled).
    // Examples of valid matches: xxx, "xxx", "xx""x"
    private const string FieldRegex = $@"(((?<{QuoteMatchName}>"")((?<{FieldTextMatchName}>[^""]+)|(?<{EscapedQuoteMatchName}>""""))*(?<{QuoteMatchName}>""))|(?<{FieldTextMatchName}>([^,""])*))";

    // Matches multiple fields separated by ','
    // This regex supports quoted fields, escaped quotes (inside fields). We are not supporting
    // line-breaks inside a field.
    // This regex is not terminated with '$' so that as much as possible of the beginning of
    // the line is always matched, even in case of syntax error.
    private static readonly Regex LineRegex = new($@"^{FieldRegex}((?<{SeparatorMatchName}>,){FieldRegex})*", RegexOptions.Compiled | RegexOptions.ExplicitCapture);

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
                        e.RangeAfterEdit))));
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
        List<TaggedTrackingTextRange<ClassificationTag>> tags = new();
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
            var match = LineRegex.Match(line.Text.CopyToString());

            if (match.Success)
            {
                // VisualStudio.Extensibility doesn't support defining text colors for
                // new classification types yet, so we must use existing classification
                // types.
                foreach (Capture capture in match.Groups[FieldTextMatchName].Captures)
                {
                    AddTag(capture, lineNumber == 0 ? Classifications.Header : ClassificationType.KnownValues.String);
                }

                foreach (Capture capture in match.Groups[QuoteMatchName].Captures)
                {
                    AddTag(capture, Classifications.Quote);
                }

                foreach (Capture capture in match.Groups[EscapedQuoteMatchName].Captures)
                {
                    AddTag(capture, Classifications.EscapedQuote);
                }

                foreach (Capture capture in match.Groups[SeparatorMatchName].Captures)
                {
                    AddTag(capture, Classifications.Separator);
                }
            }

            void AddTag(Capture capture, ClassificationType classificationType)
            {
                tags.Add(new(new(document, line.Text.Start + capture.Index, capture.Length, TextRangeTrackingMode.ExtendNone), new(classificationType)));
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
