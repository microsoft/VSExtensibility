---
title: Editor overview
description: An overview of the editor-based extensions for the Visual Studio IDE
date: 2021-8-20
---

# Editor extensions overview

The Visual Studio editor supports extensions that add to its capabilities. Examples include extensions that insert and modify code in an existing language.

For the initial release of the new Visual Studio extensibility model, only the following capabilities are supported:

- Listening for text views being opened and closed.
- Listening for text view (editor) state changes.
- Reading the text of the document and the caret locations.
- Performing text edits.

The Visual Studio editor generally refers to the functionality of editing text files, known as documents, of any type. Individual files may be opened for editing, and the open editor window is referred to as a `TextView`.

The editor object model is described at [Editor concepts](editor-concepts.md).

## Get started

Your extension code can be configured to run in response to various situations that a occur when a user interacts with Visual Studio. These are known as entry points. Editor extensibility currently supports three entry points: listeners, the [EditorExtensibility](#EditorExtensibility) service object, and commands.

Event listeners get triggered when certain actions occur in an editor window, represented in code by a `TextView`. For example, when a user types something into the editor, a `TextViewChanged` event occurs. When an editor window is opened or closed, `TextViewCreated` and `TextViewClosed` events occur.

The editor service object is an instance of the `EditorExtensibility` class, which exposes real-time editor functionality, such as performing text edits.

[Commands](commands.md) are initiated by the user by clicking on an item which you can place on a menu, context menu, or toolbar.

### Add a listener

There are two types of listeners, [ITextViewChangedListener](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener), and [ITextViewLifetimeListener](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener).
Together, these listeners can be used to observe the open, close, and modification of text editors.

Then, create a new class, implementing the [ExtensionPart](./../../api/Microsoft.VisualStudio.Extensibility.Framework.md#T-Microsoft-VisualStudio-Extensibility-ExtensionPart) base class and `ITextViewChangedListener`,
`ITextViewLifetimeListener`, or both. Then, add an `[ExtensionPart(typeof(ITextViewChangedListener))]` attribute for
each listener interface you implemented and an `[AppliesTo(DocumentType = "CSharp")]` attribute to your class to make the listener apply when editing C# files. The available document types for other programming languages and file types are listed [later in this article](#applies-to-attribute), and custom file types may also be defined when required.

Assuming you decide to implement both listeners, the finished class declaration should look like the following:

```csharp
  [ExtensionPart(typeof(ITextViewLifetimeListener))] // Indicates this part listens for text view lifetime events.
  [ExtensionPart(typeof(ITextViewChangedListener))]  // Indicates this part listens to text view changes.
  [AppliesTo(DocumentType = "CSharp")]                // Indicates this part should only light up in C# files.
  public sealed class TextViewOperationListener
      : ExtensionPart,           // This is the extension part base class containing infrastructure necessary to use VS services.
      ITextViewLifetimeListener,
      ITextViewChangedListener
  {
        ...
  }
```

When you run your extension, you should see:

- [ITextViewLifetimeListener.TextViewCreatedAsync()](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewCreatedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken-) called anytime an editor is opened by the user.
- [ITextViewLifetimeListener.TextViewClosedAsync()](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken-) called anytime an editor is closed by the user.
- [ITextViewChangedListener.TextViewChangedAsync()](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs,System-Threading-CancellationToken-) called anytime a user makes a text change in the editor.

Each of these methods are passed an [ITextViewSnapshot](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot) containing the state of the text editor at the time the user invoked the action and a CancellationToken that will have `IsCancellationRequested == true` when the IDE wishes to cancel a pending action.
the IDE wishes to cancel a pending action.

## Define when your extension is relevant

Your extension is typically relevant only to certain supported document types and scenarios, and so it is important to clearly define its applicability. The Visual Studio Extensibility model provides several ways to clearly define the applicability of an extension. These are various attributes which are known as document selectors: the [AppliesTo attribute](#appliesto-attribute), which helps specify what file types such as code languages the extension supports, and the [AppliesToPattern attribute](#appiestopattern-attribute), which lets you refine the applicability of an extension by further matching on a pattern based on the filename or path.

### Specify programming languages with the AppliesTo Attribute

The [AppliesTo](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute) attribute indicates the programming language scenarios in which the extension should activate. It is written as `[AppliesTo(DocumentType = "CSharp")]`, where DocumentType is a well known name of a language built into Visual Studio, or custom defined in a Visual Studio extension.

Some well-known document types are shown in the following table:

| DocumentType | Description |
| - | - |
| "CSharp" | C# |
| "C/C++" | C, C++, headers, and IDL |
| "TypeScript" | TypeScript and JavaScript type languages. |
| "HTML" | HTML |
| "JSON" | JSON |
| "text" | Text files, including hierarchical descendants of "code", which descends from "text". |
| "code" | C, C++, C#, and so on. |

DocumentTypes are hierarchical. That is, C# and C++ both descend from "code", so declaring "code" will cause your extension to activate for all code languages, C#, C, C++, and so on.

### Define a new document type

You can define a new document type, for example to support a custom code language, by adding certain assembly-level attributes.

[DocumentTypeDefinition](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinition), [DocumentTypeBaseDefinition](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinition) and [FileExtensionMapping](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMapping) attributes together allow you to define a new document type, specify that it inherits one or more other document types, and specify one or more file extensions that are used to identify the file type. These are assembly-level attributes that you add at the top level in your extension code:

```csharp
using Microsoft.VisualStudio.Extensibility.Editor;

[assembly: DocumentTypeDefinition("markdown")]
[assembly: DocumentTypeBaseDefinition("markdown", baseContentTypeName: "text")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".md")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".mdk")]
[assembly: FileExtensionMapping("markdown", fileExtension: ".markdown")]
```

Document type definitions are merged with content type definitions provided by legacy Visual Studio extensibility, which allows you to map additional file extensions to existing document types.

### Document selectors

In addition to [AppliesTo](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute) attribute, [AppliesToPattern](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPattern) attribute allows you to further limit applicability of the extension by making it activate only when document's file path matches a glob (wildcard) pattern:

```csharp
[AppliesTo(ContentType = "CSharp")]
[AppliesToPattern(Pattern = "**/tests/*.cs")]
```

```csharp
[AppliesTo(ContentType = "markdown")]
[AppliesToPattern(Pattern="docs/*.md", RelativePath=true)]
```

The `Pattern` property represents a glob pattern that is matched on the absolute path of the document.

Glob patterns can have the following syntax:

- `*` to match zero or more characters in a path segment
- `?` to match on one character in a path segment
- `**` to match any number of path segments, including none
- `{}` to group conditions (e.g. `**​/*.{ts,js}` matches all TypeScript and JavaScript files)
- `[]` to declare a range of characters to match in a path segment (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
- `[!...]` to negate a range of characters to match in a path segment (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but not `example.0`)

Note that a backslash (`\`) is not valid within a glob pattern. Make sure to convert any backslash to slash when creating the glob pattern.

## Access editor functionality

Your editor extension classes inherit from `ExtensionPart`. The `ExtensionPart` class exposes the [Extensibility](./../../api/Microsoft.VisualStudio.Extensibility.Framework.md#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Extensibility) property. Using this property, you can request an instance of the `EditorExtensibility` object. You can use this object to access real-time editor functionality, such as performing edits.

```csharp
EditorExtensibility editorService = this.Extensibility.Editor();
```

### Access editor state within a command

`ExecuteCommandAsync()` in each `Command` is passed an `IClientContext` that contains a snapshot of the state of the IDE at the time the command was invoked. You can access the active document via the `ITextViewSnapshot` interface, which you get by from the `EditorExtensibility` object by calling the asynchronous method `GetActiveTextViewAsync`:

```csharp
using ITextViewSnapshot textView = await this.Extensibility.Editor().GetActiveTextViewAsync(clientContext, cancellationToken);
```

Once you have `ITextViewSnapshot`, you can access editor state. `ITextViewSnapshot` is an immutable view of editor state at a point in time, so you'll need to use the other interfaces in the [Editor object model](editor-object-model.md) to make edits.

## Make changes in a text document from an extension

Edits, that is, changes to a text document open in the Visual Studio editor, may arise from user interactions, threads in Visual Studio such as language services and other extensions. Your extension must be prepared to deal with changes in the document text occurring in real time.

Extensions running outside the main Visual Studio IDE process that use asynchronous design patterns to communicate with the Visual Studio IDE process. This means the use of asynchronous method calls, as indicated by the `async` keyword in C# and reinforced by the `Async` suffix on method names. Asynchronicity is a significant advantage in the context of an editor that is expected to be responsive to user actions. A traditional synchronous API call, if it takes longer than expected, will stop responding to user input, creating a UI freeze that lasts until the API call completes. User expectations of modern interactive applications are that text editors always remain responsive, and never block them from working. Having extensions be asynchronous is therefore essential to meet user expectations.

Learn more about asynchronous programming at [Asynchronous programming with async and await](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/).

In the new Visual Studio extensibility model, the extension is second class relative to the user: it cannot directly
modify the editor or the text document. All state changes are asynchronous and cooperative, with Visual Studio IDE performing the requested change on the extension's behalf. The extension can request one or more changes on on a specific version of the document or text view, but changes from an extension may be rejected, such as if that area of the document has changed.

Edits are requested using the `EditAsync()` method on `EditorExtensibility`.

If you are familiar with legacy Visual Studio extensions, `ITextDocumentEditor` is almost the same as the state changing methods from [ITextBuffer](https://docs.microsoft.com/dotnet/api/microsoft.visualstudio.text.itextbuffer?view=visualstudiosdk-2019) and [ITextDocument](https://docs.microsoft.com/dotnet/api/microsoft.visualstudio.text.itextdocument?view=visualstudiosdk-2019) and supports most of the same capabilities.

```csharp
MutationResult result = await this.Extensibility.Editor().EditAsync(
batch =>
{
    var editor = document.AsEditable(batch);
    editor.Replace(textView.Selection.Extent, newGuidString);
},
cancellationToken);
```

To avoid misplaced edits, edits from editor extensions are applied as follows:

1. Extension requests an edit be made, based on its most recent version of the document.
1. That request may contain one or more text edits, caret position changes, and so on. Any type implementing `IEditable` can be changed in a single `EditAsync()` request, including `ITextViewSnapshot` and `ITextDocumentSnapshot`. Edits are done by editor, which can be requested on a specific class via `AsEditable()`.
1. Edit requests are sent to Visual Studio IDE, where it succeeds only if the object being mutated hasn't changed
  since the version the request was made one. If the document has changed, the change may be rejected, requiring
  the extension to retry on newer version. Outcome of mutation operation is stored in `result`.
1. Edits are applied atomically, meaning without interruption from other executing threads. The best practice is to do all changes that should occur within a narrow time frame into a single `EditAsync()` call, to reduce the likelihood of unexpected behavior arising from user edits, or language service actions that occur between edits (for example, extension edits getting interleaved with Roslyn C# moving the caret).

### Asynchronous execution

[ITextViewSnapshot.GetTextDocumentAsync()](./../../api/Microsoft.VisualStudio.Extensibility.Editor.md#gettextdocumentasync-method) opens a copy of the text document in the Visual Studio extension. Since extensions run in a separate process, all extension interactions are asynchronous, cooperative, and have some caveats:

- GetTextDocumentAsync() may fail if called on a really old `ITextDocument` because it may no longer be cached by the
  Visual Studio client, if the user has made many changes since it was created. For
  this reason, if you plan to store an ITextView to access its document later, and cannot tolerate failure, it may
  be a good idea to call GetTextDocumentAsync() immediately. Doing so fetches the text content for that version of
  the document into your extension, ensuring that a copy of that version is sent to your extension before it expires.
- GetTextDocumentAsync() or MutateAsync() may fail if the user closes the document.

#### Concurrent execution

:warning: | Editor extensions can sometimes run concurrently
:---: | :---

The initial release has a known issue that can result in concurrent execution of editor extension code. Each async method is guaranteed to be called in the correct order but continuations after the first `await` may be interleaved. If your extension relies on execution order, consider maintaining a queue of incoming requests to preserve the order, until this issue is fixed.

For more information, see [StreamJsonRpc Default Ordering and Concurrency](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/resiliency.md#default-ordering-and-concurrency-behavior).

## Next steps

Learn about the editor interfaces and types at [Editor concepts](editor-concepts.md).

Advanced users might wish to learn about the [Editor RPC support](editor-rpc.md).