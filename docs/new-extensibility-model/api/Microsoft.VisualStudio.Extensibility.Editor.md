<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Editor

## Contents

- [AppliesToAttribute](#T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute')
  - [ContentType](#P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute-ContentType 'Microsoft.VisualStudio.Extensibility.Editor.AppliesToAttribute.ContentType')
- [CompoundMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract')
  - [Mutations](#P-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract-Mutations 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract.Mutations')
- [EditorContext](#T-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContext')
  - [ActiveTextViewId](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-ActiveTextViewId 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContext.ActiveTextViewId')
  - [TextDocuments](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-TextDocuments 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContext.TextDocuments')
  - [TextViews](#P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-TextViews 'Microsoft.VisualStudio.RpcContracts.Utilities.EditorContext.TextViews')
- [EditorServices](#T-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices 'Microsoft.VisualStudio.RpcContracts.Editor.EditorServices')
  - [TextEditorSynchronizationServiceDescriptor](#P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-TextEditorSynchronizationServiceDescriptor 'Microsoft.VisualStudio.RpcContracts.Editor.EditorServices.TextEditorSynchronizationServiceDescriptor')
- [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService')
  - [CreateActiveTextViewAsync(clientContext,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateActiveTextViewAsync(Microsoft.VisualStudio.Extensibility.Definitions.IClientContext,System.Threading.CancellationToken)')
  - [CreatePositionAsync(textDocumentPosition,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreatePositionAsync(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,System.Threading.CancellationToken)')
  - [CreatePositionAsync(documentUri,version,position,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Position,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreatePositionAsync(System.Uri,System.Int32,Microsoft.VisualStudio.RpcContracts.Utilities.Position,System.Threading.CancellationToken)')
  - [CreateSpanAsync(range,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateSpanAsync(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,System.Threading.CancellationToken)')
  - [CreateSpanAsync(documentUri,version,range,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateSpanAsync(System.Uri,System.Int32,Microsoft.VisualStudio.RpcContracts.Utilities.Range,System.Threading.CancellationToken)')
  - [CreateTextDocumentAsync(textDocument,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateTextDocumentAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,System.Threading.CancellationToken)')
  - [CreateTextViewAsync(textView,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextViewAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService.CreateTextViewAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextView,System.Threading.CancellationToken)')
- [IMutatableInternal\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatableInternal`1 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatableInternal`1')
- [IMutatable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable`1 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable`1')
- [IMutationBatchInternal](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutationBatchInternal 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutationBatchInternal')
  - [AddMutationRpcContract(rpcContract)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutationBatchInternal-AddMutationRpcContract-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutationBatchInternal.AddMutationRpcContract(Microsoft.VisualStudio.RpcContracts.Editor.MutationContractBase)')
- [IMutatorSource](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource')
  - [GetMutator\`\`1(mutatable)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource-GetMutator``1-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable{``0}- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource.GetMutator``1(Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable{``0})')
- [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
  - [IsDirty](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-IsDirty 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.IsDirty')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Item-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.Item(System.Int32)')
  - [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Length 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.Length')
  - [Lines](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Lines 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.Lines')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.RpcContract')
  - [Uri](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Uri 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.Uri')
  - [CopyTo(sourceIndex,destination,destinationIndex,count)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-CopyTo-System-Int32,System-Char[],System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.CopyTo(System.Int32,System.Char[],System.Int32,System.Int32)')
  - [GetLineFromPosition(position)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetLineFromPosition-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.GetLineFromPosition(System.Int32)')
  - [GetLineNumberFromPosition()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetLineNumberFromPosition-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.GetLineNumberFromPosition(System.Int32)')
  - [GetText(span)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.GetText(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [GetText(startIndex,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText-System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.GetText(System.Int32,System.Int32)')
  - [GetText()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.GetText')
  - [ToCharArray(startIndex,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-ToCharArray-System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.ToCharArray(System.Int32,System.Int32)')
  - [TranslatePositionTo(trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-TranslatePositionTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.TranslatePositionTo(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode)')
  - [TranslateSpanTo(trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-TranslateSpanTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.TranslateSpanTo(Microsoft.VisualStudio.Extensibility.Editor.Data.Span,Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode)')
- [ITextDocumentLine](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.Document')
  - [End](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-End 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.End')
  - [EndIncludingLineBreak](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-EndIncludingLineBreak 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.EndIncludingLineBreak')
  - [Extent](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Extent 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.Extent')
  - [ExtentIncludingLineBreak](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-ExtentIncludingLineBreak 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.ExtentIncludingLineBreak')
  - [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Length 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.Length')
  - [LengthIncludingLineBreak](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LengthIncludingLineBreak 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.LengthIncludingLineBreak')
  - [LineBreakLength](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LineBreakLength 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.LineBreakLength')
  - [LineNumber](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LineNumber 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.LineNumber')
  - [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Start 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.Start')
  - [GetLineBreakText()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetLineBreakText 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.GetLineBreakText')
  - [GetText()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetText 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.GetText')
  - [GetTextIncludingLineBreak()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetTextIncludingLineBreak 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine.GetTextIncludingLineBreak')
- [ITextDocumentMutator](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document')
  - [Delete(span)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Delete-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Delete(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [Insert(position,text)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Insert-System-Int32,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Insert(System.Int32,System.String)')
  - [Reload()](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Reload 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Reload')
  - [Rename(newFilePath)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Rename-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Rename(System.String)')
  - [Replace(replaceSpan,replaceWith)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Replace-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,System-String- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Replace(Microsoft.VisualStudio.Extensibility.Editor.Data.Span,System.String)')
  - [Save()](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Save 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Save')
  - [SaveAs(filePath,overwrite)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveAs-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.SaveAs(System.String,System.Boolean)')
  - [SaveAs(filePath,overwrite,createFolder)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveAs-System-String,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.SaveAs(System.String,System.Boolean,System.Boolean)')
  - [SaveCopy(filePath,overwrite)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveCopy-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.SaveCopy(System.String,System.Boolean)')
  - [SaveCopy(filePath,overwrite,createFolder)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveCopy-System-String,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.SaveCopy(System.String,System.Boolean,System.Boolean)')
- [ITextEditorSynchronizationServiceContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract')
  - [ApplyMutationAsync(edit,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyMutationAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyMutationAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract,System.Threading.CancellationToken)')
  - [SubscribeToDocumentChangesAsync(textDocument,observer,cancellationToken)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-SubscribeToDocumentChangesAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract},System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.SubscribeToDocumentChangesAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract},System.Threading.CancellationToken)')
- [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView.RpcContract')
  - [Selection](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView.Selection')
  - [Selections](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-Selections 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView.Selections')
  - [GetTextDocumentAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-GetTextDocumentAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView.GetTextDocumentAsync(System.Threading.CancellationToken)')
- [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener.TextViewChangedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs,System.Threading.CancellationToken)')
- [ITextViewChangedListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract')
  - [TextViewChangedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewChangedListenerContract-TextViewChangedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewChangedListenerContract.TextViewChangedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange,System.Threading.CancellationToken)')
- [ITextViewLifetimeListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener.TextViewClosedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,System.Threading.CancellationToken)')
  - [TextViewCreatedAsync()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewCreatedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewLifetimeListener.TextViewCreatedAsync(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,System.Threading.CancellationToken)')
- [ITextViewLifetimeListenerContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract')
  - [TextViewClosedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewClosedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract.TextViewClosedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextView,System.Threading.CancellationToken)')
  - [TextViewCreatedAsync()](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewCreatedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextViewLifetimeListenerContract.TextViewCreatedAsync(Microsoft.VisualStudio.RpcContracts.Editor.TextView,System.Threading.CancellationToken)')
- [ITextViewMutator](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextViewMutator 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextViewMutator')
- [KnownClientContextCategories](#T-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories 'Microsoft.VisualStudio.Text.Editor.KnownClientContextCategories')
  - [Editor](#F-Microsoft-VisualStudio-Text-Editor-KnownClientContextCategories-Editor 'Microsoft.VisualStudio.Text.Editor.KnownClientContextCategories.Editor')
- [KnownEditorClientContextCategoryProperties](#T-Microsoft-VisualStudio-Text-Editor-KnownEditorClientContextCategoryProperties 'Microsoft.VisualStudio.Text.Editor.KnownEditorClientContextCategoryProperties')
- [MutationBatch](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationBatch 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationBatch')
- [MutationContractBase](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase 'Microsoft.VisualStudio.RpcContracts.Editor.MutationContractBase')
- [MutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse')
  - [#ctor(succeeded,message,textViewMutationResults)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse}- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse.#ctor(System.Boolean,System.String,System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse},System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse})')
  - [DocumentMutationResults](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-DocumentMutationResults 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse.DocumentMutationResults')
  - [Message](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-Message 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse.Message')
  - [Succeeded](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-Succeeded 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse.Succeeded')
- [MutationResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResponseContract')
  - [DocumentMutationResults](#P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-DocumentMutationResults 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResponseContract.DocumentMutationResults')
  - [Message](#P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-Message 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResponseContract.Message')
  - [Succeeded](#P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-Succeeded 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResponseContract.Succeeded')
- [MutationResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult')
  - [Aborted](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Aborted 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Aborted')
  - [DocumentChanged](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentChanged 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.DocumentChanged')
  - [DocumentNotOpen](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentNotOpen 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.DocumentNotOpen')
  - [DocumentVersionTooOld](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentVersionTooOld 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.DocumentVersionTooOld')
  - [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Success')
  - [TextViewNotOpen](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-TextViewNotOpen 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.TextViewNotOpen')
- [PointTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode')
  - [Negative](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-Negative 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode.Negative')
  - [Positive](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-Positive 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode.Positive')
- [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position')
- [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position')
  - [#ctor(document,position)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,System.Int32)')
  - [#ctor(line,column)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-#ctor-System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.#ctor(System.Int32,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Document')
  - [Offset](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Offset 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Offset')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.RpcContract')
  - [Column](#P-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Column 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.Column')
  - [Line](#P-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Line 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.Line')
  - [Add(offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Add-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Add(System.Int32)')
  - [CompareTo(other)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-CompareTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.CompareTo(Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [Difference(other)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Difference-Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Difference(Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Equals(System.Object)')
  - [GetChar()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetChar 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.GetChar')
  - [GetContainingLine()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetContainingLine 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.GetContainingLine')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.GetHashCode')
  - [Subtract(offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Subtract-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Subtract(System.Int32)')
  - [TranslateTo(targetDocumentVersion,trackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode)')
  - [op_Addition(point,offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Addition-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Addition(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,System.Int32)')
  - [op_Equality()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [op_GreaterThan()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_GreaterThan-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_GreaterThan(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.Data.Position)~Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-~System-Int32 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.Data.Position)~System.Int32')
  - [op_Inequality()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [op_LessThan()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_LessThan-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_LessThan(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [op_Subtraction(point,offset)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Subtraction(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,System.Int32)')
  - [op_Subtraction(start,other)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.op_Subtraction(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [CompareTo()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.CompareTo(Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-ToString 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.ToString')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_Equality(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [op_GreaterThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_GreaterThan(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [op_GreaterThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_GreaterThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_Inequality(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [op_LessThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_LessThan(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
  - [op_LessThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position- 'Microsoft.VisualStudio.RpcContracts.Utilities.Position.op_LessThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.Position,Microsoft.VisualStudio.RpcContracts.Utilities.Position)')
- [ReloadContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract')
  - [#ctor(textDocument)](#M-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument- 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument)')
  - [TextDocument](#P-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract.TextDocument')
- [SaveContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract')
  - [#ctor(before,after,isCopy,allowOverwrite,allowCreateFolder)](#M-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Uri,System-Boolean,System-Boolean,System-Boolean- 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,System.Uri,System.Boolean,System.Boolean,System.Boolean)')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.After')
  - [AllowCreateFolder](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowCreateFolder 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.AllowCreateFolder')
  - [AllowOverwrite](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-AllowOverwrite 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.AllowOverwrite')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.Before')
  - [IsCopy](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-IsCopy 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.IsCopy')
- [Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection')
- [Selection](#T-Microsoft-VisualStudio-RpcContracts-Editor-Selection 'Microsoft.VisualStudio.RpcContracts.Editor.Selection')
  - [#ctor(extent,isReversed)](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.Span,System.Boolean)')
  - [Invalid](#F-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Invalid 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.Invalid')
  - [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint')
  - [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint')
  - [End](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-End 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.End')
  - [Extent](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Extent 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.Extent')
  - [InsertionPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-InsertionPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.InsertionPoint')
  - [IsEmpty](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-IsEmpty 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.IsEmpty')
  - [IsReversed](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-IsReversed 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.IsReversed')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.RpcContract')
  - [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Start 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.Start')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection,Microsoft-VisualStudio-Extensibility-Editor-UI-Selection- 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.UI.Selection,Microsoft.VisualStudio.Extensibility.Editor.UI.Selection)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection,Microsoft-VisualStudio-Extensibility-Editor-UI-Selection- 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.UI.Selection,Microsoft.VisualStudio.Extensibility.Editor.UI.Selection)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Editor.Selection.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Editor.Selection.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-Selection,Microsoft-VisualStudio-RpcContracts-Editor-Selection- 'Microsoft.VisualStudio.RpcContracts.Editor.Selection.op_Equality(Microsoft.VisualStudio.RpcContracts.Editor.Selection,Microsoft.VisualStudio.RpcContracts.Editor.Selection)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-Selection,Microsoft-VisualStudio-RpcContracts-Editor-Selection- 'Microsoft.VisualStudio.RpcContracts.Editor.Selection.op_Inequality(Microsoft.VisualStudio.RpcContracts.Editor.Selection,Microsoft.VisualStudio.RpcContracts.Editor.Selection)')
- [SelectionMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionMutationContract')
  - [Selections](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract-Selections 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionMutationContract.Selections')
  - [TextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionMutationContract.TextView')
- [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span')
  - [#ctor(document,start,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Int32,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,System.Int32,System.Int32)')
  - [#ctor(start,end)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [#ctor(start,length)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.Position,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Document')
  - [End](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-End 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.End')
  - [IsEmpty](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-IsEmpty 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.IsEmpty')
  - [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Length 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Length')
  - [RpcContract](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-RpcContract 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.RpcContract')
  - [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Start 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Start')
  - [Contains(position)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-System-Int32- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Contains(System.Int32)')
  - [Contains(point)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-Microsoft-VisualStudio-Extensibility-Editor-Data-Position- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Contains(Microsoft.VisualStudio.Extensibility.Editor.Data.Position)')
  - [Contains(snapshotSpan)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Contains(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.GetHashCode')
  - [GetText()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-GetText 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.GetText')
  - [Intersection(snapshotSpan)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Intersection-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Intersection(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [IntersectsWith(span)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-IntersectsWith-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.IntersectsWith(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [Overlap(snapshotSpan)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Overlap-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Overlap(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [OverlapsWith(snapshotSpan)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-OverlapsWith-Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.OverlapsWith(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [TranslateTo(targetDocumentVersion,spanTrackingMode)](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode)')
  - [op_Equality()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.Data.Span,Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.Data.Span)~Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange')
  - [op_Inequality()](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-Span- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.Data.Span,Microsoft.VisualStudio.Extensibility.Editor.Data.Span)')
- [SpanTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode')
  - [Custom](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-Custom 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode.Custom')
  - [EdgeExclusive](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeExclusive 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode.EdgeExclusive')
  - [EdgeInclusive](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeInclusive 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode.EdgeInclusive')
  - [EdgeNegative](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeNegative 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode.EdgeNegative')
  - [EdgePositive](#F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgePositive 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode.EdgePositive')
- [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument')
  - [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.Uri')
  - [Version](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Version 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.Version')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Equals-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.Equals(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextDocument- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.op_Equality(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,Microsoft.VisualStudio.RpcContracts.Editor.TextDocument)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextDocument- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.op_Inequality(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,Microsoft.VisualStudio.RpcContracts.Editor.TextDocument)')
- [TextDocumentMetadataContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract')
  - [IsDirty](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-IsDirty 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.IsDirty')
  - [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Uri')
  - [Version](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Version 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Version')
  - [Merge()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract-Merge-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract.Merge(Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMetadataContract)')
- [TextDocumentMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract')
  - [#ctor(document,edits)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract[]- 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract[])')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-Document 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract.Document')
  - [Edits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-Edits 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract.Edits')
- [TextDocumentMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse')
  - [#ctor(after,mutationResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-RpcContracts-Editor-MutationResult- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.RpcContracts.Editor.MutationResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse.After')
  - [MutationResult](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-MutationResult 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse.MutationResult')
- [TextDocumentMutationResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract.After')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract.Before')
  - [MutationResult](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-MutationResult 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract.MutationResult')
- [TextDocumentSynchronizationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract')
  - [Edits](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Edits 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract.Edits')
  - [Metadata](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract-Metadata 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract.Metadata')
- [TextMutation](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextMutation')
  - [Span](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation-Span 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextMutation.Span')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation-Text 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextMutation.Text')
- [TextMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract')
  - [Range](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract-Range 'Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract.Range')
  - [Text](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract-Text 'Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract.Text')
- [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Document 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.Document')
  - [Id](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Id 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.Id')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Equals-Microsoft-VisualStudio-RpcContracts-Editor-TextView- 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.Equals(Microsoft.VisualStudio.RpcContracts.Editor.TextView)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.GetHashCode')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-TextView,Microsoft-VisualStudio-RpcContracts-Editor-TextView- 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.op_Equality(Microsoft.VisualStudio.RpcContracts.Editor.TextView,Microsoft.VisualStudio.RpcContracts.Editor.TextView)')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-TextView,Microsoft-VisualStudio-RpcContracts-Editor-TextView- 'Microsoft.VisualStudio.RpcContracts.Editor.TextView.op_Inequality(Microsoft.VisualStudio.RpcContracts.Editor.TextView,Microsoft.VisualStudio.RpcContracts.Editor.TextView)')
- [TextViewChange](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange')
  - [AfterTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.BeforeTextView')
  - [DocumentMutations](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentMutations 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewChange.DocumentMutations')
- [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs')
  - [#ctor(beforeTextView,afterTextView)](#M-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation}- 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.#ctor(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,System.Collections.Generic.IReadOnlyList{Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextMutation})')
  - [AfterTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-AfterTextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.AfterTextView')
  - [BeforeTextView](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-BeforeTextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.BeforeTextView')
  - [Changes](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-Changes 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs.Changes')
- [TextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedListener')
- [TextViewLifetimeListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewLifetimeListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewLifetimeListener')
- [TextViewMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse')
  - [#ctor(after,mutationResult)](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-RpcContracts-Editor-MutationResult- 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse.#ctor(Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView,Microsoft.VisualStudio.RpcContracts.Editor.MutationResult)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-After 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse.After')
  - [MutationResult](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-MutationResult 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse.MutationResult')
- [TextViewMutationResponseContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewMutationResponseContract')
  - [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewMutationResponseContract.After')
  - [Before](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-Before 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewMutationResponseContract.Before')
  - [MutationResult](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-MutationResult 'Microsoft.VisualStudio.RpcContracts.Editor.TextViewMutationResponseContract.MutationResult')
- [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition')
  - [#ctor(textDocument,line,column)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,System.Int32,System.Int32)')
  - [Column](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Column 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.Column')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Document 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.Document')
  - [Line](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Line 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.Line')
  - [CompareTo()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.CompareTo(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-ToString 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.ToString')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_Equality(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [op_GreaterThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_GreaterThan(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [op_GreaterThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_GreaterThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-~Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_Implicit(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)~Microsoft.VisualStudio.RpcContracts.Utilities.Position')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_Inequality(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [op_LessThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_LessThan(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
  - [op_LessThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition.op_LessThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition)')
- [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange')
  - [#ctor(textDocument,startLine,startColumn,endLine,endColumn)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Int32,System-Int32,System-Int32,System-Int32- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.#ctor(Microsoft.VisualStudio.RpcContracts.Editor.TextDocument,System.Int32,System.Int32,System.Int32,System.Int32)')
  - [Document](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-Document 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.Document')
  - [EndColumn](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-EndColumn 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.EndColumn')
  - [EndLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-EndLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.EndLine')
  - [StartColumn](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-StartColumn 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.StartColumn')
  - [StartLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-StartLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.StartLine')
  - [CompareTo()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.CompareTo(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [Equals()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-Equals-System-Object- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-GetHashCode 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-ToString 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.ToString')
  - [op_Equality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_Equality(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [op_GreaterThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_GreaterThan(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [op_GreaterThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_GreaterThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [op_Implicit()](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-~Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_Implicit(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)~Microsoft.VisualStudio.RpcContracts.Utilities.Range')
  - [op_Inequality(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_Inequality(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [op_LessThan(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_LessThan(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
  - [op_LessThanOrEqual(left,right)](#M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange- 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.op_LessThanOrEqual(Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange,Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange)')
- [VisualStudioExtensibilityExtensions](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions')
  - [Editor(extensibility)](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibilityExtensions.Editor(Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute'></a>
## AppliesToAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the conditions under which an extension part should
be activated.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-AppliesToAttribute-ContentType'></a>
### ContentType `property`

##### Summary

The content type of an object. Content type is frequently used to
target specific languages.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract'></a>
## CompoundMutationContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a set of state changes that should be made by the process
owning the entities to be changed, on behalf of the extension.

##### Remarks

Can be used with [ApplyMutationAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyMutationAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyMutationAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract,System.Threading.CancellationToken)').

Prefer [MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)')
to using the RPC contracts directly.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract-Mutations'></a>
### Mutations `property`

##### Summary

A set of changes to apply to text documents.

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext'></a>
## EditorContext `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

RPC contract representing a snapshot of editor context at some point of time.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-ActiveTextViewId'></a>
### ActiveTextViewId `property`

##### Summary

Index of the active text view.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-TextDocuments'></a>
### TextDocuments `property`

##### Summary

State of open text documents.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-EditorContext-TextViews'></a>
### TextViews `property`

##### Summary

State of open text views.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices'></a>
## EditorServices `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Descriptors for internal Editor RPC services for Gladstone Extensibility.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-EditorServices-TextEditorSynchronizationServiceDescriptor'></a>
### TextEditorSynchronizationServiceDescriptor `property`

##### Summary

Descriptor for text editor synchronization and buffer manipulation service.

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

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateActiveTextViewAsync-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext,System-Threading-CancellationToken-'></a>
### CreateActiveTextViewAsync(clientContext,cancellationToken) `method`

##### Summary

Creates a new [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') from the properties contained in `clientContext`.

##### Returns

A [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') thick object that can be used to interact with the editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientContext | [Microsoft.VisualStudio.Extensibility.Definitions.IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext') | UI properties, including document version. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the creation action. |

##### Remarks

This overload is meant primarily for creating [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView')s based on properties captured during
command invocation.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,System-Threading-CancellationToken-'></a>
### CreatePositionAsync(textDocumentPosition,cancellationToken) `method`

##### Summary

Creates a new [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') from a serializable [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition')
RPC contract and other version metadata.

##### Returns

A [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocumentPosition | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | The [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') to realize into [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Document'). Since this is potentially expensive, it's recommended that you only
create [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreatePositionAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Position,System-Threading-CancellationToken-'></a>
### CreatePositionAsync(documentUri,version,position,cancellationToken) `method`

##### Summary

Creates a new [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') from a serializable [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') RPC contract and other version
metadata.

##### Returns

A [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version number to create the span on. |
| position | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | The [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') to realize into a [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.Document'). Since this is potentially expensive, it's recommend that you only
create [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,System-Threading-CancellationToken-'></a>
### CreateSpanAsync(range,cancellationToken) `method`

##### Summary

Creates a new [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') from a serializable [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') RPC contract and other version
metadata.

##### Returns

A [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | The [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') to realize into a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Document'). Since this is potentially expensive, it's recommended that you only
create [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateSpanAsync-System-Uri,System-Int32,Microsoft-VisualStudio-RpcContracts-Utilities-Range,System-Threading-CancellationToken-'></a>
### CreateSpanAsync(documentUri,version,range,cancellationToken) `method`

##### Summary

Creates a new [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') from a serializable [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') RPC contract and other version
metadata.

##### Returns

A [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') thick object that can be used to interact with the text of the span in the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version number to create the span on. |
| range | [Microsoft.VisualStudio.RpcContracts.Utilities.Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') | The [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range') to realize into a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open, accessible via
[Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Document 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.Document'). Since this is potentially expensive, it's recommended that you only
create [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span')s when you actually need to view the content of the document and not
just the range.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextDocumentAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Threading-CancellationToken-'></a>
### CreateTextDocumentAsync(textDocument,cancellationToken) `method`

##### Summary

Creates a new [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') from a serializable [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') RPC contract.

##### Returns

An [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') thick object that can be used to interact with the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | A serializable [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') RPC contract. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

##### Remarks

This overload potentially forces a load of the document if it's not yet open.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService-CreateTextViewAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken-'></a>
### CreateTextViewAsync(textView,cancellationToken) `method`

##### Summary

Creates a new [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') from a serializable [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') RPC contract.

##### Returns

An [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') thick object that can be used to interact with the editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textView | [Microsoft.VisualStudio.RpcContracts.Editor.TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') | A serializable [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') RPC contract. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the request. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatableInternal`1'></a>
## IMutatableInternal\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Implementation detail of the Visual Studio extensibility framework that
exposes a mechanism for getting a mutator object for changing an immutable
object during a call to [MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMutator | The type of the mutator object. |

##### Remarks

The typical pattern is for the mutatable object to implement both
[IMutatable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable`1 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable`1') (for extender-visible surface area) and
[IMutatableInternal\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatableInternal`1 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatableInternal`1') (for framework-internal code) to
enable their type to generate RPC requests for a mutate operation.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable`1'></a>
## IMutatable\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Marker interface indicating that the implementing object supports
being changed via a call to
[MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMutator | The type of the object that does the mutation. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutationBatchInternal'></a>
## IMutationBatchInternal `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Internal implementation detail of Visual Studio extensibility framework
that exposes a way to register individual RPC requests in a sequence of
[MutationContractBase](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase 'Microsoft.VisualStudio.RpcContracts.Editor.MutationContractBase')s.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutationBatchInternal-AddMutationRpcContract-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase-'></a>
### AddMutationRpcContract(rpcContract) `method`

##### Summary

Registers an RPC request to happen as part of a [CompoundMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract')
request to [ApplyMutationAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyMutationAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyMutationAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract,System.Threading.CancellationToken)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rpcContract | [Microsoft.VisualStudio.RpcContracts.Editor.MutationContractBase](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase 'Microsoft.VisualStudio.RpcContracts.Editor.MutationContractBase') | The RPC contract of the operation. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource'></a>
## IMutatorSource `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Exposes a way to acquire an instance of a mutator object for
modifying some [IMutatable\`1](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable`1 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable`1').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource-GetMutator``1-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable{``0}-'></a>
### GetMutator\`\`1(mutatable) `method`

##### Summary

Gets an object that exposes methods for modifying `mutatable`.

##### Returns

An instance of the mutator that can change the target object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mutatable | [Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable{\`\`0}](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatable{``0} 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatable{``0}') | The object being mutated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMutator | The specific type of the mutator object. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument'></a>
## ITextDocument `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

##### Summary

Provides read access to an immutable version of a document in the file system,
in memory in this Service Hub extension, or remoted from the host Visual Studio.

##### Remarks

[ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') represents a document at a point in time and does not
change. Most IDE features will be invoked with an [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') with
the state of the document when the feature was invoked.

Some advanced scenarios may benefit from caching results computed against previous
[ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') versions. To facilitate such caching, [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
supports 'translating' positions and spans on a document between versions using
[TranslateTo](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode)') and
[TranslateTo](#M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode- 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position.TranslateTo(Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode)'), respectively.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-IsDirty'></a>
### IsDirty `property`

##### Summary

Determines whether the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') is dirty.

##### Remarks

If `true`, the contents of [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') have
changed since the file was last loaded or saved. If `false`, the contents of [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') have
not changed since the file was last loaded or saved.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Item-System-Int32-'></a>
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

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Length'></a>
### Length `property`

##### Summary

Gets the number of UTF-16 characters contained in the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Lines'></a>
### Lines `property`

##### Summary

Gets a collection of lines in this version of the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object to a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Uri'></a>
### Uri `property`

##### Summary

The Uri of the file. Most frequently the name and path of the file on disk.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-CopyTo-System-Int32,System-Char[],System-Int32,System-Int32-'></a>
### CopyTo(sourceIndex,destination,destinationIndex,count) `method`

##### Summary

Copies a range of text to a character array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index in the text snapshot. |
| destination | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | The destination array. |
| destinationIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index in the destination array at which to start copying the text. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of characters to copy. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `sourceIndex` is less than zero or greater than the length of the document, or
`count` is less than zero, or `sourceIndex` + `count` is
greater than the length of the document, or `destinationIndex` is less than zero,
or `destinationIndex` plus `count` is greater than the length of `destination`. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `destination` is null. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetLineFromPosition-System-Int32-'></a>
### GetLineFromPosition(position) `method`

##### Summary

Gets an [ITextDocumentLine](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine') for a line at the given position.

##### Returns

A non-null [ITextDocumentLine](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `position` is less than zero or greater than length of line. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetLineNumberFromPosition-System-Int32-'></a>
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

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### GetText(span) `method`

##### Summary

Gets text starting at the beginning of the span and having length equal to the length of the span.

##### Returns

A non-null string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| span | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to return. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The end of the span is greater than [Length](#P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-Length 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument.Length'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText-System-Int32,System-Int32-'></a>
### GetText(startIndex,length) `method`

##### Summary

Gets text starting at `startIndex` and having length equal to `length`.

##### Returns

The string of length `length` starting at `startIndex`
in the underlying [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of text to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `startIndex` is less than zero or greater than the length of the document,
or `length` is less than zero, or `startIndex` plus `length` is greater than the length of the document. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-GetText'></a>
### GetText() `method`

##### Summary

Gets all the text in the document.

##### Returns

A non-null string.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-ToCharArray-System-Int32,System-Int32-'></a>
### ToCharArray(startIndex,length) `method`

##### Summary

Converts a range of text to a character array.

##### Returns

The array of characters starting at `startIndex` in the
underlying [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') and extend to its end.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range of text. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `startIndex` is less than zero or greater than the length of the document, or
`length` is less than zero, or `startIndex` plus `length`
is greater than the length of the document. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-TranslatePositionTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-'></a>
### TranslatePositionTo(trackingMode) `method`

##### Summary

Translates a [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') forward or backward in time to this [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')'s version.

##### Returns

A [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The [PointTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | This [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') does not refer to the same underlying text document as this [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument-TranslateSpanTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-'></a>
### TranslateSpanTo(trackingMode) `method`

##### Summary

Translates a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') forward or backward in time to this [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')'s version.

##### Returns

A [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The [PointTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | This [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') does not refer to the same underlying text document as this [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine'></a>
## ITextDocumentLine `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

##### Summary

Provides read access to a line in an immutable version of a document in the
file system, in memory in this Service Hub extension, or remoted from the host
Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Document'></a>
### Document `property`

##### Summary

The immutable document version in which this line appears.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-End'></a>
### End `property`

##### Summary

The [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') of the first character past the end of the line, excluding any
line break characters (thus will address a line break character, except 
for the last line in the buffer, in which case it addresses a
position past the end of the buffer).

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-EndIncludingLineBreak'></a>
### EndIncludingLineBreak `property`

##### Summary

The [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') of the first character past the end of the line, including any
line break characters (thus will address the first character in 
the succeeding line, unless this is the last line, in which case it addresses a
position past the end of the buffer).

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Extent'></a>
### Extent `property`

##### Summary

The extent of the line, excluding any line break characters.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-ExtentIncludingLineBreak'></a>
### ExtentIncludingLineBreak `property`

##### Summary

The extent of the line, including any line break characters.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Length'></a>
### Length `property`

##### Summary

Length of the line, excluding any line break characters.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LengthIncludingLineBreak'></a>
### LengthIncludingLineBreak `property`

##### Summary

Length of the line, including any line break characters.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LineBreakLength'></a>
### LineBreakLength `property`

##### Summary

Length of line break characters (always falls in the range [0..2]).

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-LineNumber'></a>
### LineNumber `property`

##### Summary

The 0-origin line number of the line.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-Start'></a>
### Start `property`

##### Summary

The [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') of the first character in the line.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetLineBreakText'></a>
### GetLineBreakText() `method`

##### Summary

The string consisting of the line break characters (if any) at the
end of the line. Has zero length for the last line in the buffer.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetText'></a>
### GetText() `method`

##### Summary

The text of the line, excluding any line break characters.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine-GetTextIncludingLineBreak'></a>
### GetTextIncludingLineBreak() `method`

##### Summary

The text of the line, including any line break characters.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator'></a>
## ITextDocumentMutator `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Exposes methods for changing an immutable [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') instance.

##### Remarks

You can acquire an instance of [ITextDocumentMutator](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator') within the function
passed to
[MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document'></a>
### Document `property`

##### Summary

The specific version of the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') that the edit(s)
will be applied to, unless otherwise specified as part of a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span')
or [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') parameter.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Delete-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### Delete(span) `method`

##### Summary

Deletes the specified `span` of text from the document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| span | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') of text to delete. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Insert-System-Int32,System-String-'></a>
### Insert(position,text) `method`

##### Summary

Inserts the specified text at the specified position in the
document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position to start inserting. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to insert. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Reload'></a>
### Reload() `method`

##### Summary

Reloads the document from disk.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Rename-System-String-'></a>
### Rename(newFilePath) `method`

##### Summary

Renames [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to `newFilePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Replace-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,System-String-'></a>
### Replace(replaceSpan,replaceWith) `method`

##### Summary

Replaces the text within `replaceSpan` with
`replaceWith`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceSpan | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') of text to replace. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') of text to insert. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Save'></a>
### Save() `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to disk.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveAs-System-String,System-Boolean-'></a>
### SaveAs(filePath,overwrite) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to disk with the new `filePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveAs-System-String,System-Boolean,System-Boolean-'></a>
### SaveAs(filePath,overwrite,createFolder) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to disk with the new `filePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |
| createFolder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, creates the destination folder, if it does not yet exist. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveCopy-System-String,System-Boolean-'></a>
### SaveCopy(filePath,overwrite) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to disk with the new `filePath`.
Does not update the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the underlying document, as used by subsequent [Save](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Save 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Save')s.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-SaveCopy-System-String,System-Boolean,System-Boolean-'></a>
### SaveCopy(filePath,overwrite,createFolder) `method`

##### Summary

Saves the contents of [Document](#P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Document 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Document') to disk with the new `filePath`.
Does not update the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the underlying document, as used by subsequent [Save](#M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextDocumentMutator-Save 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextDocumentMutator.Save')s.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new file path for the document. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, replaces the existing file. |
| createFolder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, creates the destination folder, if it does not yet exist. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract'></a>
## ITextEditorSynchronizationServiceContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

This is a private brokered service running in the main VS process and representing “source of truth” regarding text document content.
It provides callers with document content of specific versions and can provide updates as documents are changing.
It also applies changes submitted by extensions to documents and text views.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyMutationAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract,System-Threading-CancellationToken-'></a>
### ApplyMutationAsync(edit,cancellationToken) `method`

##### Summary

Applies a set of mutations to mutatable objects such as [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') and [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| edit | [Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract') | Describes the set of changes to apply. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the in-progress request. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-SubscribeToDocumentChangesAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-IObserver{Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentSynchronizationContract},System-Threading-CancellationToken-'></a>
### SubscribeToDocumentChangesAsync(textDocument,observer,cancellationToken) `method`

##### Summary

Subscribes `observer` to mutations from the specified strongly-versioned document.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | The strongly versioned document to subscribe to updates from. |
| observer | [System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver 'System.IObserver{Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentSynchronizationContract}') | The object that will be notified when the document changes. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancels the subscription request. |

##### Remarks

Document changes are sent as a [TextDocumentMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract') with several optional parameters
and are guaranteed to be sent in order. Observers should be prepared to handle any combination of
present/missing parameters and should support state changes that come in one message or a batch
of several.

Documents open in a text view in the IDE will be automatically unsubscribed when closed and then
[OnCompleted](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IObserver`1.OnCompleted 'System.IObserver`1.OnCompleted') will be called.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView'></a>
## ITextView `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Represents an editor that is attached to a document. Should be comparable to a TextView but naming it as an editor
 until we can determine how to create TextViews through our brokered service.

 Similar to https://code.visualstudio.com/api/references/vscode-api#TextEditor.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object to a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-Selection'></a>
### Selection `property`

##### Summary

The primary selection on this text view. Shorthand for this.Selections[0].

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-Selections'></a>
### Selections `property`

##### Summary

The selections in this text view. The primary selection is always at index 0.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView-GetTextDocumentAsync-System-Threading-CancellationToken-'></a>
### GetTextDocumentAsync() `method`

##### Summary

The document associated with this text editor. The document will be the same for the entire lifetime
of this text editor.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener'></a>
## ITextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Extensibility point for listening for [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView')s to be changed
in an OOP extension running in service hub.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener-TextViewChangedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs,System-Threading-CancellationToken-'></a>
### TextViewChangedAsync() `method`

##### Summary

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is changed.

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

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is changed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener'></a>
## ITextViewLifetimeListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Extensibility point for listening for [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView')s to be opened
and closed in an OOP extension running in service hub.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewClosedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken-'></a>
### TextViewClosedAsync() `method`

##### Summary

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Content type changes from a matching content type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewLifetimeListener-TextViewCreatedAsync-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Threading-CancellationToken-'></a>
### TextViewCreatedAsync() `method`

##### Summary

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Content type changes from an unmatching content type to a matching, such as when the user changes the file extension,
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

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is closed.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Content type changes from a matching content type to an unmatching, such as when the user changes the file extension,
  are considered 'text view closes' for the purposes of this API.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ITextViewLifetimeListenerContract-TextViewCreatedAsync-Microsoft-VisualStudio-RpcContracts-Editor-TextView,System-Threading-CancellationToken-'></a>
### TextViewCreatedAsync() `method`

##### Summary

Called when an [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') with matching content type is opened.

##### Parameters

This method has no parameters.

##### Remarks

Special scenarios:
- Content type changes from an unmatching content type to a matching, such as when the user changes the file extension,
  are considered 'text view creations' for the purposes of this API.
- This API will be called for all already open text views when an extension is hot loaded in the middle of an
  existing session.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextViewMutator'></a>
## ITextViewMutator `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Exposes methods for changing an immutable [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') instance.

##### Remarks

You can acquire an instance of [ITextViewMutator](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-ITextViewMutator 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.ITextViewMutator') within the function
passed to
[MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)').

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

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationBatch'></a>
## MutationBatch `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Builder for [CompoundMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract'), describing a set of
state changes that should be made by the process owning the entities to
be changed, on behalf of the extension.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-MutationContractBase'></a>
## MutationContractBase `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract base class for state change operations that can be submitted as part of an atomic transaction via
[ApplyMutationAsync](#M-Microsoft-VisualStudio-RpcContracts-Editor-ITextEditorSynchronizationServiceContract-ApplyMutationAsync-Microsoft-VisualStudio-RpcContracts-Editor-CompoundMutationContract,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.Editor.ITextEditorSynchronizationServiceContract.ApplyMutationAsync(Microsoft.VisualStudio.RpcContracts.Editor.CompoundMutationContract,System.Threading.CancellationToken)').

##### Remarks

Must have [TypeDiscriminatorAttribute](#T-Microsoft-VisualStudio-RpcContracts-JsonConverters-TypeDiscriminatorAttribute 'Microsoft.VisualStudio.RpcContracts.JsonConverters.TypeDiscriminatorAttribute') for each sub-class.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse'></a>
## MutationResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Describes the cumulative result of a call to
[MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-#ctor-System-Boolean,System-String,System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse},System-Collections-Generic-IReadOnlyDictionary{Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse}-'></a>
### #ctor(succeeded,message,textViewMutationResults) `constructor`

##### Summary

Initializes a new instance of [MutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.MutationResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| succeeded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the cumulative operation completed successfully. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Any cumulative error message, `null`, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none. |
| textViewMutationResults | [System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument,Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse}') | Per-document operation results including per document errors and updated [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
versions. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-DocumentMutationResults'></a>
### DocumentMutationResults `property`

##### Summary

Per-document operation results including per document errors and updated [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
versions.

##### Remarks

Key of dictionary is the version of the document prior to the edits.
[After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract.After') contains the updated document version.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-Message'></a>
### Message `property`

##### Summary

Any cumulative error message, `null`, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-MutationResponse-Succeeded'></a>
### Succeeded `property`

##### Summary

`true` if the cumulative operation completed successfully.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract'></a>
## MutationResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for an atomically applied set of mutations, applied across multiple documents.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-DocumentMutationResults'></a>
### DocumentMutationResults `property`

##### Summary

Contains per-document operation results including per document errors and updated [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
versions.

##### Remarks

Key of dictionary is the version of the document prior to the edits.
[After](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationResponseContract.After') contains the updated document version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-Message'></a>
### Message `property`

##### Summary

Contains any high level error messages or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if none.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-MutationResponseContract-Succeeded'></a>
### Succeeded `property`

##### Summary

`true` if all operations completed successfully.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult'></a>
## MutationResult `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Result of a mutation operation.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Aborted'></a>
### Aborted `constants`

##### Summary

Operation was aborted for some reason. Check Message property for
more information.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentChanged'></a>
### DocumentChanged `constants`

##### Summary

Operation failed due to the document changing.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentNotOpen'></a>
### DocumentNotOpen `constants`

##### Summary

Operation failed because the target document is not open in the host process.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-DocumentVersionTooOld'></a>
### DocumentVersionTooOld `constants`

##### Summary

Operation failed because the target document version is too old.
Try again with a newer version.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success'></a>
### Success `constants`

##### Summary

Operation completed successfully.

<a name='F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-TextViewNotOpen'></a>
### TextViewNotOpen `constants`

##### Summary

Operation failed because the target text view is not open in the host process.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode'></a>
## PointTrackingMode `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

##### Summary

Represents tracking modes for [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position')s across versions of an [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-Negative'></a>
### Negative `constants`

##### Summary

With this setting, a point tracks toward the beginning of the document, 
so that an insertion at the current position leaves the point unaffected.  If a
replacement contains the point, it will end up at the beginning of the replacement text.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-Positive'></a>
### Positive `constants`

##### Summary

With this setting, a point tracks toward the end of the document, so that an
insertion at the current position pushes the point to the end of the inserted text. 
If a replacement contains the point, it will end up at the end of the replacement text.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position'></a>
## Position `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

##### Summary

An immutable text position in a particular [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version.

##### Remarks

[VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') is one of three closely related concepts:
- [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'): Thick object representing a span/range of text in a [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').
  This type should be used in all code within the same process.
- [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition'): A serializable representation of [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position'): A serialiable representation of [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  spans/range to be rehydrated into [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-Position'></a>
## Position `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a position in a document version.

##### Remarks

[Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') is one of three closely related concepts:
- [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'): Thick object representing a span/range of text in a [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').
  This type should be used in all code within the same process.
- [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition'): A serializable representation of [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position'): A serialiable representation of [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') that can be sent between
  processes over RPC. As opposed to [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  spans/range to be rehydrated into [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Int32-'></a>
### #ctor(document,position) `constructor`

##### Summary

Initializes a new instance of a [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') with respect to a particular [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | The [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the point. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-#ctor-System-Int32,System-Int32-'></a>
### #ctor(line,column) `constructor`

##### Summary

Initializes a new instance of the [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the position. |
| column | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The column (0-based) of the position. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Document'></a>
### Document `property`

##### Summary

Gets the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') to which this snapshot point refers.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Offset'></a>
### Offset `property`

##### Summary

Gets the position of the point as a numeric offset from the start of the document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Column'></a>
### Column `property`

##### Summary

Gets the column (0-based) of the position.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Line'></a>
### Line `property`

##### Summary

Gets the line (0-based) of the position.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Add-System-Int32-'></a>
### Add(offset) `method`

##### Summary

Creates a new snapshot point at the specified offset from this point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new point is less than zero or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-CompareTo-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### CompareTo(other) `method`

##### Summary

Determines whether this snapshot is the same as a second snapshot point.

##### Returns

A negative integer if the position of this snapshot point occurs before the second snapshot point, 
a positive integer if the position of this snapshot point occurs before the second snapshot point, and 
zero if the positions are the same.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The snapshot point to which to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Difference-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### Difference(other) `method`

##### Summary

Computes the offset between this snapshot point and another snapshot point.

##### Returns

The offset between the two points, equivalent to other.Offset -
this.Offset.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The point from which to compute the offset. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two points do not belong to the same
snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether this snapshot point is the same as a second snapshot point.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetChar'></a>
### GetChar() `method`

##### Summary

Gets the character at the position of this snapshot point.

##### Returns

The character at the position of this snapshot point.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | if the position of this point is equal to the length of the snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetContainingLine'></a>
### GetContainingLine() `method`

##### Summary

The [ITextDocumentLine](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocumentLine 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocumentLine') containing this snapshot point.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-Subtract-System-Int32-'></a>
### Subtract(offset) `method`

##### Summary

Creates a new snapshot point at the specified negative offset from this point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new point is less than zero or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode-'></a>
### TranslateTo(targetDocumentVersion,trackingMode) `method`

##### Summary

Translates this [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') to an older or newer [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version.

##### Returns

A [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') that has been mapped to the requested document version.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetDocumentVersion | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | The document version to which to translate. |
| trackingMode | [Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode') | The [PointTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-PointTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.PointTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `targetDocumentVersion` is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `targetDocumentVersion` does not refer to the same underlying text document as this [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Addition-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32-'></a>
### op_Addition(point,offset) `method`

##### Summary

Increments the position of a snapshot point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| point | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The point from which to calculate the new position. |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new point is less than zero
or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### op_Equality() `method`

##### Summary

Determines whether this snapshot point is the same as a second snapshot point.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_GreaterThan-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### op_GreaterThan() `method`

##### Summary

Determines whether the position of one snapshot point is greater than the position of a second snapshot point.

##### Returns

`true` if the first position is greater than the second position, otherwise `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two points do not belong to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') to [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-~System-Int32'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the snapshot point to an integer equal to the position of the snapshot point in the snapshot.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### op_Inequality() `method`

##### Summary

Determines whether this snapshot point is different from a second snapshot point.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_LessThan-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### op_LessThan() `method`

##### Summary

Determine if the position of the left point is less than the position of the right point.

##### Returns

`true` if left.Offset is greater than right.Offset, otherwise `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two points do not belong to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32-'></a>
### op_Subtraction(point,offset) `method`

##### Summary

Decrements the position of a snapshot point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| point | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The point from which to calculate the new position. |
| offset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset of the new point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The new point is less than zero
or greater than Snapshot.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-op_Subtraction-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### op_Subtraction(start,other) `method`

##### Summary

Computes the offset between two [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') objects.

##### Returns

The offset between the two points, equivalent to start.Offset -
other.Offset.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The starting point. |
| other | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The point from which to compute the offset. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The two points do not belong to the same
snapshot. |

##### Remarks

The following should always be true:
start == other + (start - other).

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### CompareTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_GreaterThan(left,right) `method`

##### Summary

Indicates whether `left` is greater than `right`.

##### Returns

True if `left` is greater than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_GreaterThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is greater than or equal to `right`.

##### Returns

True if `left` is greater than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_LessThan(left,right) `method`

##### Summary

Indicates whether `left` is less than `right`.

##### Returns

True if `left` is less than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-Position-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-Position,Microsoft-VisualStudio-RpcContracts-Utilities-Position-'></a>
### op_LessThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is less than or equal to `right`.

##### Returns

True if `left` is less than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') | Right item. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract'></a>
## ReloadContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract for requesting a document be reloaded from disk.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-'></a>
### #ctor(textDocument) `constructor`

##### Summary

Initializes a new instance of [ReloadContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-ReloadContract 'Microsoft.VisualStudio.RpcContracts.Editor.ReloadContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | The document to reload. |

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

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Uri,System-Boolean,System-Boolean,System-Boolean-'></a>
### #ctor(before,after,isCopy,allowOverwrite,allowCreateFolder) `constructor`

##### Summary

Initializes a new instance of [SaveContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| before | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document to save. |
| after | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The new [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') of the document. If `null`, assumes a 'save' operation. |
| isCopy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `before` is not the same as `after` and `isCopy` is true,
the file is saved as a copy and the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')'s [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') is not changed. |
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

The strongly versioned document to save.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-IsCopy'></a>
### IsCopy `property`

##### Summary

Indicates that [After](#P-Microsoft-VisualStudio-RpcContracts-Editor-SaveContract-After 'Microsoft.VisualStudio.RpcContracts.Editor.SaveContract.After') is a copy of the document and the
document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') should not be changed to point at the new
doc.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection'></a>
## Selection `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Manages the insertion, anchor, and active points for a single caret and its associated
selection.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-Selection'></a>
## Selection `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,System-Boolean-'></a>
### #ctor(extent,isReversed) `constructor`

##### Summary

Instantiates a new Selection with the given extent. Anchor and active points are defined by isReversed, and the
insertion point is located at the active point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extent | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span that the selection covers. |
| isReversed | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True implies that [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint') comes before [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint').
The [InsertionPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-InsertionPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.InsertionPoint') is set to the [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint'). |

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Invalid'></a>
### Invalid `constants`

##### Summary

A static instance of a selection that is invalid and can be used to check for instantiation.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint'></a>
### ActivePoint `property`

##### Summary

Gets the location of the movable selection endpoint, meaning if a user were to hold shift and click,
this point would be changed to the location of the click. If this is an empty selection, this will be at the
[InsertionPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-InsertionPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.InsertionPoint').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint'></a>
### AnchorPoint `property`

##### Summary

Gets the location of the fixed selection endpoint, meaning if a user were to hold shift and click,
this point would remain where it is. If this is an empty selection, this will be at the
[InsertionPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-InsertionPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.InsertionPoint').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-End'></a>
### End `property`

##### Summary

Returns the larger of [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint') and [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Extent'></a>
### Extent `property`

##### Summary

Returns the span from [Start](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Start 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.Start') to [End](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-End 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.End').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-InsertionPoint'></a>
### InsertionPoint `property`

##### Summary

Gets the location where a caret should be rendered and edits performed.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-IsEmpty'></a>
### IsEmpty `property`

##### Summary

True if [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint') equals [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint'). False otherwise.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-IsReversed'></a>
### IsReversed `property`

##### Summary

True if [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint') is later in the document than [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint'). False otherwise.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Start'></a>
### Start `property`

##### Summary

Returns the smaller of [ActivePoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-ActivePoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.ActivePoint') and [AnchorPoint](#P-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-AnchorPoint 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection.AnchorPoint').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether this selection is the same as other selection.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection,Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.Editor.UI.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.Editor.UI.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection') | Right item. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection,Microsoft-VisualStudio-Extensibility-Editor-UI-Selection-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.Extensibility.Editor.UI.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection') | Left item. |
| right | [Microsoft.VisualStudio.Extensibility.Editor.UI.Selection](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-Selection 'Microsoft.VisualStudio.Extensibility.Editor.UI.Selection') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether this selection is the same as other selection.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-Selection,Microsoft-VisualStudio-RpcContracts-Editor-Selection-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.Selection](#T-Microsoft-VisualStudio-RpcContracts-Editor-Selection 'Microsoft.VisualStudio.RpcContracts.Editor.Selection') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.Selection](#T-Microsoft-VisualStudio-RpcContracts-Editor-Selection 'Microsoft.VisualStudio.RpcContracts.Editor.Selection') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-Selection-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-Selection,Microsoft-VisualStudio-RpcContracts-Editor-Selection-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.Selection](#T-Microsoft-VisualStudio-RpcContracts-Editor-Selection 'Microsoft.VisualStudio.RpcContracts.Editor.Selection') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.Selection](#T-Microsoft-VisualStudio-RpcContracts-Editor-Selection 'Microsoft.VisualStudio.RpcContracts.Editor.Selection') | Right item. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract'></a>
## SelectionMutationContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a single change to selections of a specific [TextView](#P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.SelectionMutationContract.TextView')
version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract-Selections'></a>
### Selections `property`

##### Summary

New selections to be applied.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-SelectionMutationContract-TextView'></a>
### TextView `property`

##### Summary

The strongly versioned document the change should be applied to.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span'></a>
## Span `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,System-Int32,System-Int32-'></a>
### #ctor(document,start,length) `constructor`

##### Summary

Initializes a new instance of a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') with the specified document, start point, and length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | The text document version on which to base the span. |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting point of the span. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the span. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `document` is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `start` is negative or greater than `document`.Length, or
`length` is negative or `start` + `length` is greater than
`document`.Length. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### #ctor(start,end) `constructor`

##### Summary

Initializes a new instance of a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') from two [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') objects.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The start position. |
| end | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The end position, which must be from the same [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
as the start point. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The positions belong to different 
[ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') objects. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The end point comes before the start
point. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-Position,System-Int32-'></a>
### #ctor(start,length) `constructor`

##### Summary

Initializes a new instance of a [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') from an existing [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') and a specified length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The starting position. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the span. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `length` is negative or 
`start` + `length` is greater than the length of the snapshot. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Document'></a>
### Document `property`

##### Summary

The [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') to which this snapshot span refers.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-End'></a>
### End `property`

##### Summary

Gets the end of the snapshot span. The span is open-ended on the right side, which is to say
that Start + Length = End.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-IsEmpty'></a>
### IsEmpty `property`

##### Summary

Determines whether or not this span is empty.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Length'></a>
### Length `property`

##### Summary

Gets the length of the span, which is always non-negative.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-RpcContract'></a>
### RpcContract `property`

##### Summary

Converts this thick object into a serializable representation for use in an RPC call.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Start'></a>
### Start `property`

##### Summary

Gets the starting index of the snapshot span.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-System-Int32-'></a>
### Contains(position) `method`

##### Summary

Determines whether the position lies within the span.

##### Returns

`true` if the position is greater than or equal to parameter span.Start and strictly less than parameter span.End, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-Microsoft-VisualStudio-Extensibility-Editor-Data-Position-'></a>
### Contains(point) `method`

##### Summary

Determines whether a given [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') lies within the span.

##### Returns

`true` if the position is greater than or equal to parameter span.Start and strictly less than parameter span.End, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| point | [Microsoft.VisualStudio.Extensibility.Editor.Data.Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position') | The point to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Contains-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### Contains(snapshotSpan) `method`

##### Summary

Determines whether `span` falls completely within this span.

##### Returns

`true` if the specified span falls completely within this span, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshotSpan | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

Determines whether two snapshot spans are the same.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as a hash function for this type.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-GetText'></a>
### GetText() `method`

##### Summary

The text contained by this span.

##### Returns

A non-null string.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Intersection-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### Intersection(snapshotSpan) `method`

##### Summary

Computes the intersection with the given [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span'), or null if there is no intersection.

##### Returns

The intersection of the spans, or null if the intersection is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshotSpan | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `span` does not refer to the same snapshot. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-IntersectsWith-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### IntersectsWith(span) `method`

##### Summary

Determines whether `span` intersects this span. Two spans are considered to 
intersect if they have positions in common, or the end of one span 
coincides with the start of the other span, and neither is empty.

##### Returns

`true` if the spans intersect, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| span | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to check. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-Overlap-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### Overlap(snapshotSpan) `method`

##### Summary

Returns the overlap with the given [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span'), or null if there is no overlap.

##### Returns

The overlap of the spans, or null if the overlap is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshotSpan | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `span` does not refer to the same
[ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') as this snapshot span. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-OverlapsWith-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### OverlapsWith(snapshotSpan) `method`

##### Summary

Determines whether `span` overlaps this span. 
Two spans are considered to overlap if they have positions in common and are not empty. Empty spans do not overlap with any other span.

##### Returns

`true` if the spans overlap, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| snapshotSpan | [Microsoft.VisualStudio.Extensibility.Editor.Data.Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') | The span to check for overlap. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-TranslateTo-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-'></a>
### TranslateTo(targetDocumentVersion,spanTrackingMode) `method`

##### Summary

Translates this [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') to an older or newer [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version.

##### Returns

A new snapshot span.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetDocumentVersion | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | The document version to which to translate. |
| spanTrackingMode | [Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode') | The [SpanTrackingMode](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode 'Microsoft.VisualStudio.Extensibility.Editor.Data.SpanTrackingMode') to use in the translation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `targetDocumentVersion` is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `targetDocumentVersion` does not refer to the same underlying text document as this [Position](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Position 'Microsoft.VisualStudio.Extensibility.Editor.Data.Position'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### op_Equality() `method`

##### Summary

Determines whether two snapshot spans are the same.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-~Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') to [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Data-Span-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-Data-Span,Microsoft-VisualStudio-Extensibility-Editor-Data-Span-'></a>
### op_Inequality() `method`

##### Summary

Determines whether two snapshot spans are different.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode'></a>
## SpanTrackingMode `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Data

##### Summary

Represents tracking modes for [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') objects.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-Custom'></a>
### Custom `constants`

##### Summary

Custom client-determined tracking behavior.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeExclusive'></a>
### EdgeExclusive `constants`

##### Summary

The leading edge of the span is positive tracking (insertions push the current position towards the end) 
and the trailing edge is negative tracking (insertions push the current position towards the start).
The span will not expand when text changes occur at the span boundaries. For example,
if an EdgeExclusive Span has Start position 3, and a single character is inserted at position 3,
the Span will then have Start position 4 and its length will be unchanged.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeInclusive'></a>
### EdgeInclusive `constants`

##### Summary

The leading edge of the span is negative tracking (insertions push the current position toward the start) 
and the trailing edge is positive tracking (insertions push the current position toward the end).
The span will expand when text changes occur at the span boundaries. For example,
if an EdgeInclusive Span has Start position 3, and a single character is inserted at position 3,
the Span will then have Start position 3 and its length will be increased by one.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgeNegative'></a>
### EdgeNegative `constants`

##### Summary

Both edges of the span are negative tracking (insertions push the current position toward the start).

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-Data-SpanTrackingMode-EdgePositive'></a>
### EdgePositive `constants`

##### Summary

Both edges of the span are positive tracking (insertions push the current position toward the end).

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument'></a>
## TextDocument `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing an [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') in a particular version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Uri'></a>
### Uri `property`

##### Summary

The [Uri](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Uri 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument.Uri') of the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Version'></a>
### Version `property`

##### Summary

The version of the [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-Equals-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-'></a>
### op_Equality(left,right) `method`

##### Summary

Compares two [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument')s to see if they refer to the same underlying
document and version.

##### Returns

`true` if identical.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | Left document. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | Right document. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextDocument-'></a>
### op_Inequality(left,right) `method`

##### Summary

Compares two [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument')s to see if they refer to the same underlying
document and version.

##### Returns

`true` if not identical.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | Left document. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | Right document. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMetadataContract'></a>
## TextDocumentMetadataContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Immutable object holding metadata for a specific [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument')
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

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract'></a>
## TextDocumentMutationContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract describing one or more mutations atomically applied to
an [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract[]-'></a>
### #ctor(document,edits) `constructor`

##### Summary

Initializes a new instance of [TextDocumentMutationContract](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocumentMutationContract').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') |  |
| edits | [Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract[]](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract[] 'Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract[]') |  |

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-Document'></a>
### Document `property`

##### Summary

The strongly versioned document the change should be applied to.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationContract-Edits'></a>
### Edits `property`

##### Summary

The individual text changes.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse'></a>
## TextDocumentMutationResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Describes the outcome of a call to [MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)')
for changes to a particular [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument,Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-'></a>
### #ctor(after,mutationResult) `constructor`

##### Summary

Initializes a new instance of [TextDocumentMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') | The [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version after the changes were applied. |
| mutationResult | [Microsoft.VisualStudio.RpcContracts.Editor.MutationResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult') | The result of the mutation operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-After'></a>
### After `property`

##### Summary

The [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse-MutationResult'></a>
### MutationResult `property`

##### Summary

The result of the mutation operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Success') if
all changes were applied successfully to the target [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract'></a>
## TextDocumentMutationResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing [TextDocumentMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextDocumentMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextDocumentMutationResponse').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-After'></a>
### After `property`

##### Summary

The strongly versioned [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') after the mutation was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-Before'></a>
### Before `property`

##### Summary

The strongly versioned [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') before the mutation was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextDocumentMutationResponseContract-MutationResult'></a>
### MutationResult `property`

##### Summary

The result of the operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Success') or a failure code.

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

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation'></a>
## TextMutation `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

A list of changes applied to a [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation-Span'></a>
### Span `property`

##### Summary

The span to replace. Can be zero length.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation-Text'></a>
### Text `property`

##### Summary

The new text to insert.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract'></a>
## TextMutationContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

Describes a single change to a specific [TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument')
version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract-Range'></a>
### Range `property`

##### Summary

The section of text to delete and replace with [Text](#P-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract-Text 'Microsoft.VisualStudio.RpcContracts.Editor.TextMutationContract.Text').
Can be zero-length if no text should be deleted.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextMutationContract-Text'></a>
### Text `property`

##### Summary

The new text to insert in the document.

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextView'></a>
## TextView `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing a [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') in a particular state and version.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Document'></a>
### Document `property`

##### Summary

The underlying [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument') properties.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Id'></a>
### Id `property`

##### Summary

Unique id of the text view.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-Equals-Microsoft-VisualStudio-RpcContracts-Editor-TextView-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-op_Equality-Microsoft-VisualStudio-RpcContracts-Editor-TextView,Microsoft-VisualStudio-RpcContracts-Editor-TextView-'></a>
### op_Equality(left,right) `method`

##### Summary

Compares two [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView')s to see if they refer to the same underlying
text view and state.

##### Returns

`true` if identical.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') | Left view. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') | Right view. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Editor-TextView-op_Inequality-Microsoft-VisualStudio-RpcContracts-Editor-TextView,Microsoft-VisualStudio-RpcContracts-Editor-TextView-'></a>
### op_Inequality(left,right) `method`

##### Summary

Compares two [TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView')s to see if they refer to the same underlying
text view and state.

##### Returns

`true` if not identical.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Editor.TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') | Left view. |
| right | [Microsoft.VisualStudio.RpcContracts.Editor.TextView](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextView 'Microsoft.VisualStudio.RpcContracts.Editor.TextView') | Right view. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange'></a>
## TextViewChange `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing a [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') after the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') before the change.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewChange-DocumentMutations'></a>
### DocumentMutations `property`

##### Summary

The set of mutations made to the document during this change.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs'></a>
## TextViewChangedArgs `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Arguments for [ITextViewChangedListener](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextViewChangedListener 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextViewChangedListener').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,System-Collections-Generic-IReadOnlyList{Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextMutation}-'></a>
### #ctor(beforeTextView,afterTextView) `constructor`

##### Summary

Creates a new instance of [TextViewChangedArgs](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs 'Microsoft.VisualStudio.Extensibility.Editor.UI.TextViewChangedArgs').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeTextView | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') | The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') before the change. |
| afterTextView | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') | The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') after. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-AfterTextView'></a>
### AfterTextView `property`

##### Summary

The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') after the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-BeforeTextView'></a>
### BeforeTextView `property`

##### Summary

The state of the [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') before the change.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedArgs-Changes'></a>
### Changes `property`

##### Summary

A list of changes applied to the text document.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewChangedListener'></a>
## TextViewChangedListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-UI-TextViewLifetimeListener'></a>
## TextViewLifetimeListener `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.UI

##### Summary

Wrapper object that converts RPC types to C# types.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse'></a>
## TextViewMutationResponse `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.Mutation

##### Summary

Describes the outcome of a call to [MutateAsync](#M-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility-MutateAsync-System-Action{Microsoft-VisualStudio-Extensibility-Editor-Mutation-IMutatorSource},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility.MutateAsync(System.Action{Microsoft.VisualStudio.Extensibility.Editor.Mutation.IMutatorSource},System.Threading.CancellationToken)')
for changes to a particular [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') in the host Visual Studio process.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-#ctor-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView,Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-'></a>
### #ctor(after,mutationResult) `constructor`

##### Summary

Initializes a new instance of [TextViewMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| after | [Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') | The [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') version after the changes were applied. |
| mutationResult | [Microsoft.VisualStudio.RpcContracts.Editor.MutationResult](#T-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult') | The result of the mutation operation. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-After'></a>
### After `property`

##### Summary

The [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') version after the changes were applied.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse-MutationResult'></a>
### MutationResult `property`

##### Summary

The result of the mutation operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Success') if
all changes were applied successfully to the target [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView').

<a name='T-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract'></a>
## TextViewMutationResponseContract `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Editor

##### Summary

RPC contract representing [TextViewMutationResponse](#T-Microsoft-VisualStudio-Extensibility-Editor-Mutation-TextViewMutationResponse 'Microsoft.VisualStudio.Extensibility.Editor.Mutation.TextViewMutationResponse').

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-After'></a>
### After `property`

##### Summary

The strongly versioned [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') after the mutation was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-Before'></a>
### Before `property`

##### Summary

The strongly versioned [ITextView](#T-Microsoft-VisualStudio-Extensibility-Editor-UI-ITextView 'Microsoft.VisualStudio.Extensibility.Editor.UI.ITextView') before the mutation was made.

<a name='P-Microsoft-VisualStudio-RpcContracts-Editor-TextViewMutationResponseContract-MutationResult'></a>
### MutationResult `property`

##### Summary

The result of the operation. [Success](#F-Microsoft-VisualStudio-RpcContracts-Editor-MutationResult-Success 'Microsoft.VisualStudio.RpcContracts.Editor.MutationResult.Success') or a failure code.

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition'></a>
## VersionedTextDocumentPosition `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a strongly versioned position in a document.

##### Remarks

[VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') is one of three closely related concepts:
- Position: Thick object representing a span/range of text in an ITextDocument.
  This type should be used in all code within the same process.
- [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition'): A serializable representation of [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position'): A serialiable representation of [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of position equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  spans/range to be rehydrated into Span by IEditorHostService.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Int32,System-Int32-'></a>
### #ctor(textDocument,line,column) `constructor`

##### Summary

Initializes a new instance of the [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | The text document this position appears on. |
| line | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the position. |
| column | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The column (0-based) of the position. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Column'></a>
### Column `property`

##### Summary

Gets the column (0-based) of the position.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Document'></a>
### Document `property`

##### Summary

Gets a reference to the information describing the underlying document.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Line'></a>
### Line `property`

##### Summary

Gets the line (0-based) of the position.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### CompareTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_GreaterThan(left,right) `method`

##### Summary

Indicates whether `left` is greater than `right`.

##### Returns

True if `left` is greater than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_GreaterThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is greater than or equal to `right`.

##### Returns

True if `left` is greater than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-~Microsoft-VisualStudio-RpcContracts-Utilities-Position'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') to [Position](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Position 'Microsoft.VisualStudio.RpcContracts.Utilities.Position').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_LessThan(left,right) `method`

##### Summary

Indicates whether `left` is less than `right`.

##### Returns

True if `left` is less than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition-'></a>
### op_LessThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is less than or equal to `right`.

##### Returns

True if `left` is less than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentPosition 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentPosition') | Right item. |

<a name='T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange'></a>
## VersionedTextDocumentRange `type`

##### Namespace

Microsoft.VisualStudio.RpcContracts.Utilities

##### Summary

A struct describing a strongly versioned span of text in a document.

##### Remarks

[VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') is one of three closely related concepts:
- [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span'): Thick object representing a span/range of text in a [ITextDocument](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-ITextDocument 'Microsoft.VisualStudio.Extensibility.Editor.Data.ITextDocument').
  This type should be used in all code within the same process.
- [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange'): A serializable representation of [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') that can
  be sent between processes over RPC. This type should be used in most RPC contracts between processes.
- [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range'): A serialiable representation of [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') that can be sent between
  processes over RPC. As opposed to [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange'), it omits the [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri')
  and document version, making for a smaller serializable representation. This type should be used in RPC
  contracts that contain lots of span/range equivalents that need to reduce their payload size for
  performance. These RPC contracts will need to pass the document [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') and version for the
  spans/range to be rehydrated into [Span](#T-Microsoft-VisualStudio-Extensibility-Editor-Data-Span 'Microsoft.VisualStudio.Extensibility.Editor.Data.Span') by [IEditorHostService](#T-Microsoft-VisualStudio-Extensibility-Editor-IEditorHostService 'Microsoft.VisualStudio.Extensibility.Editor.IEditorHostService').

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-#ctor-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument,System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### #ctor(textDocument,startLine,startColumn,endLine,endColumn) `constructor`

##### Summary

Initializes a new instance of the [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textDocument | [Microsoft.VisualStudio.RpcContracts.Editor.TextDocument](#T-Microsoft-VisualStudio-RpcContracts-Editor-TextDocument 'Microsoft.VisualStudio.RpcContracts.Editor.TextDocument') | The |
| startLine | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the start of the span. |
| startColumn | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset (0-based) offset from the start of `startLine` for the start of the span. |
| endLine | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line (0-based) of the end of the span. |
| endColumn | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The offset (0-based) offset from the start of `endLine` for the end of the span. |

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-Document'></a>
### Document `property`

##### Summary

Gets a reference to the information describing the underlying document.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-EndColumn'></a>
### EndColumn `property`

##### Summary

Gets the offset (0-based) offset from the start of [EndLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-EndLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.EndLine') for the end of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-EndLine'></a>
### EndLine `property`

##### Summary

Gets the line (0-based) of the end of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-StartColumn'></a>
### StartColumn `property`

##### Summary

Gets the offset (0-based) offset from the start of [StartLine](#P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-StartLine 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange.StartLine') for the start of the span.

<a name='P-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-StartLine'></a>
### StartLine `property`

##### Summary

Gets the line (0-based) of the start of the span.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-CompareTo-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### CompareTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Equality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_Equality(left,right) `method`

##### Summary

Indicates whether `left` and `right` equiavlent.

##### Returns

True if the items are equiavlent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_GreaterThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_GreaterThan(left,right) `method`

##### Summary

Indicates whether `left` is greater than `right`.

##### Returns

True if `left` is greater than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_GreaterThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_GreaterThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is greater than or equal to `right`.

##### Returns

True if `left` is greater than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Implicit-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-~Microsoft-VisualStudio-RpcContracts-Utilities-Range'></a>
### op_Implicit() `method`

##### Summary

Implicitly converts the [VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') to [Range](#T-Microsoft-VisualStudio-RpcContracts-Utilities-Range 'Microsoft.VisualStudio.RpcContracts.Utilities.Range').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_Inequality-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_Inequality(left,right) `method`

##### Summary

Indicates whether `left` and `right` different.

##### Returns

True if the items are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_LessThan-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_LessThan(left,right) `method`

##### Summary

Indicates whether `left` is less than `right`.

##### Returns

True if `left` is less than `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='M-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-op_LessThanOrEqual-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange,Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange-'></a>
### op_LessThanOrEqual(left,right) `method`

##### Summary

Indicates whether `left` is less than or equal to `right`.

##### Returns

True if `left` is less than or equal to `right`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Left item. |
| right | [Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange](#T-Microsoft-VisualStudio-RpcContracts-Utilities-VersionedTextDocumentRange 'Microsoft.VisualStudio.RpcContracts.Utilities.VersionedTextDocumentRange') | Right item. |

<a name='T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions'></a>
## VisualStudioExtensibilityExtensions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Editor provided extension methods for acquiring VS extensibility points.

<a name='M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibilityExtensions-Editor-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### Editor(extensibility) `method`

##### Summary

Gets and instance of the [EditorExtensibility](#T-Microsoft-VisualStudio-Extensibility-Editor-EditorExtensibility 'Microsoft.VisualStudio.Extensibility.Editor.EditorExtensibility') point.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | The root [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') instance. |
