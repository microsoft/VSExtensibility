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
- [TextDocumentObserver](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentObserver 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentObserver')
- [TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-GetHashCode 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-op_Equality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot.op_Equality(Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-op_Inequality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot- 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot.op_Inequality(Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot)')
- [TextDocumentSnapshotLine](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshotLine 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshotLine')
- [TextDocumentSnapshotLinesCollectionFacade](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshotLinesCollectionFacade 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshotLinesCollectionFacade')

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

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentObserver'></a>
## TextDocumentObserver `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Document that observes an [ITextDocument](#T-Microsoft-VisualStudio-Text-ITextDocument 'Microsoft.VisualStudio.Text.ITextDocument') in another process, often in-proc in
Visual Studio, and produces [TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot')s, the OOP analogue for [ITextSnapshot](#T-Microsoft-VisualStudio-Text-ITextSnapshot 'Microsoft.VisualStudio.Text.ITextSnapshot')
for consumption by OOP Gladstone extensions running in Service Hub.

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot'></a>
## TextDocumentSnapshot `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Lightweight facade for exposing selected immutable elements of [ITextSnapshot](#T-Microsoft-VisualStudio-Text-ITextSnapshot 'Microsoft.VisualStudio.Text.ITextSnapshot') and
[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') to OOP language extensions hosted in Service Hub.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-op_Equality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equivalent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot') | Right item. |

<a name='M-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-op_Inequality-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.EditorHostService.TextDocumentSnapshot') | Right item. |

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshotLine'></a>
## TextDocumentSnapshotLine `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Exposes an alternative to [ITextSnapshotLine](#T-Microsoft-VisualStudio-Text-ITextSnapshotLine 'Microsoft.VisualStudio.Text.ITextSnapshotLine') to OOP extensions hosted
in Service Hub.

##### Remarks

[TextImageLine](#T-Microsoft-VisualStudio-Text-TextImageLine 'Microsoft.VisualStudio.Text.TextImageLine') is a comparable alternative to [ITextSnapshotLine](#T-Microsoft-VisualStudio-Text-ITextSnapshotLine 'Microsoft.VisualStudio.Text.ITextSnapshotLine')
that performs one less heap allocation to acquire, so we use it instead in our wrapper.

<a name='T-Microsoft-VisualStudio-Extensibility-EditorHostService-TextDocumentSnapshotLinesCollectionFacade'></a>
## TextDocumentSnapshotLinesCollectionFacade `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.EditorHostService

##### Summary

Facade that presents as if it was a [IReadOnlyList\`1](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')
but actually creates the wrapper objects on demand.
