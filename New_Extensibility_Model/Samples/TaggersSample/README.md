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

```csharp
[VisualStudioContribution]
internal class MarkdownTextMarkerTaggerProvider : TextViewTaggerProvider<TextMarkerTag, MarkdownTextMarkerTagger>
{
    public override TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };
}
```

The `VisualStudioContribution` attribute makes the tagger provider available to Visual Studio.
The `TextViewExtensionConfiguration` property specifies to which files the tagger provider
applies. `TextViewTaggerProvider<TTag, TTagger>` creates the taggers and forwards text view
changes to them, so this sample does not need to maintain a registry of active taggers.
See [MarkdownTextMarkerTaggerProvider.cs](./MarkdownTextMarkerTaggerProvider.cs).

For other editor extensions that handle changes without producing tags, such as the
[WordCountMargin](../WordCountMargin/TextViewMarginProvider.cs), `TextViewChangesAggregator`
can combine successive edit notifications before updating the UI.

## Tagger

The tagger, [MarkdownTextMarkerTagger](./MarkdownTextMarkerTagger.cs), overrides
`OnRequestTagsAsync` and `OnTextViewChangedAsync` to handle requests for tags and changes
to the document. It sends updated tags for the relevant ranges through `UpdateTagsAsync`.

In this case, the tagger is fairly quick to compute tags because it can just look for lines that
have been modified or requested tags for. If a line starts with a `#` character, then a tag
should be created for that line. A tagger that can work on small subsets of the document is much
easier to implement since it can provide quick updates for every request (`OnRequestTagsAsync`
and `OnTextViewChangedAsync`) without needing complex synchronization logic.

### Handling text view changes

While tags are generated using the same code for both callbacks, handling text view changes
requires a few additional steps:

- Use each edit's `RangeAfterEdit`, which refers to the current snapshot.
- When the user deletes text, the resulting range can be empty. Expand it so that it is not ignored in the next step.
- Intersect the edited ranges with the ranges that tags were previously requested. For example, if the user pastes a large portion of text, Visual Studio may not request tags for the portion that falls outside of the visible area.

```csharp
protected override async Task OnTextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
{
    if (args.Edits.Count == 0)
    {
        return;
    }

    var allRequestedRanges = await this.GetAllRequestedRangesAsync(args.AfterTextView.Document, cancellationToken);
    await this.CreateTagsAsync(
        args.AfterTextView.Document,
        allRequestedRanges.Intersect(
            args.Edits.Select(e => EnsureNotEmpty(e.RangeAfterEdit))));
}
```

### Custom marker style

The sample contributes a `TextMarkerStyleConfiguration` for Markdown headings. The
`HeaderStyle` sets a dashed border and background and border colors for light, dark,
and high-contrast themes. Each tag refers to that style rather than to a built-in
marker type:

```csharp
[VisualStudioContribution]
private static TextMarkerStyleConfiguration HeaderStyle { get; } = new(
    "MarkerFormatDefinition/TaggersSample.MarkdownHeader",
    "%TaggersSample.MarkdownTextMarkerTagger.HeaderStyle.DisplayName%")
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
```

### Creating tags

The `CreateTagsAsync` method is responsible for creating tags for the given ranges.

The ranges received from `OnRequestTagsAsync` and `OnTextViewChangedAsync` are generally not
aligned with the syntax of the document. For example, a range may start in the middle of a word. For
better consistency, a tagger should break up the document into meaningful sections and create tags
for them.

Because identifying markdown section titles can be done line by line, `CreateTagsAsync` converts the
requested ranges into new ranges that are aligned with the lines of the document. It then creates tags
for each line.

Tags are returned by calling `UpdateTagsAsync`:

```csharp
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
                tags.Add(new(
                    new(document, line.Text.Start, len, TextRangeTrackingMode.ExtendForwardAndBackward),
                    new(HeaderStyle)));
            }
        }

        ranges.Add(new(document, line.TextIncludingLineBreak.Start, line.TextIncludingLineBreak.Length));
    }

    await this.UpdateTagsAsync(ranges, tags, CancellationToken.None);
}
```

## Implementing "slow" taggers

Certain taggers may need to perform more complex operations to compute tags.

For example, the [MarkdownCodeLensTaggerProvider](MarkdownCodeLensTaggerProvider.cs) is used to add a
CodeLens showing the ID for each section in a markdown file. Such tags cannot be evaluated line-by-line
because the ID of a section may depend on the IDs of previous sections.

`MarkdownCodeLensTagger` recalculates tags for the entire document when tags are requested.
On edits, it recalculates only if a line starting with `#` was touched before or after the
edit; other edits do not trigger a recalculation. Unlike the text marker tagger, it cannot
update a single modified line because section identifiers depend on preceding sections.

This may take longer than a simpler tagger like `MarkdownTextMarkerTagger`, which can update
only the edited and requested lines.