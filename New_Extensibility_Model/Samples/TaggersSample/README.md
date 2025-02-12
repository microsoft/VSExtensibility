---
title: Taggers Extension Sample reference
description: A reference for Taggers sample
date: 2024-12-16
---

# Walkthrough: Taggers Extension Sample

This extension creates a tagger that highlights the title of sections in markdown files and a tagger
that provides CodeLens tags for the same titles.

## Tagger provider

A tagger provider is an extension part that provides taggers for a document:

```cs
[VisualStudioContribution]
internal class MarkdownTextMarkerTaggerProvider : ExtensionPart, ITextViewTaggerProvider<TextMarkerTag>
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };

    public Task<TextViewTagger<TextMarkerTag>> CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new MarkdownTextMarkerTagger(this, textView.Document.Uri);
        return Task.FromResult<TextViewTagger<TextMarkerTag>>(tagger);
    }
}
```

The `VisualStudioContribution` attribute makes the tagger provider available to Visual Studio.
The `TextViewExtensionConfiguration` property specifies to which files the tagger provider
applies to. The `CreateTaggerAsync` method creates a tagger for the provided text view.

A tagger provider generally also implement `ITextViewChangedListener` to be notified when the
a text view changes. Such notifications are then forwarded to the corresponding tagger. This
requires keeping a reference to all active taggers and to which text view they belong to.
See [MarkdownTextMarkerTaggerProvider.cs](./MarkdownTextMarkerTaggerProvider.cs) for the full implementation.

## Tagger

The tagger, [MarkdownTextMarkerTagger](./MarkdownTextMarkerTagger.cs), reacts to requests for
tags (`RequestTagsAsync`) and to changes in the document (`TextViewChangedAsync`). When either
of these methods is called, the tagger creates tags for the relevant ranges in the document and
returns them by calling `UpdateTagsAsync`.

In this case, the tagger is fairly quick to compute tags because it can just look for lines that
have been modified or requested tags for. If a line starts with a `#` character, then a tag
should be created for that line. A tagger that can work on small subsets of the document is much
easier to implement since it can provide quick updates for every request (`RequestTagsAsync` and
`TextViewChangedAsync`) without needing complex synchronization logic.

### Handling text view changes

While tags are generated using the same code for both `RequestTagsAsync` and `TextViewChangedAsync`,
handling text view changes requires a some additional locic:

- All edited ranges must be translated to the current snapshot.
- When the user deletes text, this results in an empty range for the current snapshot (E.g. `"deleted text" => ""`). We need to fix those ranges to be at least 1 character long to avoid them being ignored in the next step.
- Intersect the edited ranges with the ranges that tags were previously requested. For example, if the user pastes a large portion of text, Visual Studio may not request tags for the portion that falls outside of the visible area.

```cs
public async Task TextViewChangedAsync(ITextViewSnapshot textView, IReadOnlyList<TextEdit> edits, CancellationToken cancellationToken)
{
    var allRequestedRanges = await this.GetAllRequestedRangesAsync(textView.Document, cancellationToken);
    await this.CreateTagsAsync(
        textView.Document,
        allRequestedRanges.Intersect(
            edits.Select(e =>
                EnsureNotEmpty(
                    e.Range.TranslateTo(textView.Document, TextRangeTrackingMode.EdgeInclusive)))));
}
```

### Creating tags

The `CreateTagsAsync` method is responsible for creating tags for the given ranges.

The way ranges that are received from `RequestTagsAsync` and `TextViewChangedAsync` are generally not
aligned with the syntax of the document. For example, a range may start in the middle of a word. For
better consistency, a tagger should break up the document into meaningful sections and create tags
for them.

Because identifying markdown section titles can be done line by line, `CreateTagsAsync` converts the
requested ranges into new ranges that are aligned with the lines of the document. It then creates tags
for each line.

Tags are returned by calling `UpdateTagsAsync`:

```cs
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
        }).Distinct()) // Use Distinct to avoid processing the same line multiple times.
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
                    new(document, line.Text.Start, len, TextRangeTrackingMode.EdgeInclusive),
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
```

## Implementing "slow" taggers

Certain taggers may need to peform more complex operations to compute tags. Such complex operations may
not be reliably executed for each edit or `RequestTagsAsync` call.

For example, the [MarkdownCodeLensTaggerProvider](MarkdownCodeLensTaggerProvider.cs) is used to add a
CodeLens showing the ID for each section in a markdown file. Such tags cannot be evaluated line-by-line
because the ID of a section may depend on the IDs of previous sections.

`MarkdownCodeLensTaggerProvider` addresses this by always recalculating tags for the entire document each
time. A full recalculation of all tags can be slow for large documents, so it cannot be done for every
edit or `RequestTagsAsync` call. Instead it synchronizes tags evaluations so that only one is ever running
at a time and always on the latest snapshot. It also avoids queueing a new evaluation if edits didn't
affect lines with section titles.

This may result in a longer delay before tags are updated compared to a simpler tagger, like
`MarkdownTextMarkerTagger`, which can reliably operate on every single edit and `RequestTagsAsync` call.