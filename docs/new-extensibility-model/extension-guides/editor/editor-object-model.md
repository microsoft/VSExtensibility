---
title: Editor object model
description: An overview of the object model for editor-based extensions
date: 2022-12-1
---

# Editor object model

This article describes the extensibility object model that represents the Visual Studio editor and the text document that is opened for editing. For an introduction to working with the editor extension functionality, see [Editor extensions](editor.md).

The Visual Studio Editor extensibility object model is composed of a few integral parts. This article covers `ITextView`, `ITextDocument`, and other abstract representations of the whole document, as well as `Position` and `Span` which represent location and spans of text, respectively.

## ITextView

[ITextViewSnapshot](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot) contains the URI and version information necessary to acquire an [ITextDocumentSnapshot](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md##T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot) as well
as some properties of the text view, such as selections.

- This object is immutable and will never change after it is created.
- You can use `ITextViewSnapshot.GetTextDocumentAsync()` to get the content from the document. Note that calling this method is
  expensive and only should be done if you need the document content.
- `ITextView` cannot be changed directly. All changes are requested via mutation. See Mutation Section below.

## ITextDocument

[ITextDocumentSnapshot](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md##T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot) contains the content of the text document from a point in time or version.

- This object is immutable and will never change after it is created.
- `ITextDocument` cannot be changed directly. All changes are requested via mutation. See Mutation Section below.

If you are familiar with legacy Visual Studio extensions, `ITextDocument` is almost 1:1 with
[ITextSnapshot](https://docs.microsoft.com/dotnet/api/microsoft.visualstudio.text.itextsnapshot?view=visualstudiosdk-2019) and supports most of the same methods for accessing the text.

Best Practices:
  - Avoid calling [.CopyToString()](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot-CopyToString).
  - You can use Position and Span to represent substrings in the document without expending resources copying or allocating strings. Most APIs will operate in terms of these primitives.
  - You can use the indexer syntax, `textDocument[0]`, to read character by character in the document without copying it to a string.
  - If you must create a string such as for use as a dictionary key, use the overload that takes a Span, to avoid creating a large throwaway string from the entire line or document.
  - Avoid assuming lines or documents will be short. Many languages minify into huge lines or consume very large files.
  - `ITextDocument` references large data structures that may consume memory if an old enough version is stored. Best practice is to periodically update Positions and Spans that you are storing long term to the latest document version via their `TranslateTo()` method so the old `ITextDocument` version can be garbage collected.

## Position

Represents a position within the text document. As opposed to `int` positions, the [Position](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#position-type) type
is aware of the ITextDocument it came from and supports `GetChar()` to directly get the character at that point.

If you are familiar with legacy Visual Studio extensions, Position is almost the same as
[SnapshotPoint](https://docs.microsoft.com/dotnet/api/microsoft.visualstudio.text.snapshotpoint?view=visualstudiosdk-2019) and supports most of the same methods.

## Span

Represents a contiguous substring of characters within an `ITextDocument`. As opposed to a string created with
`string.Substring()` or `ITextDocumentSnapshot.CopyToString()`, creating a [Span](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#span-type) doesn't require any allocations or additional memory. You can later call `Span.GetText()` to realize it into a string in a deferred fashion.

If you are familiar with legacy Visual Studio extensions, `Position` is almost the same as
[SnapshotSpan](https://docs.microsoft.com/dotnet/api/microsoft.visualstudio.text.snapshotSpan?view=visualstudiosdk-2019) and supports most of the same methods.
