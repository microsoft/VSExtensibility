<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.EditorHostService

## Contents

- [IMefHostExportProvider](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider')
  - [GetExport\`\`1()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExport``1 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExport``1')
  - [GetExport\`\`2()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExport``2 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExport``2')
  - [GetExportedValue\`\`1()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExportedValue``1 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExportedValue``1')
  - [GetExportedValues\`\`1()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExportedValues``1 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExportedValues``1')
  - [GetExports\`\`1()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExports``1 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExports``1')
  - [GetExports\`\`2()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExports``2 'Microsoft.VisualStudio.Extensibility.EditorHostService.IMefHostExportProvider.GetExports``2')
- [TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-GetHashCode 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-op_Equality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument.op_Equality(Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument,Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-op_Inequality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument.op_Inequality(Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument,Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument)')
- [TextDocumentLine](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentLine 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentLine')
- [TextDocumentLinesCollectionFacade](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentLinesCollectionFacade 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentLinesCollectionFacade')
- [TextDocumentObserver](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentObserver 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentObserver')

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider'></a>
## IMefHostExportProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExport``1'></a>
### GetExport\`\`1() `method`

##### Summary

Gets lazy export matching the type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExport``2'></a>
### GetExport\`\`2() `method`

##### Summary

Gets lazy export matching the type and metadata.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExportedValue``1'></a>
### GetExportedValue\`\`1() `method`

##### Summary

Gets one exported object matching the type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExportedValues``1'></a>
### GetExportedValues\`\`1() `method`

##### Summary

Gets all exported objects matching the type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExports``1'></a>
### GetExports\`\`1() `method`

##### Summary

Gets all lazy exports matching the type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-IMefHostExportProvider-GetExports``2'></a>
### GetExports\`\`2() `method`

##### Summary

Gets all lazy exports matching the type and metadata.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument'></a>
## TextDocument `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Lightweight facade for exposing selected immutable elements of [ITextSnapshot](#T-Microsoft-VisualStudio-Text-ITextSnapshot 'Microsoft.VisualStudio.Text.ITextSnapshot') and
[ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') to OOP language extensions hosted in Service Hub.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-op_Equality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument') | Right item. |

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-op_Inequality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument') | Right item. |

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentLine'></a>
## TextDocumentLine `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Exposes an alternative to [ITextSnapshotLine](#T-Microsoft-VisualStudio-Text-ITextSnapshotLine 'Microsoft.VisualStudio.Text.ITextSnapshotLine') to OOP extensions hosted
in Service Hub.

##### Remarks

[TextImageLine](#T-Microsoft-VisualStudio-Text-TextImageLine 'Microsoft.VisualStudio.Text.TextImageLine') is a comparable alternative to [ITextSnapshotLine](#T-Microsoft-VisualStudio-Text-ITextSnapshotLine 'Microsoft.VisualStudio.Text.ITextSnapshotLine')
that performs one less heap allocation to acquire, so we use it instead in our wrapper.

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentLinesCollectionFacade'></a>
## TextDocumentLinesCollectionFacade `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Facade that presents as if it was a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1')
but actually creates the wrapper objects on demand.

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentObserver'></a>
## TextDocumentObserver `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Document that observes an [ITextDocument](#T-Microsoft-VisualStudio-Text-ITextDocument 'Microsoft.VisualStudio.Text.ITextDocument') in another process, often in-proc in
Visual Studio, and produces [TextDocument](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocument 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocument')s, the OOP analogue for [ITextSnapshot](#T-Microsoft-VisualStudio-Text-ITextSnapshot 'Microsoft.VisualStudio.Text.ITextSnapshot')
for consumption by OOP Gladstone extensions running in Service Hub.
