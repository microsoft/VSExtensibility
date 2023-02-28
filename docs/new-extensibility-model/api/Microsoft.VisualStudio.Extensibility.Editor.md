<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Editor

## Contents

- [EditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-EditBatch 'Microsoft.VisualStudio.Extensibility.Editor.EditBatch')
- [EditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-EditResponse 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse')
  - [#ctor(succeeded,message,documentEditResults,textViewEditResults)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse}- 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse.#ctor(System.Boolean,System.String,System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse},System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse})')
  - [DocumentEditResults](#P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-DocumentEditResults 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse.DocumentEditResults')
  - [Message](#P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-Message 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse.Message')
  - [Succeeded](#P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-Succeeded 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse.Succeeded')
  - [TextViewEditResults](#P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-TextViewEditResults 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse.TextViewEditResults')
- [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility')
  - [#ctor(extensibility,editorHostService)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService)')
  - [EditAsync(editorSource,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch},System.Threading.CancellationToken)')
  - [GetActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.GetActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.IClientContext,System.Threading.CancellationToken)')
- [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewChangedListener')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewChangedListener.TextViewChangedAsync(Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs,System.Threading.CancellationToken)')
- [ITextViewChangedListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract-TextViewChangedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract.TextViewChangedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange,System.Threading.CancellationToken)')
- [ITextViewExtension](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewExtension 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewExtension')
  - [TextViewExtensionConfiguration](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewExtension-TextViewExtensionConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewExtension.TextViewExtensionConfiguration')
- [ITextViewMarginProvider](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewMarginProvider')
  - [TextViewMarginProviderConfiguration](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider-TextViewMarginProviderConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewMarginProvider.TextViewMarginProviderConfiguration')
  - [CreateVisualElementAsync(textView,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider-CreateVisualElementAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewMarginProvider.CreateVisualElementAsync(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,System.Threading.CancellationToken)')
- [ITextViewMarginProviderContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewMarginProviderContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewMarginProviderContract')
  - [CreateVisualElementAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewMarginProviderContract-CreateVisualElementAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewMarginProviderContract.CreateVisualElementAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.Threading.CancellationToken)')
- [ITextViewOpenClosedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewOpenClosedListener')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewOpenClosedListener.TextViewClosedAsync(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,System.Threading.CancellationToken)')
  - [TextViewOpenedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener-TextViewOpenedAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewOpenClosedListener.TextViewOpenedAsync(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,System.Threading.CancellationToken)')
- [ITextViewOpenClosedListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewOpenClosedListenerContract')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract-TextViewClosedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewOpenClosedListenerContract.TextViewClosedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.Threading.CancellationToken)')
  - [TextViewOpenedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract-TextViewOpenedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewOpenClosedListenerContract.TextViewOpenedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.Threading.CancellationToken)')
- [TextDocumentSnapshotEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse')
  - [#ctor(after,editResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult- 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.RpcContracts.Editor.EditResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse.After')
  - [EditResult](#P-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-EditResult 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse.EditResult')
- [TextEdit](#T-Microsoft-VisualStudio-Extensibility-Editor-TextEdit 'Microsoft.VisualStudio.Extensibility.Editor.TextEdit')
  - [Range](#P-Microsoft-VisualStudio-Extensibility-Editor-TextEdit-Range 'Microsoft.VisualStudio.Extensibility.Editor.TextEdit.Range')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-TextEdit-Text 'Microsoft.VisualStudio.Extensibility.Editor.TextEdit.Text')
- [TextViewChange](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange')
  - [AfterTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.BeforeTextView')
  - [DocumentEdits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentEdits 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.DocumentEdits')
- [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs')
  - [#ctor(beforeTextView,afterTextView,edits)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-TextEdit}- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.TextEdit})')
  - [AfterTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-AfterTextView 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-BeforeTextView 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs.BeforeTextView')
  - [Edits](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-Edits 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs.Edits')
- [TextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedListener')
- [TextViewEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse')
  - [#ctor(after,editResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,Microsoft.VisualStudio.RpcContracts.Editor.EditResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse.After')
  - [EditResult](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-EditResult 'Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse.EditResult')
- [TextViewMarginProvider](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProvider 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProvider')
- [TextViewOpenClosedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewOpenClosedListener 'Microsoft.VisualStudio.Extensibility.Editor.TextViewOpenClosedListener')
- [VisualStudioExtensibilityExtensions](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions')
  - [Editor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions.Editor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-EditBatch'></a>
## EditBatch `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Builder for [CompoundEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract'), describing a set of
state changes that should be made by the process owning the entities to
be changed, on behalf of the extension.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-EditResponse'></a>
## EditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the cumulative result of a call to
[EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch},System.Threading.CancellationToken)').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse}-'></a>
### #ctor(succeeded,message,documentEditResults,textViewEditResults) `constructor`

##### Summary

Initializes a new instance of [EditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-EditResponse 'Microsoft.VisualStudio.Extensibility.Editor.EditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | `true` if the cumulative operation completed successfully. |
| message | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Any cumulative error message, `null`, or [Empty](https://learn.microsoft.com/dotnet/api/System.String.Empty 'System.String.Empty') if none. |
| documentEditResults | [System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse}') |  |
| textViewEditResults | [System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse}') | Per-document operation results including per document errors and updated [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
versions. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-DocumentEditResults'></a>
### DocumentEditResults `property`

##### Summary

Per-document operation results including per document errors and updated [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
versions.

##### Remarks

Key of dictionary is the version of the document prior to the edits.
[After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.After') contains the updated document version.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-Message'></a>
### Message `property`

##### Summary

Any cumulative error message, `null`, or [Empty](https://learn.microsoft.com/dotnet/api/System.String.Empty 'System.String.Empty') if none.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-Succeeded'></a>
### Succeeded `property`

##### Summary

`true` if the cumulative operation completed successfully.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-EditResponse-TextViewEditResults'></a>
### TextViewEditResults `property`

##### Summary

Per text view operation results including per text view errors and updated [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')
versions.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility'></a>
## EditorExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Framework object exposing methods for getting and interacting with [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')s
and [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')s and performing document edits and other state changes.

##### Remarks

You can get an instance of [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility') by calling
[Editor](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions.Editor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)') within an
[ExtensionPart](#T-Microsoft-VisualStudio-Extensibility-ExtensionPart 'Microsoft.VisualStudio.Extensibility.ExtensionPart') or Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-'></a>
### #ctor(extensibility,editorHostService) `constructor`

##### Summary

Initializes a new instance of [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | The root extensibility object. |
| editorHostService | [Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService') | The editor host service. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-IEditBatch},System-Threading-CancellationToken-'></a>
### EditAsync(editorSource,cancellationToken) `method`

##### Summary

Initiates an edit request in the host Visual Studio process, enabling
the extension to atomically request one or more [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
edits, caret position changes, or other state changes.

##### Returns

A response object detailing whether the operation was successful and which [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')s and [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')s changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| editorSource | [System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch}](https://learn.microsoft.com/dotnet/api/System.Action 'System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch}') | A service for obtaining editors for requesting changes to a [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1') object, such as [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot'). |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels a pending request. |

##### Remarks

Edit request is sent to Visual Studio IDE, where it succeeds only if the object being edited hasn't
changed since the version the request was made one. If the document has changed, the change may be rejected,
requiring the extension to retry on a newer version.

Edits are applied atomically. The best practice is to do all changes that should occur within a narrow time
frame within a single EditAsync() call to reduce the likelihood of unexpected behavior arising from user edits,
or language service actions that occur between edits.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-IClientContext,System-Threading-CancellationToken-'></a>
### GetActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the currently focused [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') in the host Visual Studio process.

##### Returns

An instance of [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.IClientContext](#T-Microsoft-VisualStudio-Extensibility-IClientContext 'Microsoft.VisualStudio.Extensibility.IClientContext') | The client context, usually passed to command handlers. |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

Can return `null` if the `clientContext` references a version of text view
that is sufficiently old so as to no longer be cached.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewChangedListener'></a>
## ITextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Extensibility point for listening for [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')s to be changed.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs,System-Threading-CancellationToken-'></a>
### TextViewChangedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is changed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract'></a>
## ITextViewChangedListenerContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for a listener that is notified when text views are changed.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract-TextViewChangedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange,System-Threading-CancellationToken-'></a>
### TextViewChangedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is changed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewExtension'></a>
## ITextViewExtension `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Base interface for extensibility points of text views.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewExtension-TextViewExtensionConfiguration'></a>
### TextViewExtensionConfiguration `property`

##### Summary

Gets the configuration for this [ITextViewExtension](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewExtension 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewExtension'). The value of this property is evaluated at
compile time when building the Visual Studio extension.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider'></a>
## ITextViewMarginProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Extensibility point for providing text view margins.

##### Remarks

Typical usage (providing a margin and listening to text view and text document changes):

```
[Export]
internal class MyTextViewMarginProvider : ExtensionPart, ITextViewMarginProvider, ITextViewChangedListener
```

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider-TextViewMarginProviderConfiguration'></a>
### TextViewMarginProviderConfiguration `property`

##### Summary

Gets the configuration for this [ITextViewMarginProvider](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewMarginProvider'). The value of this property is evaluated at
compile time when building the Visual Studio extension.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider-CreateVisualElementAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken-'></a>
### CreateVisualElementAsync(textView,cancellationToken) `method`

##### Returns

An [IRemoteUserControl](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl') which represents the margin's UI content.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textView | [Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') |  |
| cancellationToken | [System.Threading.CancellationToken](https://learn.microsoft.com/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') | A cancellation token to cancel the in-progress content creation. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewMarginProviderContract'></a>
## ITextViewMarginProviderContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for a text view margin provider.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewMarginProviderContract-CreateVisualElementAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken-'></a>
### CreateVisualElementAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from an unmatching document type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener'></a>
## ITextViewOpenClosedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Extensibility point for listening for [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')s to be opened
and closed.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken-'></a>
### TextViewClosedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from a matching document type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewOpenClosedListener-TextViewOpenedAsync-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Threading-CancellationToken-'></a>
### TextViewOpenedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from an unmatching document type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract'></a>
## ITextViewOpenClosedListenerContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for a listener that is notified when text views are
opened and closed.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract-TextViewClosedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken-'></a>
### TextViewClosedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from a matching document type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewOpenClosedListenerContract-TextViewOpenedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken-'></a>
### TextViewOpenedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with matching document type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from an unmatching document type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse'></a>
## TextDocumentSnapshotEditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the outcome of a call to [EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch},System.Threading.CancellationToken)')
for changes to a particular [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult-'></a>
### #ctor(after,editResult) `constructor`

##### Summary

Initializes a new instance of [TextDocumentSnapshotEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentSnapshotEditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version after the changes were applied. |
| editResult | [Microsoft.VisualStudio.RpcContracts.Editor.EditResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult') | The result of the edit operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-After'></a>
### After `property`

##### Summary

The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentSnapshotEditResponse-EditResult'></a>
### EditResult `property`

##### Summary

The result of the edit operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') if
all changes were applied successfully to the target [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextEdit'></a>
## TextEdit `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

A list of changes applied to a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextEdit-Range'></a>
### Range `property`

##### Summary

The range to replace. Can be zero length.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextEdit-Text'></a>
### Text `property`

##### Summary

The new text to insert.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange'></a>
## TextViewChange `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing a [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') after the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') before the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentEdits'></a>
### DocumentEdits `property`

##### Summary

The set of edits made to the document during this change.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs'></a>
## TextViewChangedArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Arguments for [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewChangedListener').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-TextEdit}-'></a>
### #ctor(beforeTextView,afterTextView,edits) `constructor`

##### Summary

Creates a new instance of [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.TextViewChangedArgs').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeTextView | [Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') | The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') before the change. |
| afterTextView | [Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') | The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') after. |
| edits | [System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.TextEdit}](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.TextEdit}') | A list of changes applied to the text document. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') after the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') before the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedArgs-Edits'></a>
### Edits `property`

##### Summary

A list of changes applied to the text document.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewChangedListener'></a>
## TextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse'></a>
## TextViewEditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the outcome of a call to [EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.IEditBatch},System.Threading.CancellationToken)')
for changes to a particular [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult-'></a>
### #ctor(after,editResult) `constructor`

##### Summary

Initializes a new instance of [TextViewEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.TextViewEditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') | The [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') version after the changes were applied. |
| editResult | [Microsoft.VisualStudio.RpcContracts.Editor.EditResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult') | The result of the edit operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-After'></a>
### After `property`

##### Summary

The [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewEditResponse-EditResult'></a>
### EditResult `property`

##### Summary

The result of the edit operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') if
all changes were applied successfully to the target [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot').

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProvider'></a>
## TextViewMarginProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewOpenClosedListener'></a>
## TextViewOpenClosedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions'></a>
## VisualStudioExtensibilityExtensions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Editor provided extension methods for acquiring VS extensibility points.

<a name='M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Editor(extensibility) `method`

##### Summary

Gets an instance of the [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility') point.

##### Returns

Editor extensibility.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | The root [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') instance. |
