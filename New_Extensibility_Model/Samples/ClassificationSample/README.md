---
title: Classification Extension Sample reference
description: A reference for Classification sample
date: 2025-04-22
---

# Classification Extension Sample

This extension creates a tagger that classifies the text of CSV files.

A detailed walkthrough of how to create a tagger is available in the
[Taggers sample readme file](../TaggersSample/README.md). Please read
that first.

Like the Markdown tagger in that sample, `CsvTaggerProvider` uses
`TextViewTaggerProvider<ClassificationTag, CsvTagger>` to provide tags for matching documents.

## Classification

The [Classifications](./Classifications.cs) file contributes four custom classification
types: `Header`, `Separator`, `Quote`, and `EscapedQuote`. Each has a parent built-in
classification and a style with colors for light, dark, and high-contrast themes.
For example, the separator inherits from the built-in operator classification:

```csharp
[VisualStudioContribution]
public static ClassificationTypeConfiguration Separator { get; } = new(
    "ClassificationType/ClassificationSample.Separator")
{
    ParentClassifications = [ClassificationType.KnownValues.Operator],
    Style = new("%ClassificationSample.Classifications.Separator.DisplayName%")
    {
        ThemedColors = new()
        {
            [Theme.KnownValues.Light] = new(UIColor.KnownColors.Black),
            [Theme.KnownValues.Dark] = new(UIColor.KnownColors.White),
            [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
        },
    },
};
```

The [CSV tagger](./CsvTagger.cs) creates `ClassificationTag` values using these
configurations. It uses `Header` for field text on the first line and the built-in
`ClassificationType.KnownValues.String` for field text on subsequent lines. Quotes,
escaped quotes, and separators use their respective custom classifications:

```csharp
foreach (Capture capture in match.Groups[SeparatorMatchName].Captures)
{
    AddTag(capture, Classifications.Separator);
}

void AddTag(Capture capture, ClassificationType classificationType)
{
    tags.Add(new(new(document, line.Text.Start + capture.Index, capture.Length, TextRangeTrackingMode.ExtendNone), new(classificationType)));
}
```

## Performance considerations

Since `CsvTagger` doesn't support CSV fields containing line breaks, the
tagger can perform parsing of any single line of the CSV file independently
from each other. This allows the tagger to only act on the modified lines.

We further optimize the tag generation by intersecting the edited text ranges
with the ranges that have been previously requested (`GetAllRequestedRangesAsync`).
This is particularly useful if the user pastes a large amount of text into
the file resulting in lines being edited that don't fall into the currently
visible portion of the view.

 If these optimization were not possible, we would have to avoid generating tags
 on each edit of the document (see the [Implementing "slow" taggers](../TaggersSample/README.md#implementing-slow-taggers) chapter of the Taggers sample readme file).
