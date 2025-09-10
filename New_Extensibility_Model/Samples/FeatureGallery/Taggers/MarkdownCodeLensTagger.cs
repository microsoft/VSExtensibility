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

internal class MarkdownCodeLensTagger : TextViewTagger<CodeLensTag>
{
    public static readonly CodeElementKind SectionCodeElementKind = "Section";

    protected override Task OnTextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        if (args.Edits.Count == 0)
        {
            return Task.CompletedTask;
        }

        // Only recalculate tags if a line starting with # was touched (added, removed, or modified).
        if (GetLines(
                    args.BeforeTextView.Document,
                    args.Edits.Select(e => e.Range))
                .Any(l => l.StartsWith("#")) ||
            GetLines(
                    args.AfterTextView.Document,
                    args.Edits.Select(e => e.RangeAfterEdit))
                .Any(l => l.StartsWith("#")))
        {
            return this.CreateTagsAsync(args.AfterTextView.Document);
        }

        return Task.CompletedTask;
    }

    protected override Task OnRequestTagsAsync(NormalizedTextRangeCollection requestedRanges, bool recalculateAll, CancellationToken cancellationToken)
    {
        if (requestedRanges.Count == 0)
        {
            return Task.CompletedTask;
        }

        return this.CreateTagsAsync(requestedRanges.TextDocumentSnapshot!);
    }

    private static IEnumerable<TextRange> GetLines(ITextDocumentSnapshot document, IEnumerable<TextRange> ranges)
    {
        return ranges
            .SelectMany(r =>
            {
                var startLine = r.Document.GetLineNumberFromPosition(r.Start);
                var endLine = r.Document.GetLineNumberFromPosition(r.End);
                return Enumerable.Range(startLine, endLine - startLine + 1);
            })
            .Distinct()
            .Select(l => document.Lines[l].Text);
    }

    private async Task CreateTagsAsync(ITextDocumentSnapshot document)
    {
        Dictionary<string, int> sections = new();

        List<TaggedTrackingTextRange<CodeLensTag>> tags = new();
        foreach (var line in document!.Lines)
        {
            int level = line.Text.TakeWhile(c => c == '#').Count();
            if (level > 0 && level <= 6)
            {
                var description = line.Text.CopyToString().TrimStart('#').Trim();

                var identifier = new string(description
                    .Where(c => char.IsLetterOrDigit(c) || c == ' ')
                    .Select(c => c == ' ' ? '-' : char.ToLowerInvariant(c))
                    .ToArray());

                if (sections.TryGetValue(identifier, out var count))
                {
                    sections[identifier] = count + 1;
                    identifier = $"{identifier}-{count}";
                }
                else
                {
                    sections.Add(identifier, 1);
                }

                tags.Add(new(new(document, line.Text.Start, line.Text.Length, TextRangeTrackingMode.ExtendForwardAndBackward), new(SectionCodeElementKind)
                {
                    UniqueIdentifier = identifier,
                    Description = $"Level {level} section: {description}",
                    DisplayBeforeCreatingCodeLenses = true,
                    Properties = new()
                    {
                        ["Level"] = level.ToString(),
                        ["Title"] = description,
                    },
                }));
            }
        }

        await this.UpdateTagsAsync([new(document, 0, document.Length)], tags, CancellationToken.None);
    }
}
