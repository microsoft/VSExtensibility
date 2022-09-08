<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Editor

## Contents

- [AppliesToAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute')
  - [DocumentType](#P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute.DocumentType')
- [AppliesToPatternAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToPatternAttribute')
  - [Pattern](#P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute-Pattern 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToPatternAttribute.Pattern')
  - [RelativePath](#P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute-RelativePath 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToPatternAttribute.RelativePath')
- [DocumentTypeBaseDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute')
  - [#ctor(documentTypeName,baseDocumentTypeName)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute.#ctor(System.String,System.String)')
  - [Base](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-Base 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute.Base')
  - [DocumentType](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute.DocumentType')
- [DocumentTypeDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute.#ctor(System.String)')
  - [DocumentType](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute.DocumentType')
- [EditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditBatch 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditBatch')
- [EditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse')
  - [#ctor(succeeded,message,documentEditResults,textViewEditResults)](#M-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse}- 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse.#ctor(System.Boolean,System.String,System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse},System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse})')
  - [DocumentEditResults](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-DocumentEditResults 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse.DocumentEditResults')
  - [Message](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-Message 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse.Message')
  - [Succeeded](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-Succeeded 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse.Succeeded')
  - [TextViewEditResults](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-TextViewEditResults 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse.TextViewEditResults')
- [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility')
  - [#ctor(extensibility,editorHostService)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-#ctor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility,Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.#ctor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility,Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService)')
  - [EditAsync(editorSource,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch},System.Threading.CancellationToken)')
  - [GetActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.GetActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
- [FileExtensionMappingAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute')
  - [#ctor(fileExtension,documentType)](#M-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute.#ctor(System.String,System.String)')
  - [DocumentType](#P-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute.DocumentType')
  - [FileExtension](#P-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-FileExtension 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute.FileExtension')
- [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener.TextViewChangedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs,System.Threading.CancellationToken)')
- [ITextViewChangedListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract-TextViewChangedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract.TextViewChangedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange,System.Threading.CancellationToken)')
- [ITextViewLifetimeListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener.TextViewClosedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,System.Threading.CancellationToken)')
  - [TextViewCreatedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewCreatedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener.TextViewCreatedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,System.Threading.CancellationToken)')
- [ITextViewLifetimeListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewClosedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract.TextViewClosedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextView,System.Threading.CancellationToken)')
  - [TextViewCreatedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewCreatedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract.TextViewCreatedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextView,System.Threading.CancellationToken)')
- [TextDocumentSnapshotEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse')
  - [#ctor(after,editResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult- 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot,Microsoft.VisualStudio.RpcContracts.Editor.EditResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse.After')
  - [EditResult](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-EditResult 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse.EditResult')
- [TextEdit](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit')
  - [Range](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit-Range 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit.Range')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit-Text 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit.Text')
- [TextViewChange](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange')
  - [AfterTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.BeforeTextView')
  - [DocumentEdits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentEdits 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.DocumentEdits')
- [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs')
  - [#ctor(beforeTextView,afterTextView,edits)](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit}- 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.#ctor(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit})')
  - [AfterTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-AfterTextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-BeforeTextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.BeforeTextView')
  - [Edits](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-Edits 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.Edits')
- [TextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedListener')
- [TextViewEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse')
  - [#ctor(after,editResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult- 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,Microsoft.VisualStudio.RpcContracts.Editor.EditResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse.After')
  - [EditResult](#P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-EditResult 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse.EditResult')
- [TextViewLifetimeListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewLifetimeListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewLifetimeListener')
- [VisualStudioExtensibilityExtensions](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions')
  - [Editor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions.Editor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute'></a>
## AppliesToAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the conditions under which an extension part should
be activated.

##### See Also

- [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute')

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute-DocumentType'></a>
### DocumentType `property`

##### Summary

The document type of an object. Document type is frequently used to
target specific languages.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute'></a>
## AppliesToPatternAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the conditions under which an extension part should
be activated.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute-Pattern'></a>
### Pattern `property`

##### Summary

The glob pattern to match document file path.
Glob patterns can have the following syntax:

* to match one or more characters in a path segment
? to match on one character in a path segment
** to match any number of path segments, including none
{} to group conditions (e.g. **/*.{ts,js} matches all TypeScript and JavaScript files)
[] to declare a range of characters to match in a path segment (e.g., example.[0-9]
to match on example.0, example.1, …)
[!...] to negate a range of characters to match in a path segment (e.g., example.[!0-9]
to match on example.a, example.b, but not example.0)
Note: a backslash (\) is not valid within a glob pattern. If you have an existing file path to match against,
consider to use the relative pattern support that takes care of converting any backslash into slash.
Otherwise, make sure to convert any backslash to slash when creating the glob pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToPatternAttribute-RelativePath'></a>
### RelativePath `property`

##### Summary

Defines whether the pattern should be applied to the absolute path of a file or to a path
relative to the solution folder.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute'></a>
## DocumentTypeBaseDefinitionAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Makes a document type inheriting from a defined base.

##### Remarks

Example:

```
[assembly: DocumentTypeDefinitionAttribute("markdown")]
[assembly: DocumentTypeBaseDefinitionAttribute("markdown", baseDocumentTypeName: "code")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".md")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".mdk")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".markdn")]
```

##### See Also

- [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute')

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-#ctor-System-String,System-String-'></a>
### #ctor(documentTypeName,baseDocumentTypeName) `constructor`

##### Summary

Initializes a new instance of [DocumentTypeBaseDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The document type name. Document type names are case-insensitive. |
| baseDocumentTypeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base document type name. Document type names are case-insensitive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `documentTypeName` or `baseDocumentTypeName` is null or an empty string. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-Base'></a>
### Base `property`

##### Summary

The base document type name.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute-DocumentType'></a>
### DocumentType `property`

##### Summary

The document type name.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute'></a>
## DocumentTypeDefinitionAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Declares a new document type.

##### Remarks

Example:

```
[assembly: DocumentTypeDefinitionAttribute("markdown")]
[assembly: DocumentTypeBaseDefinitionAttribute("markdown", baseDocumentTypeName: "code")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".md")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".mdk")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".markdn")]
```

##### See Also

- [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute')

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of [DocumentTypeDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The document type name. Document type names are case-insensitive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `name` is null or an empty string. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute-DocumentType'></a>
### DocumentType `property`

##### Summary

The document type name.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditBatch'></a>
## EditBatch `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Editing

##### Summary

Builder for [CompoundEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract'), describing a set of
state changes that should be made by the process owning the entities to
be changed, on behalf of the extension.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse'></a>
## EditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Editing

##### Summary

Describes the cumulative result of a call to
[EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch},System.Threading.CancellationToken)').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse}-'></a>
### #ctor(succeeded,message,documentEditResults,textViewEditResults) `constructor`

##### Summary

Initializes a new instance of [EditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.EditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the cumulative operation completed successfully. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Any cumulative error message, `null`, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none. |
| documentEditResults | [System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse}') |  |
| textViewEditResults | [System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot,Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse}') | Per-document operation results including per document errors and updated [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot')
versions. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-DocumentEditResults'></a>
### DocumentEditResults `property`

##### Summary

Per-document operation results including per document errors and updated [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot')
versions.

##### Remarks

Key of dictionary is the version of the document prior to the edits.
[After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.After') contains the updated document version.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-Message'></a>
### Message `property`

##### Summary

Any cumulative error message, `null`, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-Succeeded'></a>
### Succeeded `property`

##### Summary

`true` if the cumulative operation completed successfully.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-EditResponse-TextViewEditResults'></a>
### TextViewEditResults `property`

##### Summary

Per text view operation results including per text view errors and updated [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot')
versions.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility'></a>
## EditorExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Framework object exposing methods for getting and interacting with [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot')s
and [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot')s and performing document edits and other state changes.

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

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditBatch},System-Threading-CancellationToken-'></a>
### EditAsync(editorSource,cancellationToken) `method`

##### Summary

Initiates an edit request in the host Visual Studio process, enabling
the extension to atomically request one or more [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot')
edits, caret position changes, or other state changes.

##### Returns

A response object detailing whether the operation was successful and which [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot')s and [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot')s changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| editorSource | [System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch}') | A service for obtaining editors for requesting changes to a [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditable`1') object, such as [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels a pending request. |

##### Remarks

Edit request is sent to Visual Studio IDE, where it succeeds only if the object being edited hasn't
changed since the version the request was made one. If the document has changed, the change may be rejected,
requiring the extension to retry on a newer version.

Edits are applied atomically. The best practice is to do all changes that should occur within a narrow time
frame within a single EditAsync() call to reduce the likelihood of unexpected behavior arising from user edits,
or language service actions that occur between edits.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-GetActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### GetActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Gets the currently focused [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') in the host Visual Studio process.

##### Returns

An instance of [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | The client context, usually passed to command handlers. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

Can return `null` if the `clientContext` references a version of text view
that is sufficiently old so as to no longer be cached.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute'></a>
## FileExtensionMappingAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Associate a document type to a file extension.

##### Remarks

Example:

```
[assembly: DocumentTypeDefinitionAttribute("markdown")]
[assembly: DocumentTypeBaseDefinitionAttribute("markdown", baseDocumentTypeName: "code")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".md")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".mdk")]
[assembly: FileExtensionMappingAttribute("markdown", fileExtension: ".markdn")]
```

##### See Also

- [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeDefinitionAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeBaseDefinitionAttribute 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeBaseDefinitionAttribute')
- [Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute')

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-#ctor-System-String,System-String-'></a>
### #ctor(fileExtension,documentType) `constructor`

##### Summary

Initializes a new instance of [FileExtensionMappingAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute 'Microsoft.VisualStudio.Extensibility.Editor.FileExtensionMappingAttribute').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileExtension | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file extension. File extensions are case-insensitive. |
| documentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The document type name. Document type names are case-insensitive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `fileExtension` or `documentType` is null or an empty string. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-DocumentType'></a>
### DocumentType `property`

##### Summary

The document type name.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-FileExtensionMappingAttribute-FileExtension'></a>
### FileExtension `property`

##### Summary

The file extension.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener'></a>
## ITextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Extensibility point for listening for [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot')s to be changed.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs,System-Threading-CancellationToken-'></a>
### TextViewChangedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is changed.

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

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is changed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener'></a>
## ITextViewLifetimeListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Extensibility point for listening for [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot')s to be opened
and closed.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Threading-CancellationToken-'></a>
### TextViewClosedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from a matching document type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewCreatedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Threading-CancellationToken-'></a>
### TextViewCreatedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from an unmatching document type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract'></a>
## ITextViewLifetimeListenerContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for a listener that is notified when text views are
opened and closed.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewClosedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken-'></a>
### TextViewClosedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from a matching document type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewCreatedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken-'></a>
### TextViewCreatedAsync() `method`

##### Summary

Called when an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') with matching document type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Document type changes from an unmatching document type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse'></a>
## TextDocumentSnapshotEditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Editing

##### Summary

Describes the outcome of a call to [EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch},System.Threading.CancellationToken)')
for changes to a particular [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult-'></a>
### #ctor(after,editResult) `constructor`

##### Summary

Initializes a new instance of [TextDocumentSnapshotEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextDocumentSnapshotEditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot') | The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot') version after the changes were applied. |
| editResult | [Microsoft.VisualStudio.RpcContracts.Editor.EditResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult') | The result of the edit operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-After'></a>
### After `property`

##### Summary

The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextDocumentSnapshotEditResponse-EditResult'></a>
### EditResult `property`

##### Summary

The result of the edit operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') if
all changes were applied successfully to the target [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot').

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit'></a>
## TextEdit `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Editing

##### Summary

A list of changes applied to a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentSnapshot').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit-Range'></a>
### Range `property`

##### Summary

The range to replace. Can be zero length.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit-Text'></a>
### Text `property`

##### Summary

The new text to insert.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange'></a>
## TextViewChange `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing a [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') after the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') before the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentEdits'></a>
### DocumentEdits `property`

##### Summary

The set of edits made to the document during this change.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs'></a>
## TextViewChangedArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Arguments for [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-Editing-TextEdit}-'></a>
### #ctor(beforeTextView,afterTextView,edits) `constructor`

##### Summary

Creates a new instance of [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeTextView | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') | The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') before the change. |
| afterTextView | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') | The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') after. |
| edits | [System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.Editing.TextEdit}') | A list of changes applied to the text document. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') after the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') before the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-Edits'></a>
### Edits `property`

##### Summary

A list of changes applied to the text document.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedListener'></a>
## TextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse'></a>
## TextViewEditResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Editing

##### Summary

Describes the outcome of a call to [EditAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-EditAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Editing-IEditBatch},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.EditAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Editing.IEditBatch},System.Threading.CancellationToken)')
for changes to a particular [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot,Microsoft-VisualStudio-RpcContracts-Editor-EditResult-'></a>
### #ctor(after,editResult) `constructor`

##### Summary

Initializes a new instance of [TextViewEditResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse 'Microsoft.VisualStudio.Extensibility.Editor.Editing.TextViewEditResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') | The [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') version after the changes were applied. |
| editResult | [Microsoft.VisualStudio.RpcContracts.Editor.EditResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult') | The result of the edit operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-After'></a>
### After `property`

##### Summary

The [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Editing-TextViewEditResponse-EditResult'></a>
### EditResult `property`

##### Summary

The result of the edit operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') if
all changes were applied successfully to the target [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewSnapshot').

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewLifetimeListener'></a>
## TextViewLifetimeListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

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
