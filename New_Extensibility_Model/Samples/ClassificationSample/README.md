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

This sample's `CsvTaggerProvider` and `CsvTagger` are equivalent to `MarkdownTextMarkerTaggerProvider` and `MarkdownTextMarkerTagger`.

## Classification

Classification can be performed by an extension by implementing an
`ITextViewTaggerProvider<ClassificationTag>` and have the `TextViewTagger<>`
generate `ClassificationTag` values.

```cs
tags.Add(
    new TaggedTrackingTextRange<ClassificationTag>(
        new TrackingTextRange(
            document,
            tagStartPosition,
            tagLength,
            TextRangeTrackingMode.ExtendNone),
        new ClassificationTag(ClassificationType.KnownValues.Operator)));

```

At this time, VisualStudio.Extensibility doesn't support defining text colors for
new classification types yet, so we must use existing classification types.

VSSDK-compatible extensions, can use [ClassificationTypeDefinition](https://learn.microsoft.com/dotnet/api/microsoft.visualstudio.text.classification.classificationtypedefinition)
to define new classification types. Their name can be referenced using
`ClassificationType.Custom`.

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
