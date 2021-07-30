# Editor Extensions

Most Visual Studio users will spend a majority of their time interacting with the code editor.
To enable more productive workflows, the editor supports extensions that add to its capabilities.
For the initial release of the new Visual Studio extensibility model, only the following capabilities
are supported:

- Listening for text views being opened and closed.
- Listening for text view (editor) state changes.
- Reading the text of the document and the caret locations.
- Performing text edits.

## Editor Extensibility Entrypoints

Editor extensibility currently supports 3 entry points: listeners, the EditorExtensibility service object, and
commands.

### Adding a Listener

The editor currently supports two types of listeners, ITextViewChangedListener, and ITextViewLifetimeListener.
Together, these listeners can be used to observe the open, close, and modification of text editors.

To get started:

* Add a reference to the [Microsoft.VisualStudio.Extensibility.Editor](https://www.nuget.org/TODO-add-real-link)
and [Microsoft.VisualStudio.Extensibility.Build](https://www.nuget.org/TODO-add-real-link) NuGet packages to your
project.
* Change your project's `TargetFramework` from `net6.0` to `net6.0-windows`.

#### Registering a listener

To add a listener, create a new class, implementing `ExtensionPart` base class and `ITextViewChangedListener`,
`ITextViewLifetimeListener`, or both. Then, add an `[ExtensionPart(typeof(ITextViewChangedListener))]` and
`[AppliesTo(ContentType = "CSharp")]` attribute to your class. ExtensionPart indicates to Visual Studio that
this class can be instantiated by interested IDE services, and triggers registration of the part in your
extension's manifest.

Assuming you decide to implement both listeners, the finished class declaration should look like:

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

AppliesTo attribute indicates the scenarios in which the extension should activate. It is written as
`[AppliesTo(ContentType = "CSharp")]`, where ContentType is a well known name of a language built into Visual Studio,
or one custom defined by a legacy Visual Studio extension.

ContentTypes are hierarchical. e.g.: C# and C++ both descend from "code", so declaring "code" will cause your extension
to activate for C#, C, C++, etc.

**Some Well Known Content Types**:
- "CSharp" - C#
- "C/C++" - C, C++, headers, and IDL
- "TypeScript" - TypeScript and JavaScript type languages.
- "HTML" - HTML
- "JSON" - JSON
- "text" - text files, including hierarchical descendents of "code", which descends from "text".
- "code" - C, C++, C#, etc.

### EditorExtensibility

Visual Studio Extensibility points all expose a `this.Extensibility` property. Using this property, you can
request an instance of the EditorExtensibility object, which exposes on demand editor functionality, such as
performing text edits.

```csharp
EditorExtensibility editorService = this.Extensibility.Editor();
```

### Getting an ITextView within a Command

`ExecuteCommandAsync()` is passed an IClientContext that contains a snapshot of the state of the IDE
at the time the command was invoked. You can access the active ITextView from this using EditorExtensibility.

```csharp
using ITextView textView = await this.Extensibility.Editor().GetActiveTextViewAsync(clientContext, cancellationToken);
```

## Object Model

The Visual Studio Editor extensibility object model is composed of a few integral parts:

### ITextView
ITextView contains the URI and version information necessary to acquire an ITextDocument as well
as some properties of the text view, such as selections.

- This object is immutable and will never change after it is created.
- You can use `ITextView.GetTextDocumentAsync()` to get the content from the document.
- ITextView cannot be changed directly. All changes are requested via Mutation. See Mutation Section below.

### ITextDocument
ITextDocument contains the content of the text document from a point in time or version.

- This object is immutable and will never change after it is created.
- ITextDocument cannot be changed directly. All changes are requested via Mutation. See Mutation Section below.

If you are familiar with legacy Visual Studio extensions, ITextDocument is an almost 1:1 with
[ITextSnapshot](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.itextsnapshot?view=visualstudiosdk-2019)
and supports most of the same methods for accessing the text.

Best Practices:
- Avoid calling `.GetText()`.
  - You can use Position and Span to represent substrings in the document without allocating memory.
  - You can use the indexer syntax, `textDocument[0] == 'h'`, to read character by character in the document without copying it to a string.
  - If you must create a string, such as, for use as a dictionary key, use the overload that takes a Span(), to avoid creating a large throwaway string from the entire line or buffer.
- Avoid assuming lines or documents will be short. Many languages minify into huge lines or consume very large files.

### Position
Represents a position within the text document. As opposed to `int` positions, the Position type
is aware of the ITextDocument it came from and supports `GetChar()` to directly get the character at that point.

If you are familiar with legacy Visual Studio extensions, Position is an almost 1:1 with
[SnapshotPoint](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.snapshotpoint?view=visualstudiosdk-2019)
and supports most of the same methods for accessing the text.


### Span
Represents a contiguous substring of characters within an ITextDocument. As opposed to a string created with
`string.Substring()` or `ITextDocument.GetText()`, creating a span doesn't require any allocations or additional
memory. You can later call `Span.GetText()` to realize it into a string in a deferred fashion.

If you are familiar with legacy Visual Studio extensions, Position is an almost 1:1 with
[SnapshotSpan](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.text.snapshotSpan?view=visualstudiosdk-2019)
and supports most of the same methods for accessing the text.

## Mutation and Asynchronicity

GetTextDocumentAsync() opens a copy of the text document in the Visual Studio extension. Since extensions run in a
separate process, all extension interactions are asynchronous, cooperative, and have some caveats:

- GetTextDocumentAsync() or MutateAsync() may fail if called on a really old ITextView or ITextDocument on a version
  that is no longer cached by the Visual Studio client, if the user has made many changes since it was created. For
  this reason, if you plan to store an ITextView to access its document later, it is a good idea to call
  GetTextDocumentAsync() immediately. Doing so subscribes your extension's representation of the document, ensuring
  that it gets the old content before it expires.
- GetTextDocumentAsync() or MutateAsync() may fail if the users closes the document.

### Mutation

Since extensions run in a separate process, all extension interactions are asynchronous. In the case of text edits
requested by an extension, they are requested on a specific version of the document present in the extension, which
may be a few versions behind what the user sees in Visual Studio IDE process, if the user has made edits since.

To avoid misplaced edits, editor extension edits are applied like so:

- Extension requests an edit be made, based on its version of the document at that point in time.
- That request may contain one or more text edits, caret position changes, etc. Any type implementing `IMutatable`
  can be changed in a single `MutateAsync()` request, including ITextView and ITextDocument.
- 
