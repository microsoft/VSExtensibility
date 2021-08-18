---
title: Editor reference
description: A reference for editor-based extensions
date: 2021-8-16
---

# Editor Extensions

The Visual Studio editor supports extensions that add to its capabilities. For the initial release of the new
Visual Studio extensibility model, only the following capabilities are supported:

- Listening for text views being opened and closed.
- Listening for text view (editor) state changes.
- Reading the text of the document and the caret locations.
- Performing text edits.

## Editor Extensibility Entrypoints

Editor extensibility currently supports 3 entry points: listeners, the EditorExtensibility service object, and
commands.

### Adding a Listener

There are two types of listeners, ITextViewChangedListener, and ITextViewLifetimeListener.
Together, these listeners can be used to observe the open, close, and modification of text editors.

To get started:

* Add a reference to the [Microsoft.VisualStudio.Extensibility.Editor](https://www.nuget.org/TODO-add-real-link)
and [Microsoft.VisualStudio.Extensibility.Build](https://www.nuget.org/TODO-add-real-link) NuGet packages to your
project.
* Change your project's `TargetFramework` from `net6.0` to `net6.0-windows`.

Then, create a new class, implementing `ExtensionPart` base class and `ITextViewChangedListener`,
`ITextViewLifetimeListener`, or both. Then, add an `[ExtensionPart(typeof(ITextViewChangedListener))]` attribute for
each listener interface you implemented and an `[AppliesTo(ContentType = "CSharp")]` attribute to your class.
ExtensionPart indicates to Visual Studio that this class can be instantiated by interested IDE services, and triggers
registration of the part in your extension's manifest.

Assuming you decide to implement both listeners, the finished class declaration should look like the following:

```csharp
  [ExtensionPart(typeof(ITextViewLifetimeListener))]
  [ExtensionPart(typeof(ITextViewChangedListener))]
  [AppliesTo(ContentType = "CSharp")]
  public sealed class TextViewOperationListener : ExtensionPart, ITextViewLifetimeListener, ITextViewChangedListener
  {
        ...
  }
```

When you run your extension, you should see:

- ITextViewLifetimeListener.TextViewCreatedAsync() called anytime an editor is opened by the user.
- ITextViewLifetimeListener.TextViewClosedAsync() called anytime an editor is closed by the user.
- ITextViewChangedListener.TextViewChangedAsync() called anytime a user makes a text change in the editor.

Each of these methods are passed an ITextView containing the state of the text editor at the time the
user invoked the action and a CancellationToken that will have `IsCancellationRequested == true` when
the IDE wishes to cancel a pending action.

#### AppliesTo Attribute

AppliesTo attribute indicates the programming language scenarios in which the extension should activate. It is written as
`[AppliesTo(ContentType = "CSharp")]`, where ContentType is a well known name of a language built into Visual Studio,
or custom defined in a Visual Studio extension.

Note that registering custom content types is not yet supported in the
new extensibility model.

**Some Well Known Content Types**:
- "CSharp" - C#
- "C/C++" - C, C++, headers, and IDL
- "TypeScript" - TypeScript and JavaScript type languages.
- "HTML" - HTML
- "JSON" - JSON
- "text" - text files, including hierarchical descendents of "code", which descends from "text".
- "code" - C, C++, C#, etc.

ContentTypes are hierarchical. e.g.: C# and C++ both descend from "code", so declaring "code" will cause your extension
to activate for C#, C, C++, etc.

### EditorExtensibility

Visual Studio ExtensionParts all expose a `this.Extensibility` property. Using this property, you can
request an instance of the EditorExtensibility object, which exposes on demand editor functionality, such as
performing text edits.

```csharp
EditorExtensibility editorService = this.Extensibility.Editor();
```

### Getting an ITextView within a Command

`ExecuteCommandAsync()` in each Command is passed an IClientContext that contains a snapshot of the state of the IDE
at the time the command was invoked. You can access the active ITextView from this using EditorExtensibility.

```csharp
using ITextView textView = await this.Extensibility.Editor().GetActiveTextViewAsync(clientContext, cancellationToken);
```

## Object Model

The Visual Studio Editor extensibility object model is composed of a few integral parts.

### ITextView
ITextView contains the URI and version information necessary to acquire an ITextDocument as well
as some properties of the text view, such as selections.

- This object is immutable and will never change after it is created.
- You can use `ITextView.GetTextDocumentAsync()` to get the content from the document. Note that calling this method is
  expensive and only should be done if you need the document content.
- ITextView cannot be changed directly. All changes are requested via Mutation. See Mutation Section below.

### ITextDocument
ITextDocument contains the content of the text document from a point in time or version.

- This object is immutable and will never change after it is created.
- ITextDocument cannot be changed directly. All changes are requested via Mutation. See Mutation Section below.

If you are familiar with legacy Visual Studio extensions, ITextDocument is almost 1:1 with
[ITextSnapshot](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.itextsnapshot?view=visualstudiosdk-2019)
and supports most of the same methods for accessing the text.

Best Practices:
- Avoid calling `.GetText()`.
  - You can use Position and Span to represent substrings in the document without expending resources copying or allocating strings. Most APIs will operate in terms of these primitives.
  - You can use the indexer syntax, `textDocument[0]`, to read character by character in the document without copying it to a string.
  - If you must create a string such as for use as a dictionary key, use the overload that takes a Span, to avoid creating a large throwaway string from the entire line or document.
- Avoid assuming lines or documents will be short. Many languages minify into huge lines or consume very large files.
- ITextDocument references large data structures that may consume memory if an old enough version is stored. Best practice is to periodically update Positions and Spans that you are storing long term to the latest document version via their `TranslateTo()` method so the old ITextDocument version can be garbage collected.

### Position
Represents a position within the text document. As opposed to `int` positions, the Position type
is aware of the ITextDocument it came from and supports `GetChar()` to directly get the character at that point.

If you are familiar with legacy Visual Studio extensions, Position is almost 1:1 with
[SnapshotPoint](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.snapshotpoint?view=visualstudiosdk-2019)
and supports most of the same methods.


### Span
Represents a contiguous substring of characters within an ITextDocument. As opposed to a string created with
`string.Substring()` or `ITextDocument.GetText()`, creating a span doesn't require any allocations or additional
memory. You can later call `Span.GetText()` to realize it into a string in a deferred fashion.

If you are familiar with legacy Visual Studio extensions, Position is almost 1:1 with
[SnapshotSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.snapshotSpan?view=visualstudiosdk-2019)
and supports most of the same methods.

## Mutation and Asynchronicity

### Mutation

In the new Visual Studio extensibility model, the extension is second class relative to the user: it cannot directly
modify the editor or the text document. All state changes are asynchronous and cooperative, with Visual Studio IDE performing
the requested change on the extension's behalf. The extension can request one or more changes on on a specific version of
the document or text view.

Mutations are requested using the `MutateAsync()` method on `EditorExtensibility`.

If you are familiar with legacy Visual Studio extensions, ITextDocumentMutator is almost 1:1 with the state changing
methods from
[ITextBuffer](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.itextbuffer?view=visualstudiosdk-2019)
and [ITextDocument](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.itextdocument?view=visualstudiosdk-2019)
and supports most of the same capabilities.

```csharp
MutationResult result = await this.Extensibility.Editor().MutateAsync(
m =>
{
    var mutator = m.GetMutator(document);
    mutator.Replace(textView.Selection.Extent, newGuidString);
},
cancellationToken);
```

To avoid misplaced edits, editor extension edits are applied like so:

- Extension requests an edit be made, based on its most recent version of the document.
- That request may contain one or more text edits, caret position changes, etc. Any type implementing `IMutatable`
  can be changed in a single `MutateAsync()` request, including ITextView and ITextDocument. Mutations
  are done by mutators, which can be requested on a specific class via `m.GetMutator()`.
- Mutation request is sent to Visual Studio IDE, where it succeeds only if the object being mutated hasn't changed
  since the version the request was made one. If the document has changed, the change may be rejected, requiring
  the extension to retry on newer version. Outcome of mutation operation is stored in `result`.
- Mutations are applied atomically. The best practice is to do all changes that should occur within a narrow time
  frame into a single MutateAsync() call, to reduce the likelihood of unexpected behavior arising from user edits,
  or language service actions that occur between mutations (e.g.: extension edits getting interleaved with Roslyn C#
  moving the caret).

### Asynchronicity

GetTextDocumentAsync() opens a copy of the text document in the Visual Studio extension. Since extensions run in a
separate process, all extension interactions are asynchronous, cooperative, and have some caveats:

- GetTextDocumentAsync() may fail if called on a really old ITextDocument because it may no longer be cached by the
  Visual Studio client, if the user has made many changes since it was created. For
  this reason, if you plan to store an ITextView to access its document later, and cannot tolerate failure, it may
  be a good idea to call GetTextDocumentAsync() immediately. Doing so fetches the text content for that version of
  the document into your extension, ensuring that a copy of that version is sent to your extension before it expires.
- GetTextDocumentAsync() or MutateAsync() may fail if the user closes the document.

![Document Open Diagram](DocumentOpenFlow.PNG)

### RPC Support

Since the new Visual Studio extensibility model is entirely in a separate process, all APIs have to at some
level operate with serializable data types. Typically, extensions can ignore these implementation details,
however, in some scenarios, an extension may need to interface directly with RPC services acquired from
`this.Extensibility.ServiceBroker`. To facilitate interactions with RPC services, the object model exposes
`RpcContract` properties on most core types, and the following serializable RPC types.

- VersionedTextDocumentRange - 1:1 serializable version of Span, accessible via `.RpcContract`. This type should be used in most RPC contracts between processes.
- VersionedTextDocumentPosition - 1:1 serializable version of Position, accessible via `.RpcContract`. This type should be used in most RPC contracts between processes.
- Range - Serializable version of Span, omitting the Uri and version number.
- Microsoft.VisualStudio.RpcContracts.Utilities.Position - Serializable version of Position, omitting the Uri and version number.
- TextView - 1:1 serialized form of ITextView, accessible via `.RpcContract`.
- TextDocument - 1:1 serialized form of ITextDocument via `.RpcContract`.

As opposed to VersionedTextDocumentRange and VersionedTextDocumentPosition, Range and Microsoft.VisualStudio.RpcContracts.Utilities.Position
omit the Uri and document version, making for a smaller serializable representation. This type should be used in RPC contracts that contain
lots of span/range equivalents that need to reduce their payload size for performance. These RPC contracts will need to pass the document
Uri and version for the spans/range to be rehydrated into Spans and Positions by the IEditorHostService.
IEditorHostService interfaces with extension-local copies of the text buffer, and manages opening and closing of
documents described by the RPC types.
