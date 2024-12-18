// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace TaggersSample;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Threading;

#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates.
#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

internal class MarkdownCodeLensTagger : TextViewTagger<CodeLensTag>
{
    public static readonly CodeElementKind SectionCodeElementKind = "Section";

    private readonly MarkdownCodeLensTaggerProvider provider;
    private readonly Uri documentUri;
    private readonly AsyncSemaphore semaphore = new(1);

    private ITextDocumentSnapshot? currentDocumentSnapshot;
    private bool needsUpdate;
    private bool updateRunning;

    public MarkdownCodeLensTagger(MarkdownCodeLensTaggerProvider provider, Uri documentUri)
    {
        this.provider = provider;
        this.documentUri = documentUri;
    }

    public override void Dispose()
    {
        this.provider.RemoveTagger(this.documentUri, this);
        this.semaphore.Dispose();
        base.Dispose();
    }

    public async Task TextViewChangedAsync(ITextViewSnapshot textView, IReadOnlyList<TextEdit> edits, CancellationToken cancellationToken)
    {
        if (edits.Count == 0)
        {
            return;
        }

        var documentBefore = edits[0].Range.Document;
        var documentAfter = textView.Document;

        using var semaphoreReleaser = await this.semaphore.EnterAsync();

        // Only queue a tags calculation if we haven't already queued it for a newer version of the document.
        if (this.currentDocumentSnapshot is null || this.currentDocumentSnapshot.RpcContract.Version < documentAfter.RpcContract.Version)
        {
            // If we already have a request to update the tags, let's just update the current document snapshot so that tags are calculated
            // with the latest version of the document.
            if (this.needsUpdate)
            {
                this.currentDocumentSnapshot = documentAfter;
                return;
            }

            // Only recalculate tags if a line starting with # was touched (added, removed, or modified).
            if (Lines(
                        documentBefore,
                        edits.Select(e => e.Range))
                    .Any(l => l.StartsWith("#")) ||
                Lines(
                        documentAfter,
                        edits.Select(e => e.Range.TranslateTo(documentAfter, TextRangeTrackingMode.EdgeInclusive)))
                    .Any(l => l.StartsWith("#")))
            {
                    this.currentDocumentSnapshot = documentAfter;
                    _ = this.RunCreateTagsAsync();
            }
        }
    }

    protected override async Task RequestTagsAsync(NormalizedTextRangeCollection requestedRanges, bool recalculateAll, CancellationToken cancellationToken)
    {
        if (requestedRanges.Count == 0 || requestedRanges.TextDocumentSnapshot is null)
        {
            return;
        }

        using var semaphoreReleaser = await this.semaphore.EnterAsync();

        // Only queue a tags calculation if we haven't already queued it for a newer version of the document. If we are asked to recalculate all, we always recalculate, but
        // we use the latest between the current snapshot and the requested snapshot.
        if (recalculateAll)
        {
            this.currentDocumentSnapshot =
                this.currentDocumentSnapshot is not null && this.currentDocumentSnapshot.RpcContract.Version >= requestedRanges.TextDocumentSnapshot.RpcContract.Version ?
                    this.currentDocumentSnapshot :
                    requestedRanges.TextDocumentSnapshot;
            _ = this.RunCreateTagsAsync();
        }
        else if (this.currentDocumentSnapshot is null || this.currentDocumentSnapshot.RpcContract.Version < requestedRanges.TextDocumentSnapshot.RpcContract.Version)
        {
            this.currentDocumentSnapshot = requestedRanges.TextDocumentSnapshot;
            _ = this.RunCreateTagsAsync();
        }
    }

    private static IEnumerable<TextRange> Lines(ITextDocumentSnapshot document, IEnumerable<TextRange> ranges)
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

    private async Task RunCreateTagsAsync()
    {
        // we are still under the semaphore here
        this.needsUpdate = true;

        // If we are already running the RunCreateTagsAsync loop, we don't need to start another one.
        if (this.updateRunning)
        {
            return;
        }

        this.updateRunning = true;
        while (true)
        {
            ITextDocumentSnapshot document;

            // On the first iteration, since the caller owns the semaphore, this will always yield.
            using (var semaphoreReleaser = await this.semaphore.EnterAsync())
            {
                if (!this.needsUpdate || this.currentDocumentSnapshot is null)
                {
                    this.updateRunning = false;
                    return;
                }

                this.needsUpdate = false;
                document = this.currentDocumentSnapshot;
            }

            // We don't hold the semaphore while running CreateTagsAsync, that allows new requests to run tag calculation to happen.
            await this.CreateTagsAsync(document);
        }
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

                tags.Add(new(new(document, line.Text.Start, line.Text.Length, TextRangeTrackingMode.EdgeInclusive), new(SectionCodeElementKind)
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
