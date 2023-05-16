<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Editor.Contracts

## Contents

- [CompoundEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract')
  - [Edits](#P-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract-Edits 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract.Edits')
- [EditContractBase](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditContractBase 'Microsoft.VisualStudio.RpcContracts.Editor.EditContractBase')
- [EditResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.EditResponseContract')
  - [DocumentEditResults](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-DocumentEditResults 'Microsoft.VisualStudio.RpcContracts.Editor.EditResponseContract.DocumentEditResults')
  - [Message](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-Message 'Microsoft.VisualStudio.RpcContracts.Editor.EditResponseContract.Message')
  - [Succeeded](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-Succeeded 'Microsoft.VisualStudio.RpcContracts.Editor.EditResponseContract.Succeeded')
  - [TextViewEditResults](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-TextViewEditResults 'Microsoft.VisualStudio.RpcContracts.Editor.EditResponseContract.TextViewEditResults')
- [EditResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult')
  - [Aborted](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Aborted 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Aborted')
  - [DocumentChanged](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentChanged 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.DocumentChanged')
  - [DocumentNotOpen](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentNotOpen 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.DocumentNotOpen')
  - [DocumentVersionTooOld](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentVersionTooOld 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.DocumentVersionTooOld')
  - [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success')
  - [TextViewNotOpen](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-TextViewNotOpen 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.TextViewNotOpen')
- [EditorContextContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContextContract')
  - [ActiveTextViewId](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-ActiveTextViewId 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContextContract.ActiveTextViewId')
  - [TextDocuments](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-TextDocuments 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContextContract.TextDocuments')
  - [TextViews](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-TextViews 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContextContract.TextViews')
- [EditorOptionChangedArgs](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs 'Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs')
  - [#ctor(optionName,newValue)](#M-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-#ctor-System-String,Newtonsoft-Json-Linq-JToken- 'Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs.#ctor(System.String,Newtonsoft.Json.Linq.JToken)')
  - [NewValue](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-NewValue 'Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs.NewValue')
  - [OptionName](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-OptionName 'Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs.OptionName')
- [EditorOption\`2](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2.#ctor(System.String)')
  - [Name](#P-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-Name 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2.Name')
  - [GetValue()](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-GetValue-Newtonsoft-Json-Linq-JToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2.GetValue(Newtonsoft.Json.Linq.JToken)')
  - [op_Equality()](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1},Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1}- 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.EditorOption{`0,`1},Microsoft.VisualStudio.Extensibility.Editor.EditorOption{`0,`1})')
  - [op_Inequality()](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1},Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1}- 'Microsoft.VisualStudio.Extensibility.Editor.EditorOption`2.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.EditorOption{`0,`1},Microsoft.VisualStudio.Extensibility.Editor.EditorOption{`0,`1})')
- [EditorServices](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices 'Microsoft.VisualStudio.RpcContracts.Editor.EditorServices')
  - [EditorOptionsServiceDescriptor](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-EditorOptionsServiceDescriptor 'Microsoft.VisualStudio.RpcContracts.Editor.EditorServices.EditorOptionsServiceDescriptor')
  - [TextEditorSynchronizationServiceDescriptor](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-TextEditorSynchronizationServiceDescriptor 'Microsoft.VisualStudio.RpcContracts.Editor.EditorServices.TextEditorSynchronizationServiceDescriptor')
- [IEditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch')
  - [AddEditRpcContract(rpcContract)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-AddEditRpcContract-Microsoft-VisualStudio-RpcContracts-Editor-EditContractBase- 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch.AddEditRpcContract(Microsoft.VisualStudio.RpcContracts.Editor.EditContractBase)')
  - [GetOrCreateEditor\`\`1(editable)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-GetOrCreateEditor``1-Microsoft-VisualStudio-Extensibility-Editor-IEditable{``0}- 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch.GetOrCreateEditor``1(Microsoft.VisualStudio.Extensibility.Editor.IEditable{``0})')
- [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1')
  - [AsEditable(batch)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1-AsEditable-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch- 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1.AsEditable(Microsoft.VisualStudio.Extensibility.Editor.IEditBatch)')
  - [CreateEditor(editBatch)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1-CreateEditor-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch- 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1.CreateEditor(Microsoft.VisualStudio.Extensibility.Editor.IEditBatch)')
- [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService')
  - [CreateActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateActiveTextViewAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateActiveTextViewAsync(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},System.Threading.CancellationToken)')
  - [CreatePositionAsync(textDocumentPosition,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreatePositionAsync(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract,System.Threading.CancellationToken)')
  - [CreatePositionAsync(documentUri,version,position,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreatePositionAsync(System.Uri,System.Int32,Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract,System.Threading.CancellationToken)')
  - [CreateSpanAsync(range,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateSpanAsync(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract,System.Threading.CancellationToken)')
  - [CreateSpanAsync(documentUri,version,range,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateSpanAsync(System.Uri,System.Int32,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.Threading.CancellationToken)')
  - [CreateTextDocumentAsync(textDocument,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateTextDocumentAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.Threading.CancellationToken)')
  - [CreateTextViewAsync(textView,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextViewAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateTextViewAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.Threading.CancellationToken)')
- [IEditorOption\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditorOption`1')
  - [Name](#P-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1-Name 'Microsoft.VisualStudio.Extensibility.Editor.IEditorOption`1.Name')
  - [GetValue(jsonToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1-GetValue-Newtonsoft-Json-Linq-JToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorOption`1.GetValue(Newtonsoft.Json.Linq.JToken)')
- [IEditorOptionsService](#T-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService 'Microsoft.VisualStudio.RpcContracts.Editor.IEditorOptionsService')
  - [GetTextDocumentOptionValueAsync(document,optionName,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-GetTextDocumentOptionValueAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.IEditorOptionsService.GetTextDocumentOptionValueAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.String,System.Threading.CancellationToken)')
  - [GetTextViewOptionValueAsync(textView,optionName,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-GetTextViewOptionValueAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.IEditorOptionsService.GetTextViewOptionValueAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.String,System.Threading.CancellationToken)')
  - [SubscribeToTextDocumentOptionChangesAsync(observer,document,optionName,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-SubscribeToTextDocumentOptionChangesAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs},Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.IEditorOptionsService.SubscribeToTextDocumentOptionChangesAsync(System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs},Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.String,System.Threading.CancellationToken)')
  - [SubscribeToTextViewOptionChangesAsync(observer,textView,optionName,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-SubscribeToTextViewOptionChangesAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs},Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.IEditorOptionsService.SubscribeToTextViewOptionChangesAsync(System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs},Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract,System.String,System.Threading.CancellationToken)')
- [ITextDocumentEditor](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document')
  - [Delete(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Delete-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Delete(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [Insert(position,text)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Insert-System-Int32,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Insert(System.Int32,System.String)')
  - [Reload()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Reload 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Reload')
  - [Rename(newFilePath)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Rename-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Rename(System.String)')
  - [Replace(replaceRange,replaceWith)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Replace-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Replace(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String)')
  - [Save()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Save 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Save')
  - [SaveAs(filePath,overwrite)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveAs-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.SaveAs(System.String,System.Boolean)')
  - [SaveAs(filePath,overwrite,createFolder)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveAs-System-String,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.SaveAs(System.String,System.Boolean,System.Boolean)')
  - [SaveCopy(filePath,overwrite)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveCopy-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.SaveCopy(System.String,System.Boolean)')
  - [SaveCopy(filePath,overwrite,createFolder)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveCopy-System-String,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.SaveCopy(System.String,System.Boolean,System.Boolean)')
- [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
  - [IsDirty](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-IsDirty 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.IsDirty')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Item-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.Item(System.Int32)')
  - [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Length 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.Length')
  - [Lines](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Lines 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.Lines')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.RpcContract')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Text 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.Text')
  - [Uri](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Uri 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.Uri')
  - [GetEditorOptionValueAsync\`\`1(option,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetEditorOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.GetEditorOptionValueAsync``1(Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{``0},System.Threading.CancellationToken)')
  - [GetLineFromPosition(position)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetLineFromPosition-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.GetLineFromPosition(System.Int32)')
  - [GetLineNumberFromPosition()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetLineNumberFromPosition-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.GetLineNumberFromPosition(System.Int32)')
  - [TranslatePositionTo(position,trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-TranslatePositionTo-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.TranslatePositionTo(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode)')
  - [TranslateRangeTo(range,trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-TranslateRangeTo-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot.TranslateRangeTo(Microsoft.VisualStudio.Extensibility.Editor.TextRange,Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode)')
- [ITextDocumentSnapshotLine](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.Document')
  - [LineBreakLength](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-LineBreakLength 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.LineBreakLength')
  - [LineNumber](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-LineNumber 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.LineNumber')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-Text 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.Text')
  - [TextIncludingLineBreak](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-TextIncludingLineBreak 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.TextIncludingLineBreak')
  - [GetLineBreakText()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-GetLineBreakText 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine.GetLineBreakText')
- [ITextEditorSynchronizationServiceContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract')
  - [ApplyEditAsync(edit,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyEditAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyEditAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract,System.Threading.CancellationToken)')
  - [SubscribeToDocumentChangesAsync(textDocument,observer,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-SubscribeToDocumentChangesAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract},System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.SubscribeToDocumentChangesAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract},System.Threading.CancellationToken)')
- [ITextViewEditor](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewEditor 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewEditor')
- [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')
  - [FilePath](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-FilePath 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.FilePath')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.RpcContract')
  - [Selection](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Selection 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.Selection')
  - [Selections](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Selections 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.Selections')
  - [Uri](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Uri 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.Uri')
  - [GetOptionValueAsync\`\`1(option,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.GetOptionValueAsync``1(Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{``0},System.Threading.CancellationToken)')
  - [GetOptionValueAsync\`\`1(option,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption{``0},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.GetOptionValueAsync``1(Microsoft.VisualStudio.Extensibility.Editor.TextViewOption{``0},System.Threading.CancellationToken)')
  - [GetTextDocumentAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetTextDocumentAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot.GetTextDocumentAsync(System.Threading.CancellationToken)')
- [KnownClientContextCategories](#T-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories 'Microsoft.VisualStudio.Text.Editor.KnownClientContextCategories')
  - [Editor](#F-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories-Editor 'Microsoft.VisualStudio.Text.Editor.KnownClientContextCategories.Editor')
- [KnownEditorClientContextCategoryProperties](#T-Microsoft-VisualStudio-Text-Editor-KnownEditorClientContextCategoryProperties 'Microsoft.VisualStudio.Text.Editor.KnownEditorClientContextCategoryProperties')
- [ReloadContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract')
  - [#ctor(textDocument)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract- 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract)')
  - [TextDocument](#P-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract.TextDocument')
- [SaveContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract')
  - [#ctor(before,after,isCopy,allowOverwrite,allowCreateFolder)](#M-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Uri,System-Boolean,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.Uri,System.Boolean,System.Boolean,System.Boolean)')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.After')
  - [AllowCreateFolder](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowCreateFolder 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.AllowCreateFolder')
  - [AllowOverwrite](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowOverwrite 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.AllowOverwrite')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.Before')
  - [IsCopy](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-IsCopy 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.IsCopy')
- [Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-Selection 'Microsoft.VisualStudio.Extensibility.Editor.Selection')
  - [#ctor(extent,isReversed)](#M-Microsoft-VisualStudio-Extensibility-Editor-Selection-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.Selection.#ctor(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.Boolean)')
  - [Invalid](#F-Microsoft-VisualStudio-Extensibility-Editor-Selection-Invalid 'Microsoft.VisualStudio.Extensibility.Editor.Selection.Invalid')
  - [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition')
  - [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition')
  - [End](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-End 'Microsoft.VisualStudio.Extensibility.Editor.Selection.End')
  - [Extent](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-Extent 'Microsoft.VisualStudio.Extensibility.Editor.Selection.Extent')
  - [InsertionPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-InsertionPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.InsertionPosition')
  - [IsEmpty](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-IsEmpty 'Microsoft.VisualStudio.Extensibility.Editor.Selection.IsEmpty')
  - [IsReversed](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-IsReversed 'Microsoft.VisualStudio.Extensibility.Editor.Selection.IsReversed')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.Selection.RpcContract')
  - [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-Start 'Microsoft.VisualStudio.Extensibility.Editor.Selection.Start')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-Selection-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.Selection.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-Selection-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.Selection.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-Extensibility-Editor-Selection-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Selection,Microsoft-VisualStudio-Extensibility-Editor-Selection- 'Microsoft.VisualStudio.Extensibility.Editor.Selection.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.Selection,Microsoft.VisualStudio.Extensibility.Editor.Selection)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-Extensibility-Editor-Selection-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Selection,Microsoft-VisualStudio-Extensibility-Editor-Selection- 'Microsoft.VisualStudio.Extensibility.Editor.Selection.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.Selection,Microsoft.VisualStudio.Extensibility.Editor.Selection)')
- [SelectionEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionEditContract')
  - [Selections](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract-Selections 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionEditContract.Selections')
  - [TextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionEditContract.TextView')
- [TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract')
  - [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract.Uri')
  - [Version](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-Version 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract.Version')
- [TextDocumentEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract')
  - [#ctor(document,edits)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract[]- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract[])')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-Document 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract.Document')
  - [Edits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-Edits 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract.Edits')
- [TextDocumentEditResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.After')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.Before')
  - [EditResult](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.EditResult')
- [TextDocumentMetadataContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract')
  - [IsDirty](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-IsDirty 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.IsDirty')
  - [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Uri')
  - [Version](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Version 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Version')
  - [Merge()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Merge-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Merge(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract)')
- [TextDocumentOption\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption`1 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption`1')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption`1-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption`1.#ctor(System.String)')
- [TextDocumentSynchronizationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract')
  - [Edits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Edits 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract.Edits')
  - [Metadata](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Metadata 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract.Metadata')
- [TextEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract')
  - [Range](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract-Range 'Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract.Range')
  - [Text](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract-Text 'Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract.Text')
- [TextExtensions](#T-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions')
  - [CopyToString()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-CopyToString-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions.CopyToString(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [EndsWith()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-EndsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions.EndsWith(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.Boolean)')
  - [IndexOf()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-IndexOf-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions.IndexOf(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.Boolean)')
  - [LastIndexOf()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-LastIndexOf-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions.LastIndexOf(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.Boolean)')
  - [StartsWith()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-StartsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.TextExtensions.StartsWith(Microsoft.VisualStudio.Extensibility.Editor.TextRange,System.String,System.Boolean)')
- [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition')
  - [#ctor(document,position)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Document')
  - [Offset](#P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Offset 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Offset')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.RpcContract')
  - [Add(offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Add-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Add(System.Int32)')
  - [CompareTo(other)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-CompareTo-Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.CompareTo(Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [Difference(other)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Difference-Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Difference(Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Equals(System.Object)')
  - [GetChar()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetChar 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.GetChar')
  - [GetContainingLine()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetContainingLine 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.GetContainingLine')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.GetHashCode')
  - [Subtract(offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Subtract-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Subtract(System.Int32)')
  - [TranslateTo(targetDocumentVersion,trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode)')
  - [op_Addition(position,offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Addition-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Addition(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,System.Int32)')
  - [op_Equality()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [op_GreaterThan()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_GreaterThan-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_GreaterThan(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.TextPosition)~Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-~System-Int32 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.TextPosition)~System.Int32')
  - [op_Inequality()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [op_LessThan()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_LessThan-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_LessThan(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [op_Subtraction(position,offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Subtraction(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,System.Int32)')
  - [op_Subtraction(start,other)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.op_Subtraction(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
- [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract')
  - [#ctor(line,column)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-#ctor-System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract.#ctor(System.Int32,System.Int32)')
  - [Column](#P-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-Column 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract.Column')
  - [Line](#P-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-Line 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract.Line')
- [TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode')
  - [Negative](#F-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-Negative 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode.Negative')
  - [Positive](#F-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-Positive 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode.Positive')
- [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange')
  - [#ctor(document,start,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,System.Int32,System.Int32)')
  - [#ctor(start,end)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.#ctor(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [#ctor(start,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.#ctor(Microsoft.VisualStudio.Extensibility.Editor.TextPosition,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Document')
  - [End](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-End 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.End')
  - [IsEmpty](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-IsEmpty 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.IsEmpty')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Item-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Item(System.Int32)')
  - [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Length 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Length')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.RpcContract')
  - [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Start 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Start')
  - [Contains(position)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Contains(System.Int32)')
  - [Contains(position)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-Microsoft-VisualStudio-Extensibility-Editor-TextPosition- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Contains(Microsoft.VisualStudio.Extensibility.Editor.TextPosition)')
  - [Contains(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Contains(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [CopyTo(destination)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-CopyTo-System-Span{System-Char}- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.CopyTo(System.Span{System.Char})')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Equals-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Equals(System.String,System.Boolean)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.GetHashCode')
  - [Intersection(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Intersection-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Intersection(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [IntersectsWith(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-IntersectsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.IntersectsWith(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [Overlap(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Overlap-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Overlap(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [OverlapsWith(range)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-OverlapsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.OverlapsWith(Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [Slice(start,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Slice-System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Slice(System.Int32,System.Int32)')
  - [TranslateTo(targetDocumentVersion,rangeTrackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode)')
  - [op_Equality()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.TextRange,Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextRange-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.TextRange)~Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract')
  - [op_Inequality()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRange- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.TextRange,Microsoft.VisualStudio.Extensibility.Editor.TextRange)')
- [TextRangeTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode')
  - [Custom](#F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-Custom 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode.Custom')
  - [EdgeExclusive](#F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeExclusive 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode.EdgeExclusive')
  - [EdgeInclusive](#F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeInclusive 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode.EdgeInclusive')
  - [EdgeNegative](#F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeNegative 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode.EdgeNegative')
  - [EdgePositive](#F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgePositive 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode.EdgePositive')
- [TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract-Document 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract.Document')
  - [Id](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract-Id 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract.Id')
- [TextViewEditResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewEditResponseContract')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewEditResponseContract.After')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewEditResponseContract.Before')
  - [EditResult](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-EditResult 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewEditResponseContract.EditResult')
- [TextViewOption\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption`1 'Microsoft.VisualStudio.Extensibility.Editor.TextViewOption`1')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption`1-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewOption`1.#ctor(System.String)')
- [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract')
  - [#ctor(textDocument,line,column)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.Int32,System.Int32)')
  - [Column](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Column 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract.Column')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Document 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract.Document')
  - [Line](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Line 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract.Line')
  - [op_Implicit()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-~Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract.op_Implicit(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract)~Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract')
- [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract')
  - [#ctor(textDocument,startLine,startColumn,endLine,endColumn)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Int32,System-Int32,System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract,System.Int32,System.Int32,System.Int32,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-Document 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.Document')
  - [EndColumn](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-EndColumn 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.EndColumn')
  - [EndLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-EndLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.EndLine')
  - [StartColumn](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-StartColumn 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.StartColumn')
  - [StartLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-StartLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.StartLine')
  - [op_Implicit()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-~Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.op_Implicit(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract)~Microsoft.VisualStudio.RpcContracts.Utilities.Range')

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract'></a>
## CompoundEditContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a set of state changes that should be made by the process
owning the entities to be changed, on behalf of the extension.

##### Remarks

Can be used with [ApplyEditAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyEditAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyEditAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract,System.Threading.CancellationToken)').

Prefer EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken)
to using the RPC contracts directly.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract-Edits'></a>
### Edits `property`

##### Summary

A set of changes to apply to text documents.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditContractBase'></a>
## EditContractBase `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract base class for state change operations that can be submitted as part of an atomic transaction via
[ApplyEditAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyEditAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyEditAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract,System.Threading.CancellationToken)').

##### Remarks

Must have [TypeDiscriminatorAttribute](#T-Microsoft-VisualStudio-RpcContracts-JsonConverters-TypeDiscriminatorAttribute 'Microsoft.VisualStudio.RpcContracts.JsonConverters.TypeDiscriminatorAttribute') for each sub-class.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract'></a>
## EditResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for an atomically applied set of edits, applied across multiple documents.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-DocumentEditResults'></a>
### DocumentEditResults `property`

##### Summary

Contains per-document operation results including per document errors and updated [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
versions.

##### Remarks

Key of dictionary is the version of the document prior to the edits.
[After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract.After') contains the updated document version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-Message'></a>
### Message `property`

##### Summary

Contains any high level error messages or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-Succeeded'></a>
### Succeeded `property`

##### Summary

`true` if all operations completed successfully.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditResponseContract-TextViewEditResults'></a>
### TextViewEditResults `property`

##### Summary

Contains per-view operation results including per text view errors and updated [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')
versions.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditResult'></a>
## EditResult `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Result of an edit operation.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Aborted'></a>
### Aborted `constants`

##### Summary

Operation was aborted for some reason. Check Message property for
more information.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentChanged'></a>
### DocumentChanged `constants`

##### Summary

Operation failed due to the document changing.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentNotOpen'></a>
### DocumentNotOpen `constants`

##### Summary

Operation failed because the target document is not open in the host process.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-DocumentVersionTooOld'></a>
### DocumentVersionTooOld `constants`

##### Summary

Operation failed because the target document version is too old.
Try again with a newer version.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success'></a>
### Success `constants`

##### Summary

Operation completed successfully.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-TextViewNotOpen'></a>
### TextViewNotOpen `constants`

##### Summary

Operation failed because the target text view is not open in the host process.

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract'></a>
## EditorContextContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

RPC contract representing a snapshot of editor context at some point of time.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-ActiveTextViewId'></a>
### ActiveTextViewId `property`

##### Summary

Index of the active text view.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-TextDocuments'></a>
### TextDocuments `property`

##### Summary

State of open text documents.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContextContract-TextViews'></a>
### TextViews `property`

##### Summary

State of open text views.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs'></a>
## EditorOptionChangedArgs `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Arguments that are sent when an editor option is changed.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-#ctor-System-String,Newtonsoft-Json-Linq-JToken-'></a>
### #ctor(optionName,newValue) `constructor`

##### Summary

Initializes a new instance of the [EditorOptionChangedArgs](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs 'Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option key that is updated. |
| newValue | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') | New value of the option, null if option is cleared. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-NewValue'></a>
### NewValue `property`

##### Summary

Gets the new value for the option, this is set to null if option is cleared.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs-OptionName'></a>
### OptionName `property`

##### Summary

Gets the option key that is updated.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2'></a>
## EditorOption\`2 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Base class for declaring an editor option.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Option value type. |
| S | Scope type such as [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Creates an editor text view option with the provided option name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name in scope of a text view. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-GetValue-Newtonsoft-Json-Linq-JToken-'></a>
### GetValue() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1},Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1}-'></a>
### op_Equality() `method`

##### Summary

Determines whether two instances of this type are the same.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-EditorOption`2-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1},Microsoft-VisualStudio-Extensibility-Editor-EditorOption{`0,`1}-'></a>
### op_Inequality() `method`

##### Summary

Determines whether two instances of this type are different.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices'></a>
## EditorServices `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Descriptors for internal Editor RPC services for Gladstone Extensibility.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-EditorOptionsServiceDescriptor'></a>
### EditorOptionsServiceDescriptor `property`

##### Summary

Descriptor for editor options service.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-TextEditorSynchronizationServiceDescriptor'></a>
### TextEditorSynchronizationServiceDescriptor `property`

##### Summary

Descriptor for text editor synchronization and buffer manipulation service.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch'></a>
## IEditBatch `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Exposes a way to acquire an instance of a object for
modifying some [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-AddEditRpcContract-Microsoft-VisualStudio-RpcContracts-Editor-EditContractBase-'></a>
### AddEditRpcContract(rpcContract) `method`

##### Summary

Registers an RPC request to happen as part of a [CompoundEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract')
request to [ApplyEditAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyEditAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyEditAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract,System.Threading.CancellationToken)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rpcContract | [Microsoft.VisualStudio.RpcContracts.Editor.EditContractBase](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditContractBase 'Microsoft.VisualStudio.RpcContracts.Editor.EditContractBase') | The RPC contract of the operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-GetOrCreateEditor``1-Microsoft-VisualStudio-Extensibility-Editor-IEditable{``0}-'></a>
### GetOrCreateEditor\`\`1(editable) `method`

##### Summary

Gets an object that exposes methods for modifying `editable`.

##### Returns

An instance of an object that can change the target object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| editable | [Microsoft.VisualStudio.Extensibility.Editor.IEditable{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable{``0} 'Microsoft.VisualStudio.Extensibility.Editor.IEditable{``0}') | The object being edited. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEditor | The specific type of the editor object. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1'></a>
## IEditable\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Immutable object that supports being asynchronously editable via a call to
EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken)

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEditor | The type of the object that does the edit. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1-AsEditable-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-'></a>
### AsEditable(batch) `method`

##### Summary

Gets an interface with methods for requesting changes to the
underlying [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1') object.

##### Returns

An object that performs edits on the [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| batch | [Microsoft.VisualStudio.Extensibility.Editor.IEditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch') | A batch of edits created within a call to EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken). |

##### Remarks

This method and the value it returns is only supported within the [Action\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action`1 'System.Action`1')
accepted by EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken).
After it returns, the returned object is no longer valid.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1-CreateEditor-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-'></a>
### CreateEditor(editBatch) `method`

##### Summary

An internal implementation detail of the Visual Studio out of process extensibility
system that maintains a single instance of an editor for an [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1')
object.

##### Returns

The object with methods for editing the [IEditable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| editBatch | [Microsoft.VisualStudio.Extensibility.Editor.IEditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch') | The [IEditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch') to create the editor for. |

##### Remarks

This method should be called by [AsEditable](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditable`1-AsEditable-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch- 'Microsoft.VisualStudio.Extensibility.Editor.IEditable`1.AsEditable(Microsoft.VisualStudio.Extensibility.Editor.IEditBatch)') via
[GetOrCreateEditor\`\`1](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch-GetOrCreateEditor``1-Microsoft-VisualStudio-Extensibility-Editor-IEditable{``0}- 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch.GetOrCreateEditor``1(Microsoft.VisualStudio.Extensibility.Editor.IEditable{``0})') to ensure
that only one instance is created per [IEditBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditBatch 'Microsoft.VisualStudio.Extensibility.Editor.IEditBatch').

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService'></a>
## IEditorHostService `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Rehydrates Editor RPC contracts into thick objects.

##### Remarks

Extensions should rarely need to interact with this service. Rather, it's merely
supporting infrastructure for the frameworks composing the Visual Studio Extensibility
system.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateActiveTextViewAsync-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},System-Threading-CancellationToken-'></a>
### CreateActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Creates a new [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') from the properties contained in `clientContext`.

##### Returns

A [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') thick object that can be used to interact with the editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}') | UI properties, including document version (Microsoft.VisualStudio.Extensibility.Framework.IClientContext as dictionary). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the creation action. |

##### Remarks

This overload is meant primarily for creating [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot')s based on properties captured during
command invocation.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract,System-Threading-CancellationToken-'></a>
### CreatePositionAsync(textDocumentPosition,cancellationToken) `method`

##### Summary

Creates a new [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') from a serializable [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract')
RPC contract and other version metadata.

##### Returns

A [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocumentPosition | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract') | The [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract') to realize into [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Document'). Since this is potentially expensive, it's recommended that you only
create [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract,System-Threading-CancellationToken-'></a>
### CreatePositionAsync(documentUri,version,position,cancellationToken) `method`

##### Summary

Creates a new [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') from a serializable [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') RPC contract and other version
metadata.

##### Returns

A [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version number to create the span on. |
| position | [Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') | The [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') to realize into a [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.Document'). Since this is potentially expensive, it's recommend that you only
create [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract,System-Threading-CancellationToken-'></a>
### CreateSpanAsync(range,cancellationToken) `method`

##### Summary

Creates a new [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') from a serializable [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') RPC contract and other version
metadata.

##### Returns

A [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') | The [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') to realize into a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Document'). Since this is potentially expensive, it's recommended that you only
create [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-Threading-CancellationToken-'></a>
### CreateSpanAsync(documentUri,version,range,cancellationToken) `method`

##### Summary

Creates a new [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') from a serializable [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') RPC contract and other version
metadata.

##### Returns

A [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version number to create the span on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | The [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') to realize into a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Document 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.Document'). Since this is potentially expensive, it's recommended that you only
create [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Threading-CancellationToken-'></a>
### CreateTextDocumentAsync(textDocument,cancellationToken) `method`

##### Summary

Creates a new [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') from a serializable [TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') RPC contract.

##### Returns

An [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') thick object that can be used to interact with the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | A serializable [TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') RPC contract. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextViewAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-Threading-CancellationToken-'></a>
### CreateTextViewAsync(textView,cancellationToken) `method`

##### Summary

Creates a new [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') from a serializable [TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') RPC contract.

##### Returns

An [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') thick object that can be used to interact with the editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textView | [Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') | A serializable [TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') RPC contract. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1'></a>
## IEditorOption\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Base class for declaring a text view option.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1-Name'></a>
### Name `property`

##### Summary

Gets the option name.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorOption`1-GetValue-Newtonsoft-Json-Linq-JToken-'></a>
### GetValue(jsonToken) `method`

##### Summary

Converts a JToken to the option value type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonToken | [Newtonsoft.Json.Linq.JToken](#T-Newtonsoft-Json-Linq-JToken 'Newtonsoft.Json.Linq.JToken') | JsonToken retrieved from editor option APIs. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService'></a>
## IEditorOptionsService `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

This is a private brokered service running in the main VS process that provides access to text view options.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-GetTextDocumentOptionValueAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-String,System-Threading-CancellationToken-'></a>
### GetTextDocumentOptionValueAsync(document,optionName,cancellationToken) `method`

##### Summary

Gets the JToken representation of an option value scoped to the given text document.

##### Returns

a JToken instance if option is defined and readable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | Document contract that defines the scope for the option. |
| optionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when option is not defined. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-GetTextViewOptionValueAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-String,System-Threading-CancellationToken-'></a>
### GetTextViewOptionValueAsync(textView,optionName,cancellationToken) `method`

##### Summary

Gets the JToken representation of an option value scoped to the given text view.

##### Returns

a JToken instance if option is defined and readable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textView | [Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') | Text view contract that defines the scope for the option. |
| optionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when option is not defined. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-SubscribeToTextDocumentOptionChangesAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs},Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-String,System-Threading-CancellationToken-'></a>
### SubscribeToTextDocumentOptionChangesAsync(observer,document,optionName,cancellationToken) `method`

##### Summary

Subscribe to changes for a given option name in scope of the document contract using document uri.
The subscription is intended to live for the lifetime of the document.

##### Returns

a disposable object for lifetime of the subscription.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| observer | [System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver 'System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs}') | Observer for option changes. |
| document | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | Document contract that defines the scope for the option. |
| optionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-IEditorOptionsService-SubscribeToTextViewOptionChangesAsync-System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-EditorOptionChangedArgs},Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract,System-String,System-Threading-CancellationToken-'></a>
### SubscribeToTextViewOptionChangesAsync(observer,textView,optionName,cancellationToken) `method`

##### Summary

Subscribe to changes for a given option name in scope of the text view.
The subscription is intended to live for the lifetime of the text view.

##### Returns

a disposable object for lifetime of the subscription.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| observer | [System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver 'System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.EditorOptionChangedArgs}') | Observer for option changes. |
| textView | [Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') | Text view contract that defines the scope for the option. |
| optionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor'></a>
## ITextDocumentEditor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Exposes methods for changing an immutable [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') instance.

##### Remarks

You can acquire an instance of [ITextDocumentEditor](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor') within the function
passed to
EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken)

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document'></a>
### Document `property`

##### Summary

The specific version of the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') that the edit(s)
will be applied to, unless otherwise specified as part of a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange')
or [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') parameter.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Delete-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### Delete(range) `method`

##### Summary

Deletes the specified `range` of text from the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') of text to delete. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Insert-System-Int32,System-String-'></a>
### Insert(position,text) `method`

##### Summary

Inserts the specified text at the specified position in the
document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position to start inserting. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to insert. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Reload'></a>
### Reload() `method`

##### Summary

Reloads the document from disk.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Rename-System-String-'></a>
### Rename(newFilePath) `method`

##### Summary

Renames [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to `newFilePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Replace-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String-'></a>
### Replace(replaceRange,replaceWith) `method`

##### Summary

Replaces the text within `replaceRange` with
`replaceWith`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceRange | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') of text to replace. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') of text to insert. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Save'></a>
### Save() `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to disk.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveAs-System-String,System-Boolean-'></a>
### SaveAs(filePath,overwrite) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to disk with the new `filePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveAs-System-String,System-Boolean,System-Boolean-'></a>
### SaveAs(filePath,overwrite,createFolder) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to disk with the new `filePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |
| createFolder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, creates the destination folder, if it does not yet exist. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveCopy-System-String,System-Boolean-'></a>
### SaveCopy(filePath,overwrite) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to disk with the new `filePath`.
Does not update the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the underlying document, as used by subsequent [Save](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Save 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Save')s.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-SaveCopy-System-String,System-Boolean,System-Boolean-'></a>
### SaveCopy(filePath,overwrite,createFolder) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Document 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Document') to disk with the new `filePath`.
Does not update the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the underlying document, as used by subsequent [Save](#M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentEditor-Save 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentEditor.Save')s.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |
| createFolder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, creates the destination folder, if it does not yet exist. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot'></a>
## ITextDocumentSnapshot `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Provides read access to an immutable version of a document in the file system,
in memory in this process, or remoted from the host Visual Studio.

##### Remarks

[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') represents a document at a point in time and does not
change. Most IDE features will be invoked with an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') with
the state of the document when the feature was invoked.

Some advanced scenarios may benefit from caching results computed against previous
[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') versions. To facilitate such caching, [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
supports 'translating' positions and ranges on a document between versions using
[TranslateTo](#M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.TextRange.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode)') and
[TranslateTo](#M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot,Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode)'), respectively.

[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') is not directly mutable. Any changes must be requested
via EditorExtensibility.EditAsync(Action<IEditBatch>, System.Threading.CancellationToken).

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-IsDirty'></a>
### IsDirty `property`

##### Summary

Determines whether the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') is dirty.

##### Remarks

If `true`, the contents of [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') have
changed since the file was last loaded or saved. If `false`, the contents of [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') have
not changed since the file was last loaded or saved.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets a single character at the specified position.

##### Returns

The character at `position`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the character. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `position` is less than zero or greater than or equal to the length of the document. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Length'></a>
### Length `property`

##### Summary

Gets the number of UTF-16 characters contained in the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Lines'></a>
### Lines `property`

##### Summary

Gets a collection of lines in this version of the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object to a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Text'></a>
### Text `property`

##### Summary

Gets a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') for the current text of the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-Uri'></a>
### Uri `property`

##### Summary

The Uri of the file. Most frequently the name and path of the file on disk.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetEditorOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0},System-Threading-CancellationToken-'></a>
### GetEditorOptionValueAsync\`\`1(option,cancellationToken) `method`

##### Summary

Gets an editor option value based on the current text document scope.

##### Returns

This method returns either:
- the current value of option.
- the defined default value if option is defined but not set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| option | [Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0} 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{``0}') | Option identifier. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the option value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Throw when option is not set in this scope. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetLineFromPosition-System-Int32-'></a>
### GetLineFromPosition(position) `method`

##### Summary

Gets an [ITextDocumentSnapshotLine](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine') for a line at the given position.

##### Returns

A non-null [ITextDocumentSnapshotLine](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `position` is less than zero or greater than length of line. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-GetLineNumberFromPosition-System-Int32-'></a>
### GetLineNumberFromPosition() `method`

##### Summary

Gets the number of the line that contains the character at the specified position.

##### Returns

The line number of the line in which `position` lies.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `position` is less than zero or greater than Length/>. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-TranslatePositionTo-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-'></a>
### TranslatePositionTo(position,trackingMode) `method`

##### Summary

Translates a [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') forward or backward in time to this [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')'s version.

##### Returns

A [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | Position to translate |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode') | The [TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | This [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') does not refer to the same underlying text document as this [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot-TranslateRangeTo-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-'></a>
### TranslateRangeTo(range,trackingMode) `method`

##### Summary

Translates a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') forward or backward in time to this [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')'s version.

##### Returns

A [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | range to translate |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode') | The [TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | This [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') does not refer to the same underlying text document as this [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine'></a>
## ITextDocumentSnapshotLine `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Provides read access to a line in an immutable version of a document in the
file system, in memory in this Service Hub extension, or remoted from the host
Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-Document'></a>
### Document `property`

##### Summary

The immutable document version in which this line appears.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-LineBreakLength'></a>
### LineBreakLength `property`

##### Summary

Length of line break characters (always falls in the range [0..2]).

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-LineNumber'></a>
### LineNumber `property`

##### Summary

The 0-origin line number of the line.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-Text'></a>
### Text `property`

##### Summary

Gets a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') for the line, excluding any line break characters.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-TextIncludingLineBreak'></a>
### TextIncludingLineBreak `property`

##### Summary

Gets a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') for the line, including any line break characters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine-GetLineBreakText'></a>
### GetLineBreakText() `method`

##### Summary

The string consisting of the line break characters (if any) at the
end of the line. Has zero length for the last line in the buffer.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract'></a>
## ITextEditorSynchronizationServiceContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

This is a private brokered service running in the main VS process and representing “source of truth” regarding text document content.
It provides callers with document content of specific versions and can provide updates as documents are changing.
It also applies changes submitted by extensions to documents and text views.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyEditAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract,System-Threading-CancellationToken-'></a>
### ApplyEditAsync(edit,cancellationToken) `method`

##### Summary

Applies a set of edits to editable objects such as [TextViewContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewContract') and [TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| edit | [Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundEditContract') | Describes the set of changes to apply. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the in-progress request. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-SubscribeToDocumentChangesAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract},System-Threading-CancellationToken-'></a>
### SubscribeToDocumentChangesAsync(textDocument,observer,cancellationToken) `method`

##### Summary

Subscribes `observer` to edits from the specified explicitly-versioned document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | The explicitly versioned document to subscribe to updates from. |
| observer | [System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver 'System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract}') | The object that will be notified when the document changes. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the subscription request. |

##### Remarks

Document changes are sent as a [TextDocumentEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract') with several optional parameters
and are guaranteed to be sent in order. Observers should be prepared to handle any combination of
present/missing parameters and should support state changes that come in one message or a batch
of several.

Documents open in a text view in the IDE will be automatically unsubscribed when closed and then
[OnCompleted](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver`1.OnCompleted 'System.IObserver`1.OnCompleted') will be called.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewEditor'></a>
## ITextViewEditor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Exposes methods for changing an immutable [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') instance.

##### Remarks

You can acquire an instance of [ITextViewEditor](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewEditor 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewEditor') within the function
passed to
EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken)

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot'></a>
## ITextViewSnapshot `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Provides immutable, read access to properties of a text editor remoted from
the host Visual Studio.

##### Remarks

[ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') represents an editor at a point in time and does not
change. Most IDE features will be invoked with an [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') with
the state of the editor when the feature was invoked.

[ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') is not directly mutable. Any changes must be requested
via EditorExtensibility.EditAsync(System.Action<IEditBatch>, System.Threading.CancellationToken)

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-FilePath'></a>
### FilePath `property`

##### Summary

The [LocalPath](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri.LocalPath 'System.Uri.LocalPath') of this document's Uri.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object to a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Selection'></a>
### Selection `property`

##### Summary

The primary selection on this text view. Shorthand for this.Selections[0].

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Selections'></a>
### Selections `property`

##### Summary

The selections in this text view. The primary selection is always at index 0.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-Uri'></a>
### Uri `property`

##### Summary

The Uri of the document. Most frequently the name and path of the file on disk.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0},System-Threading-CancellationToken-'></a>
### GetOptionValueAsync\`\`1(option,cancellationToken) `method`

##### Summary

Gets an editor option value based on the scope of text document in this view.

##### Returns

This method returns either:
- the current value of option.
- the defined default value if option is defined but not set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| option | [Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption{``0} 'Microsoft.VisualStudio.Extensibility.Editor.TextDocumentOption{``0}') | Option identifier. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the option value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Throw when option is not set in this scope. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetOptionValueAsync``1-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption{``0},System-Threading-CancellationToken-'></a>
### GetOptionValueAsync\`\`1(option,cancellationToken) `method`

##### Summary

Gets an editor option value based on the current text view scope.

##### Returns

This method returns either:
- the current value of option.
- the defined default value if option is defined but not set..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| option | [Microsoft.VisualStudio.Extensibility.Editor.TextViewOption{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption{``0} 'Microsoft.VisualStudio.Extensibility.Editor.TextViewOption{``0}') | Option identifier. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the option value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Throw when option is not set in this scope. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot-GetTextDocumentAsync-System-Threading-CancellationToken-'></a>
### GetTextDocumentAsync() `method`

##### Summary

The document associated with this text editor. The document will be the same for the entire lifetime
of this text editor.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories'></a>
## KnownClientContextCategories `type`

##### Namespace

Microsoft.VisualStudio.Text.Editor

##### Summary

Known names for common context categories to be used with internal client context service. Use nameof(value) when querying for these categories

<a name='F-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories-Editor'></a>
### Editor `constants`

##### Summary

Editor category that includes information such as document version, selections etc.

<a name='T-Microsoft-VisualStudio-Text-Editor-KnownEditorClientContextCategoryProperties'></a>
## KnownEditorClientContextCategoryProperties `type`

##### Namespace

Microsoft.VisualStudio.Text.Editor

##### Summary

Known properties for Editor context category to be used with internal client context service. Use nameof(value) when querying for these properties

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract'></a>
## ReloadContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for requesting a document be reloaded from disk.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-'></a>
### #ctor(textDocument) `constructor`

##### Summary

Initializes a new instance of [ReloadContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | The document to reload. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-TextDocument'></a>
### TextDocument `property`

##### Summary

The document to reload.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract'></a>
## SaveContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

An RPC contract for requesting an open document be saved, copied, or moved on disk.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Uri,System-Boolean,System-Boolean,System-Boolean-'></a>
### #ctor(before,after,isCopy,allowOverwrite,allowCreateFolder) `constructor`

##### Summary

Initializes a new instance of [SaveContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| before | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document to save. |
| after | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The new [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. If `null`, assumes a 'save' operation. |
| isCopy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `before` is not the same as `after` and `isCopy` is true,
the file is saved as a copy and the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')'s [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') is not changed. |
| allowOverwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Allows overwriting the target file. |
| allowCreateFolder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Allows creating the target file's directory, if it doesn't yet exist. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-After'></a>
### After `property`

##### Summary

The new document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri'). If the same as [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.Before'),
operation will be considered a 'Save' rather than a rename or copy.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowCreateFolder'></a>
### AllowCreateFolder `property`

##### Summary

Enables creating the destination folder, if it doesn't yet exist.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowOverwrite'></a>
### AllowOverwrite `property`

##### Summary

Enables overwriting existing files, if [IsCopy](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-IsCopy 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.IsCopy') is true.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-Before'></a>
### Before `property`

##### Summary

The explicitly versioned document to save.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-IsCopy'></a>
### IsCopy `property`

##### Summary

Indicates that [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.After') is a copy of the document and the
document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') should not be changed to point at the new
doc.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Selection'></a>
## Selection `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Manages the insertion, anchor, and active positions for a single caret and its associated
selection.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Selection-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-Boolean-'></a>
### #ctor(extent,isReversed) `constructor`

##### Summary

Instantiates a new Selection with the given extent. Anchor and active points are defined by isReversed, and the
insertion point is located at the active point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extent | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The span that the selection covers. |
| isReversed | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True implies that [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition') comes before [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition').
The [InsertionPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-InsertionPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.InsertionPosition') is set to the [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition'). |

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Selection-Invalid'></a>
### Invalid `constants`

##### Summary

A static instance of a selection that is invalid and can be used to check for instantiation.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition'></a>
### ActivePosition `property`

##### Summary

Gets the location of the movable selection endpoint, meaning if a user were to hold shift and click,
this point would be changed to the location of the click. If this is an empty selection, this will be at the
[InsertionPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-InsertionPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.InsertionPosition').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition'></a>
### AnchorPosition `property`

##### Summary

Gets the location of the fixed selection endpoint, meaning if a user were to hold shift and click,
this point would remain where it is. If this is an empty selection, this will be at the
[InsertionPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-InsertionPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.InsertionPosition').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-End'></a>
### End `property`

##### Summary

Returns the larger of [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition') and [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-Extent'></a>
### Extent `property`

##### Summary

Returns the span from [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-Start 'Microsoft.VisualStudio.Extensibility.Editor.Selection.Start') to [End](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-End 'Microsoft.VisualStudio.Extensibility.Editor.Selection.End').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-InsertionPosition'></a>
### InsertionPosition `property`

##### Summary

Gets the location where a caret should be rendered and edits performed.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-IsEmpty'></a>
### IsEmpty `property`

##### Summary

True if [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition') equals [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition'). False otherwise.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-IsReversed'></a>
### IsReversed `property`

##### Summary

True if [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition') is later in the document than [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition'). False otherwise.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Selection-Start'></a>
### Start `property`

##### Summary

Returns the smaller of [ActivePosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-ActivePosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.ActivePosition') and [AnchorPosition](#P-Microsoft-VisualStudio-Extensibility-Editor-Selection-AnchorPosition 'Microsoft.VisualStudio.Extensibility.Editor.Selection.AnchorPosition').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Selection-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether this selection is the same as other selection.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Selection-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Selection-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Selection,Microsoft-VisualStudio-Extensibility-Editor-Selection-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.Editor.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-Selection 'Microsoft.VisualStudio.Extensibility.Editor.Selection') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.Editor.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-Selection 'Microsoft.VisualStudio.Extensibility.Editor.Selection') | Right item. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Selection-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Selection,Microsoft-VisualStudio-Extensibility-Editor-Selection-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.Editor.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-Selection 'Microsoft.VisualStudio.Extensibility.Editor.Selection') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.Editor.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-Selection 'Microsoft.VisualStudio.Extensibility.Editor.Selection') | Right item. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract'></a>
## SelectionEditContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a single change to selections of a specific [TextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionEditContract.TextView')
version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract-Selections'></a>
### Selections `property`

##### Summary

New selections to be applied.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionEditContract-TextView'></a>
### TextView `property`

##### Summary

The explicitly versioned document the change should be applied to.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract'></a>
## TextDocumentContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') in a particular version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-Uri'></a>
### Uri `property`

##### Summary

The [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract.Uri') of the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract-Version'></a>
### Version `property`

##### Summary

The version of the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract'></a>
## TextDocumentEditContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract describing one or more edits atomically applied to
an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract[]-'></a>
### #ctor(document,edits) `constructor`

##### Summary

Initializes a new instance of [TextDocumentEditContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') |  |
| edits | [Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract[]](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract[] 'Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract[]') |  |

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-Document'></a>
### Document `property`

##### Summary

The explicitly versioned document the change should be applied to.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditContract-Edits'></a>
### Edits `property`

##### Summary

The individual text changes.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract'></a>
## TextDocumentEditResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing [TextDocumentEditResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentEditResponseContract').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-After'></a>
### After `property`

##### Summary

The explicitly versioned [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') after the edit was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-Before'></a>
### Before `property`

##### Summary

The explicitly versioned [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') before the edit was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentEditResponseContract-EditResult'></a>
### EditResult `property`

##### Summary

The result of the operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') or a failure code.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract'></a>
## TextDocumentMetadataContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Immutable object holding metadata for a specific [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
version sent from the document owner.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-IsDirty'></a>
### IsDirty `property`

##### Summary

Indicates that the document has unsaved changes.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Uri'></a>
### Uri `property`

##### Summary

The document uri.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Version'></a>
### Version `property`

##### Summary

The version number of the document, in the host process's versioning
scheme. The host process is usually Visual Studio.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Merge-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-'></a>
### Merge() `method`

##### Summary

Merges two instances of [TextDocumentMetadataContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract'), giving
preference to `other`'s values.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption`1'></a>
## TextDocumentOption\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Base class for declaring a text document option.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextDocumentOption`1-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Creates an editor text document option with the provided option name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name in scope of a text document. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract'></a>
## TextDocumentSynchronizationContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract used for synchronizing text document state between Visual Studio and
extension host's mirror of the text document in OOP extensions.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Edits'></a>
### Edits `property`

##### Summary

The individual text changes.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Metadata'></a>
### Metadata `property`

##### Summary

Any metadata changes.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract'></a>
## TextEditContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a single change to a specific [TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract')
version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract-Range'></a>
### Range `property`

##### Summary

The section of text to delete and replace with [Text](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract-Text 'Microsoft.VisualStudio.RpcContracts.Editor.TextEditContract.Text').
Can be zero-length if no text should be deleted.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextEditContract-Text'></a>
### Text `property`

##### Summary

The new text to insert in the document.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions'></a>
## TextExtensions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-CopyToString-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### CopyToString() `method`

##### Summary

Copies the [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') to a string.

##### Returns

A non-null string.

##### Parameters

This method has no parameters.

##### Remarks

Copying text from a large range to a string is very expensive and should be avoided.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-EndsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean-'></a>
### EndsWith() `method`

##### Summary

Determines whether this range ends with the given text.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-IndexOf-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean-'></a>
### IndexOf() `method`

##### Summary

Determines the position of the given text in the range. Returns -1 if the text can't be found.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-LastIndexOf-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean-'></a>
### LastIndexOf() `method`

##### Summary

Determines the last position of the given text in the range. Returns -1 if the text can't be found.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextExtensions-StartsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange,System-String,System-Boolean-'></a>
### StartsWith() `method`

##### Summary

Determines whether this range starts with the given text.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition'></a>
## TextPosition `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

An immutable text position in a particular [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version.

##### Remarks

[VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract') is one of three closely related concepts:
- [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'): Thick object representing a range of text in a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').
  This type should be used in all code within the same process.
- [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract'): A serializable representation of [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract'): A serialiable representation of [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  range to be rehydrated into [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Int32-'></a>
### #ctor(document,position) `constructor`

##### Summary

Initializes a new instance of a [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') with respect to a particular [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the position. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Document'></a>
### Document `property`

##### Summary

Gets the [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') to which this snapshot position refers.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Offset'></a>
### Offset `property`

##### Summary

Gets the position of the position as a numeric offset from the start of the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Add-System-Int32-'></a>
### Add(offset) `method`

##### Summary

Creates a new snapshot position at the specified offset from this position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new position is less than zero or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-CompareTo-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### CompareTo(other) `method`

##### Summary

Determines whether this snapshot is the same as a second snapshot position.

##### Returns

A negative integer if the position of this snapshot position occurs before the second snapshot position, 
a positive integer if the position of this snapshot position occurs before the second snapshot position, and 
zero if the positions are the same.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The snapshot position to which to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Difference-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### Difference(other) `method`

##### Summary

Computes the offset between this snapshot position and another snapshot position.

##### Returns

The offset between the two positions, equivalent to other.Offset -
this.Offset.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The position from which to compute the offset. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two positions do not belong to the same
snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether this snapshot position is the same as a second snapshot position.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetChar'></a>
### GetChar() `method`

##### Summary

Gets the character at the position of this snapshot position.

##### Returns

The character at the position of this snapshot position.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | if the position of this position is equal to the length of the snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetContainingLine'></a>
### GetContainingLine() `method`

##### Summary

The [ITextDocumentSnapshotLine](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshotLine 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshotLine') containing this snapshot position.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-Subtract-System-Int32-'></a>
### Subtract(offset) `method`

##### Summary

Creates a new snapshot position at the specified negative offset from this position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new position is less than zero or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-'></a>
### TranslateTo(targetDocumentVersion,trackingMode) `method`

##### Summary

Translates this [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') to an older or newer [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version.

##### Returns

A [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetDocumentVersion | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | The document version to which to translate. |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode') | The [TextPositionTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextPositionTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `targetDocumentVersion` is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `targetDocumentVersion` does not refer to the same underlying text document as this [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Addition-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32-'></a>
### op_Addition(position,offset) `method`

##### Summary

Increments the position of a snapshot position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The position from which to calculate the new position. |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new position is less than zero
or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### op_Equality() `method`

##### Summary

Determines whether this snapshot position is the same as a second snapshot position.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_GreaterThan-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### op_GreaterThan() `method`

##### Summary

Determines whether the position of one snapshot position is greater than the position of a second snapshot position.

##### Returns

`true` if the first position is greater than the second position, otherwise `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two positions do not belong to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') to [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-~System-Int32'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the snapshot position to an integer equal to the position of the snapshot position in the snapshot.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### op_Inequality() `method`

##### Summary

Determines whether this snapshot position is different from a second snapshot position.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_LessThan-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### op_LessThan() `method`

##### Summary

Determine if the position of the left position is less than the position of the right position.

##### Returns

`true` if left.Offset is greater than right.Offset, otherwise `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two positions do not belong to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32-'></a>
### op_Subtraction(position,offset) `method`

##### Summary

Decrements the position of a snapshot position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The position from which to calculate the new position. |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new position is less than zero
or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### op_Subtraction(start,other) `method`

##### Summary

Computes the offset between two [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') objects.

##### Returns

The offset between the two positions, equivalent to start.Offset -
other.Offset.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The starting position. |
| other | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The position from which to compute the offset. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two positions do not belong to the same
snapshot. |

##### Remarks

The following should always be true:
start == other + (start - other).

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract'></a>
## TextPositionContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a position in a document version.

##### Remarks

[TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') is one of three closely related concepts:
- [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'): Thick object representing a range of text in a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').
  This type should be used in all code within the same process.
- [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract'): A serializable representation of [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract'): A serialiable representation of [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') that can be sent between
  processes over RPC. As opposed to [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  range to be rehydrated into [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-#ctor-System-Int32,System-Int32-'></a>
### #ctor(line,column) `constructor`

##### Summary

Initializes a new instance of the [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the position. |
| column | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The column (0-based) of the position. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-Column'></a>
### Column `property`

##### Summary

Gets the column (0-based) of the position.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract-Line'></a>
### Line `property`

##### Summary

Gets the line (0-based) of the position.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode'></a>
## TextPositionTrackingMode `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Represents tracking modes for [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition')s across versions of an [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-Negative'></a>
### Negative `constants`

##### Summary

With this setting, a position tracks toward the beginning of the document, 
so that an insertion at the current position leaves the position unaffected.  If a
replacement contains the position, it will end up at the beginning of the replacement text.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextPositionTrackingMode-Positive'></a>
### Positive `constants`

##### Summary

With this setting, a position tracks toward the end of the document, so that an
insertion at the current position pushes the position to the end of the inserted text. 
If a replacement contains the position, it will end up at the end of the replacement text.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextRange'></a>
## TextRange `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

An immutable text range in a particular [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version.

##### Remarks

[VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') is one of three closely related concepts:
- [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'): Thick object representing a range of text in a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').
  This type should be used in all code within the same process.

- [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract'): A serializable representation of [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.

- [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range'): A serializable representation of [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of range equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  range to be rehydrated into [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,System-Int32,System-Int32-'></a>
### #ctor(document,start,length) `constructor`

##### Summary

Initializes a new instance of a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') with the specified document, start point, and length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | The text document version on which to base the range. |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting point of the range. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `document` is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `start` is negative or greater than `document`.Length, or
`length` is negative or `start` + `length` is greater than
`document`.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### #ctor(start,end) `constructor`

##### Summary

Initializes a new instance of a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') from two [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') objects.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The start position. |
| end | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The end position, which must be from the same [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot')
as the start point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The positions belong to different 
[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') objects. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The end point comes before the start
point. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-#ctor-Microsoft-VisualStudio-Extensibility-Editor-TextPosition,System-Int32-'></a>
### #ctor(start,length) `constructor`

##### Summary

Initializes a new instance of a [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') from an existing [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') and a specified length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The starting position. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `length` is negative or 
`start` + `length` is greater than the length of the snapshot. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Document'></a>
### Document `property`

##### Summary

The [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') to which this snapshot range refers.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-End'></a>
### End `property`

##### Summary

Gets the end of the snapshot range. The range is open-ended on the right side, which is to say
that Start + Length = End.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-IsEmpty'></a>
### IsEmpty `property`

##### Summary

Determines whether or not this range is empty.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets a single character at the specified position.

##### Returns

The character at `position`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the character. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `position` is less than zero or greater than or equal to the length of the text. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Length'></a>
### Length `property`

##### Summary

Gets the length of the range, which is always non-negative.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Start'></a>
### Start `property`

##### Summary

Gets the starting index of the snapshot range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-System-Int32-'></a>
### Contains(position) `method`

##### Summary

Determines whether the position lies within the range.

##### Returns

`true` if the position is greater than or equal to parameter range.Start and strictly less than parameter range.End, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-Microsoft-VisualStudio-Extensibility-Editor-TextPosition-'></a>
### Contains(position) `method`

##### Summary

Determines whether a given [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') lies within the range.

##### Returns

`true` if the position is greater than or equal to parameter range.Start and strictly less than parameter range.End, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.VisualStudio.Extensibility.Editor.TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') | The point to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Contains-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### Contains(range) `method`

##### Summary

Determines whether `range` falls completely within this range.

##### Returns

`true` if the specified range falls completely within this range, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The range to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-CopyTo-System-Span{System-Char}-'></a>
### CopyTo(destination) `method`

##### Summary

Copy this text to the specified [Span\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Span`1 'System.Span`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destination | [System.Span{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Span 'System.Span{System.Char}') | The destination [Span\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Span`1 'System.Span`1'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Equals-System-String,System-Boolean-'></a>
### Equals() `method`

##### Summary

Determines whether the text of this range is equivalent to a string.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether two snapshot ranges are the same.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Intersection-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### Intersection(range) `method`

##### Summary

Computes the intersection with the given [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'), or null if there is no intersection.

##### Returns

The intersection of the ranges, or null if the intersection is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The range to check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `range` does not refer to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-IntersectsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### IntersectsWith(range) `method`

##### Summary

Determines whether `range` intersects this range. Two ranges are considered to 
intersect if they have positions in common, or the end of one range 
coincides with the start of the other range, and neither is empty.

##### Returns

`true` if the ranges intersect, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The range to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Overlap-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### Overlap(range) `method`

##### Summary

Returns the overlap with the given [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'), or null if there is no overlap.

##### Returns

The overlap of the ranges, or null if the overlap is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The range to check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `range` does not refer to the same
[ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') as this snapshot range. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-OverlapsWith-Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### OverlapsWith(range) `method`

##### Summary

Determines whether `range` overlaps this range. 
Two ranges are considered to overlap if they have positions in common and are not empty. Empty ranges do not overlap with any other range.

##### Returns

`true` if the ranges overlap, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.Extensibility.Editor.TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') | The range to check for overlap. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-Slice-System-Int32,System-Int32-'></a>
### Slice(start,length) `method`

##### Summary

Create a slice of the current [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange').

##### Returns

A slice that consists of `length` characters from the current instance starting at index `start`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index at which to begin this slice. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the slice. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot,Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-'></a>
### TranslateTo(targetDocumentVersion,rangeTrackingMode) `method`

##### Summary

Translates this [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') to an older or newer [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') version.

##### Returns

A new snapshot range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetDocumentVersion | [Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') | The document version to which to translate. |
| rangeTrackingMode | [Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode') | The [TextRangeTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.TextRangeTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `targetDocumentVersion` is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `targetDocumentVersion` does not refer to the same underlying text document as this [TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### op_Equality() `method`

##### Summary

Determines whether two snapshot ranges are the same.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-TextRange-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') to [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextRange-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-TextRange,Microsoft-VisualStudio-Extensibility-Editor-TextRange-'></a>
### op_Inequality() `method`

##### Summary

Determines whether two snapshot ranges are different.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode'></a>
## TextRangeTrackingMode `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Represents tracking modes for [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') objects.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-Custom'></a>
### Custom `constants`

##### Summary

Custom client-determined tracking behavior.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeExclusive'></a>
### EdgeExclusive `constants`

##### Summary

The leading edge of the range is positive tracking (insertions push the current position towards the end) 
and the trailing edge is negative tracking (insertions push the current position towards the start).
The range will not expand when text changes occur at the range boundaries. For example,
if an EdgeExclusive range has Start position 3, and a single character is inserted at position 3,
the range will then have Start position 4 and its length will be unchanged.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeInclusive'></a>
### EdgeInclusive `constants`

##### Summary

The leading edge of the range is negative tracking (insertions push the current position toward the start) 
and the trailing edge is positive tracking (insertions push the current position toward the end).
The range will expand when text changes occur at the range boundaries. For example,
if an EdgeInclusive range has Start position 3, and a single character is inserted at position 3,
the range will then have Start position 3 and its length will be increased by one.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgeNegative'></a>
### EdgeNegative `constants`

##### Summary

Both edges of the range are negative tracking (insertions push the current position toward the start).

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextRangeTrackingMode-EdgePositive'></a>
### EdgePositive `constants`

##### Summary

Both edges of the range are positive tracking (insertions push the current position toward the end).

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract'></a>
## TextViewContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing a [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') in a particular state and version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract-Document'></a>
### Document `property`

##### Summary

The underlying [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot') properties.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewContract-Id'></a>
### Id `property`

##### Summary

Unique id of the text view.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract'></a>
## TextViewEditResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing TextViewEditResponse.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-After'></a>
### After `property`

##### Summary

The explicitly versioned [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') after the edit was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-Before'></a>
### Before `property`

##### Summary

The explicitly versioned [ITextViewSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot') before the edit was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewEditResponseContract-EditResult'></a>
### EditResult `property`

##### Summary

The result of the operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-EditResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.EditResult.Success') or a failure code.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption`1'></a>
## TextViewOption\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Base class for declaring a text view option.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewOption`1-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Creates an editor text view option with the provided option name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Option name in scope of a text view. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract'></a>
## VersionedTextDocumentPositionContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a explicitly versioned position in a document.

##### Remarks

[TextPosition](#T-Microsoft-VisualStudio-Extensibility-Editor-TextPosition 'Microsoft.VisualStudio.Extensibility.Editor.TextPosition') is one of three closely related concepts:
- Position: Thick object representing a range of text in an ITextDocument.
  This type should be used in all code within the same process.
- [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract'): A serializable representation of [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract'): A serialiable representation of [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  range to be rehydrated into TextRange by IEditorHostService.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Int32,System-Int32-'></a>
### #ctor(textDocument,line,column) `constructor`

##### Summary

Initializes a new instance of the [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | The text document this position appears on. |
| line | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the position. |
| column | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The column (0-based) of the position. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Column'></a>
### Column `property`

##### Summary

Gets the column (0-based) of the position.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Document'></a>
### Document `property`

##### Summary

Gets a reference to the information describing the underlying document.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-Line'></a>
### Line `property`

##### Summary

Gets the line (0-based) of the position.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract-~Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [VersionedTextDocumentPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPositionContract') to [TextPositionContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-TextPositionContract 'Microsoft.VisualStudio.RpcContracts.Utilities.TextPositionContract').

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract'></a>
## VersionedTextDocumentRangeContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a explicitly versioned range of text in a document.

##### Remarks

[VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') is one of three closely related concepts:
- [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange'): Thick object representing a range of text in a [ITextDocumentSnapshot](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextDocumentSnapshot 'Microsoft.VisualStudio.Extensibility.Editor.ITextDocumentSnapshot').
  This type should be used in all code within the same process.
- [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract'): A serializable representation of [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range'): A serialiable representation of [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of range equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  range to be rehydrated into [TextRange](#T-Microsoft-VisualStudio-Extensibility-Editor-TextRange 'Microsoft.VisualStudio.Extensibility.Editor.TextRange') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract,System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### #ctor(textDocument,startLine,startColumn,endLine,endColumn) `constructor`

##### Summary

Initializes a new instance of the [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentContract') | The |
| startLine | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the start of the span. |
| startColumn | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset (0-based) offset from the start of `startLine` for the start of the span. |
| endLine | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the end of the span. |
| endColumn | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset (0-based) offset from the start of `endLine` for the end of the span. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-Document'></a>
### Document `property`

##### Summary

Gets a reference to the information describing the underlying document.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-EndColumn'></a>
### EndColumn `property`

##### Summary

Gets the offset (0-based) offset from the start of [EndLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-EndLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.EndLine') for the end of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-EndLine'></a>
### EndLine `property`

##### Summary

Gets the line (0-based) of the end of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-StartColumn'></a>
### StartColumn `property`

##### Summary

Gets the offset (0-based) offset from the start of [StartLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-StartLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract.StartLine') for the start of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-StartLine'></a>
### StartLine `property`

##### Summary

Gets the line (0-based) of the start of the span.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract-~Microsoft-VisualStudio-RpcContracts-Utilities-Range'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [VersionedTextDocumentRangeContract](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRangeContract 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRangeContract') to [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range').

##### Parameters

This method has no parameters.
