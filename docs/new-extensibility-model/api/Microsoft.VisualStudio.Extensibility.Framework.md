<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Framework

## Contents

- [AsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.AsyncCommand')
  - [#ctor(executeCallback)](#M-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-#ctor-System-Func{System-Object,System-Threading-CancellationToken,System-Threading-Tasks-Task}- 'Microsoft.VisualStudio.Extensibility.UI.AsyncCommand.#ctor(System.Func{System.Object,System.Threading.CancellationToken,System.Threading.Tasks.Task})')
  - [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.AsyncCommand.CanExecute')
  - [ExecuteAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-ExecuteAsync-System-Object,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.AsyncCommand.ExecuteAsync(System.Object,System.Threading.CancellationToken)')
- [ClientContext](#T-Microsoft-VisualStudio-Extensibility-ClientContext 'Microsoft.VisualStudio.Extensibility.ClientContext')
  - [#ctor(contextProperties,extensibility)](#M-Microsoft-VisualStudio-Extensibility-ClientContext-#ctor-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ClientContext.#ctor(System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object},Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ClientContext-Extensibility 'Microsoft.VisualStudio.Extensibility.ClientContext.Extensibility')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-ClientContext-Item-System-String- 'Microsoft.VisualStudio.Extensibility.ClientContext.Item(System.String)')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-ClientContext-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.ClientContext.ServiceBrokerClient')
  - [AsDictionary()](#M-Microsoft-VisualStudio-Extensibility-ClientContext-AsDictionary 'Microsoft.VisualStudio.Extensibility.ClientContext.AsDictionary')
  - [DisposeManagedResources()](#M-Microsoft-VisualStudio-Extensibility-ClientContext-DisposeManagedResources 'Microsoft.VisualStudio.Extensibility.ClientContext.DisposeManagedResources')
- [CollectionChangedDelegate](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-CollectionChangedDelegate 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.CollectionChangedDelegate')
- [DataContextFormatter](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter')
  - [AsyncCommandCanExecuteGetter](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-AsyncCommandCanExecuteGetter 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.AsyncCommandCanExecuteGetter')
  - [BoolSerializer](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-BoolSerializer 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.BoolSerializer')
  - [Instance](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Instance 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.Instance')
  - [SerializeMethods](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeMethods 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeMethods')
  - [TypeConversions](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-TypeConversions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.TypeConversions')
  - [Deserialize()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Deserialize-MessagePack-MessagePackReader@,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.Deserialize(MessagePack.MessagePackReader@,MessagePack.MessagePackSerializerOptions)')
  - [GetAndCacheTypeSerializer(type)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetAndCacheTypeSerializer-System-Type- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetAndCacheTypeSerializer(System.Type)')
  - [GetSerializeMethodForCollection(type)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetSerializeMethodForCollection-System-Type- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetSerializeMethodForCollection(System.Type)')
  - [GetSerializeMethodForMapObject(type)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetSerializeMethodForMapObject-System-Type- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetSerializeMethodForMapObject(System.Type)')
  - [GetTypeSerializer(type,omitNullableHeader,dataTypeCode,isSimpleValueTypeNullable)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetTypeSerializer-System-Type,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@,System-Boolean@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetTypeSerializer(System.Type,System.Boolean,Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@,System.Boolean@)')
  - [IsCollection(type,itemType,getCountMethod)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-IsCollection-System-Type,System-Type@,System-Reflection-MethodInfo@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.IsCollection(System.Type,System.Type@,System.Reflection.MethodInfo@)')
  - [Serialize()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Serialize-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.Serialize(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions)')
  - [SerializeAsXamlFragment(writer,value,options)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeAsXamlFragment-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeAsXamlFragment(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions)')
  - [SerializeComplexNullable(writer,value,options,serializeMethod)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeComplexNullable-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeComplexNullable(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions,Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod)')
  - [SerializeComplexObjectWithMetadata(writer,value,options,fieldCode,isUniquelyIdentifiable,serializeMethod,collectionDataTypeCode)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeComplexObjectWithMetadata-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeNonNullMethod,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeComplexObjectWithMetadata(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions,Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode,System.Boolean,Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeNonNullMethod,Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode)')
  - [SerializeConvertible(writer,value,options,convertMethod,serializeMethod)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeConvertible-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,System-Func{System-Object,System-Object},Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeConvertible(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions,System.Func{System.Object,System.Object},Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod)')
  - [SerializeXamlFragment(writer,value,options)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeXamlFragment-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.SerializeXamlFragment(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions)')
  - [WriteClass(writer,value,options,propertySerializers)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-WriteClass-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,System-Collections-Generic-Dictionary{System-String,System-ValueTuple{System-Reflection-MethodInfo,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod}}- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.WriteClass(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions,System.Collections.Generic.Dictionary{System.String,System.ValueTuple{System.Reflection.MethodInfo,Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod}})')
  - [WriteUntypedField(writer,value,options)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-WriteUntypedField-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.WriteUntypedField(MessagePack.MessagePackWriter@,System.Object,MessagePack.MessagePackSerializerOptions)')
- [DataContextFormatterResolver](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatterResolver')
  - [Instance](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver-Instance 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatterResolver.Instance')
  - [GetFormatter\`\`1()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver-GetFormatter``1 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatterResolver.GetFormatter``1')
- [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions')
  - [#ctor(dispatcher,forceRootSerialization)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-#ctor-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher,System-Boolean- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.#ctor(Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher,System.Boolean)')
  - [Dispatcher](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-Dispatcher 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.Dispatcher')
  - [ForceRootSerialization](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-ForceRootSerialization 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.ForceRootSerialization')
  - [NonForceRootOptions](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-NonForceRootOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.NonForceRootOptions')
  - [Clone()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-Clone 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.Clone')
  - [HasSerializableProperties(type)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-HasSerializableProperties-System-Type- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.HasSerializableProperties(System.Type)')
  - [IsCollection(type,itemType)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-IsCollection-System-Type,System-Type@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.IsCollection(System.Type,System.Type@)')
  - [IsPropertySerializable(owningType,property,getter,includeSpecialProperties)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-IsPropertySerializable-System-Type,System-Reflection-PropertyInfo,System-Reflection-MethodInfo@,System-Boolean- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.IsPropertySerializable(System.Type,System.Reflection.PropertyInfo,System.Reflection.MethodInfo@,System.Boolean)')
- [DataContextUpdateFormatter](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter')
  - [Instance](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-Instance 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter.Instance')
  - [DeserializeComplexObject()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-DeserializeComplexObject-MessagePack-MessagePackReader@,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter.DeserializeComplexObject(MessagePack.MessagePackReader@,MessagePack.MessagePackSerializerOptions)')
  - [GetEmptyObject()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-GetEmptyObject 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter.GetEmptyObject')
  - [GetReference()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-GetReference-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,MessagePack-MessagePackSerializerOptions- 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter.GetReference(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,MessagePack.MessagePackSerializerOptions)')
- [DataContextUpdateFormatterResolver](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatterResolver')
  - [Instance](#F-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver-Instance 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatterResolver.Instance')
  - [GetFormatter\`\`1()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver-GetFormatter``1 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatterResolver.GetFormatter``1')
- [DataContextUpdateSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions')
  - [#ctor(dispatcher)](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-#ctor-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher- 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.#ctor(Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher)')
  - [Dispatcher](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-Dispatcher 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.Dispatcher')
  - [Clone()](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-Clone 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.Clone')
- [DefaultJsonServiceFactory](#T-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.DefaultJsonServiceFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
- [DefaultMessagePackServiceFactory](#T-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory 'Microsoft.VisualStudio.Extensibility.DefaultMessagePackServiceFactory')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.DefaultMessagePackServiceFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.DefaultMessagePackServiceFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
- [DisposableObject](#T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-IsDisposed 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.IsDisposed')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose(System.Boolean)')
  - [DisposeManagedResources()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeManagedResources 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.DisposeManagedResources')
  - [DisposeNativeResources()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeNativeResources 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.DisposeNativeResources')
  - [Finalize()](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Finalize 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Finalize')
- [EmptyResourceDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-#ctor 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.#ctor')
  - [Instance](#P-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-Instance 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.Instance')
  - [GetStringResourceAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary.GetStringResourceAsync(System.Globalization.CultureInfo,System.String,System.Threading.CancellationToken)')
- [Entry](#T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry')
  - [KeyHashCode](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-KeyHashCode 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.KeyHashCode')
  - [NextKey](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-NextKey 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.NextKey')
  - [NextRef](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-NextRef 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.NextRef')
  - [RefHasCode](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-RefHasCode 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.RefHasCode')
  - [Value](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-Value 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.Value')
  - [WeakReference](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-WeakReference 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Entry.WeakReference')
- [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint')
  - [#ctor(serviceBroker,localServiceProvider,resourceDictionary)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker,System.IServiceProvider,Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary)')
  - [#ctor(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.#ctor(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-IsDisposed 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.IsDisposed')
  - [LocalServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.LocalServiceProvider')
  - [ResourceDictionary](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ResourceDictionary 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ResourceDictionary')
  - [ServiceBroker](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBroker')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBrokerClient')
  - [TraceSource](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-TraceSource 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.TraceSource')
  - [CreateChildInstance\`\`1()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-CreateChildInstance``1 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.CreateChildInstance``1')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.Dispose')
  - [Dispose(isDisposing)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.Dispose(System.Boolean)')
  - [ThrowIfDisposed()](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ThrowIfDisposed 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ThrowIfDisposed')
- [ExtensibilityPointManager](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,key,factory)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-String,System-Func{``0}- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint,System.String,System.Func{``0})')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,factory)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-Func{``0}- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint,System.Func{``0})')
  - [GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint)](#M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint- 'Microsoft.VisualStudio.Extensibility.ExtensibilityPointManager.GetOrCreateExtensibilityPoint``1(Microsoft.VisualStudio.Extensibility.ExtensibilityPoint)')
- [ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-#ctor 'Microsoft.VisualStudio.Extensibility.ExtensionCore.#ctor')
  - [ResourceDictionary](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceDictionary 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ResourceDictionary')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceManager 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ResourceManager')
  - [ServiceFactoryMap](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceFactoryMap 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ServiceFactoryMap')
  - [ServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensionCore.ServiceProvider')
  - [CreateAsync()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-CreateAsync-System-IServiceProvider,Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-ServiceHub-Framework-Services-AuthorizationServiceClient,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.CreateAsync(System.IServiceProvider,Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,Microsoft.ServiceHub.Framework.IServiceBroker,Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient,System.Threading.CancellationToken)')
  - [GetFactory(serviceMoniker)](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetFactory-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.GetFactory(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [GetServiceDescriptor()](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
  - [InitializeServices(serviceCollection)](#M-Microsoft-VisualStudio-Extensibility-ExtensionCore-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Microsoft.VisualStudio.Extensibility.ExtensionCore.InitializeServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ExtensionMethods](#T-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods')
  - [AsStringResourceDictionary(resman)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-AsStringResourceDictionary-System-Resources-ResourceManager- 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods.AsStringResourceDictionary(System.Resources.ResourceManager)')
  - [CloneAsNonDisposable(serviceBroker)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-CloneAsNonDisposable-Microsoft-ServiceHub-Framework-IServiceBroker- 'Microsoft.VisualStudio.Extensibility.Helpers.ExtensionMethods.CloneAsNonDisposable(Microsoft.ServiceHub.Framework.IServiceBroker)')
- [ExtensionPart](#T-Microsoft-VisualStudio-Extensibility-ExtensionPart 'Microsoft.VisualStudio.Extensibility.ExtensionPart')
  - [#ctor(container,extensibilityObject)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.#ctor(Microsoft.VisualStudio.Extensibility.ExtensionCore,Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility)')
  - [Container](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Container 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Container')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Extensibility 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Extensibility')
  - [IsDisposed](#P-Microsoft-VisualStudio-Extensibility-ExtensionPart-IsDisposed 'Microsoft.VisualStudio.Extensibility.ExtensionPart.IsDisposed')
  - [AttachServiceScope(serviceScope)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-AttachServiceScope-Microsoft-Extensions-DependencyInjection-IServiceScope- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.AttachServiceScope(Microsoft.Extensions.DependencyInjection.IServiceScope)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Dispose')
  - [Dispose(isDisposing)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.Dispose(System.Boolean)')
  - [InitializeAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.InitializeAsync(System.Threading.CancellationToken)')
  - [InitializeInternalAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeInternalAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.ExtensionPart.InitializeInternalAsync(System.Threading.CancellationToken)')
- [IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand')
  - [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.CanExecute')
  - [ExecuteAsync(parameter,cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-ExecuteAsync-System-Object,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.ExecuteAsync(System.Object,System.Threading.CancellationToken)')
- [IClientContext](#T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext')
  - [Extensibility](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Extensibility 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.Extensibility')
  - [Item](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Item-System-String- 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.Item(System.String)')
  - [ServiceBrokerClient](#P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-ServiceBrokerClient 'Microsoft.VisualStudio.Extensibility.Definitions.IClientContext.ServiceBrokerClient')
- [IClientContextPrivate](#T-Microsoft-Internal-VisualStudio-Extensibility-Definitions-IClientContextPrivate 'Microsoft.Internal.VisualStudio.Extensibility.Definitions.IClientContextPrivate')
  - [AsDictionary()](#M-Microsoft-Internal-VisualStudio-Extensibility-Definitions-IClientContextPrivate-AsDictionary 'Microsoft.Internal.VisualStudio.Extensibility.Definitions.IClientContextPrivate.AsDictionary')
- [INotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher')
  - [GetMetadataOrRegisterObject(obj)](#M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-GetMetadataOrRegisterObject-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher.GetMetadataOrRegisterObject(System.Object)')
  - [GetObject(id)](#M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-GetObject-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId- 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher.GetObject(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId)')
  - [UpdateCollection(obj,index,value,version)](#M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-UpdateCollection-System-Object,System-Int32,System-Object,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion}- 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher.UpdateCollection(System.Object,System.Int32,System.Object,System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion})')
- [IServiceFactory](#T-Microsoft-VisualStudio-Extensibility-IServiceFactory 'Microsoft.VisualStudio.Extensibility.IServiceFactory')
  - [CreateAsync(serviceMoniker,activationOptions,serviceProvider,instanceType,interfaceType)](#M-Microsoft-VisualStudio-Extensibility-IServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.IServiceFactory.CreateAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.IServiceProvider,System.Type,System.Type)')
  - [GetServiceDescriptor(serviceMoniker)](#M-Microsoft-VisualStudio-Extensibility-IServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker- 'Microsoft.VisualStudio.Extensibility.IServiceFactory.GetServiceDescriptor(Microsoft.ServiceHub.Framework.ServiceMoniker)')
- [MessageContextJsonRpc](#T-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc 'Microsoft.VisualStudio.Extensibility.Framework.MessageContextJsonRpc')
  - [#ctor(messageHandler,messageVersionContext)](#M-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc-#ctor-StreamJsonRpc-IJsonRpcMessageHandler,Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext- 'Microsoft.VisualStudio.Extensibility.Framework.MessageContextJsonRpc.#ctor(StreamJsonRpc.IJsonRpcMessageHandler,Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext)')
  - [DispatchRequestAsync()](#M-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc-DispatchRequestAsync-StreamJsonRpc-Protocol-JsonRpcRequest,StreamJsonRpc-TargetMethod,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Framework.MessageContextJsonRpc.DispatchRequestAsync(StreamJsonRpc.Protocol.JsonRpcRequest,StreamJsonRpc.TargetMethod,System.Threading.CancellationToken)')
- [MultiTargetingRpcConnection](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection')
  - [#ctor(jsonRpcConnection)](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection.#ctor(Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection)')
  - [AddLocalRpcTarget()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-AddLocalRpcTarget-System-Object- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection.AddLocalRpcTarget(System.Object)')
- [MultiTargetingServiceJsonRpcDescriptor](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor')
  - [#ctor(innerDescriptor,messageVersionContext)](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor,Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.#ctor(Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor,Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext)')
  - [Clone()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-Clone 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.Clone')
  - [ConstructRpcConnection()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-ConstructRpcConnection-System-IO-Pipelines-IDuplexPipe- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.ConstructRpcConnection(System.IO.Pipelines.IDuplexPipe)')
  - [CreateJsonRpc()](#M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-CreateJsonRpc-StreamJsonRpc-IJsonRpcMessageHandler- 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor.CreateJsonRpc(StreamJsonRpc.IJsonRpcMessageHandler)')
- [NotificationDispatcherObjectMetadata](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherObjectMetadata')
  - [#ctor(id)](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata-#ctor-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId- 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherObjectMetadata.#ctor(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId)')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata-Id 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherObjectMetadata.Id')
- [NotificationDispatcherVersionedObjectMetadata](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata')
  - [#ctor(id)](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-#ctor-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId- 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata.#ctor(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId)')
  - [BeingUpdated](#P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-BeingUpdated 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata.BeingUpdated')
  - [Version](#P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-Version 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata.Version')
- [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher')
  - [nextId](#F-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-nextId 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.nextId')
  - [objectLookup](#F-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-objectLookup 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.objectLookup')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-Dispose 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.Dispose')
  - [GetMetadataOrRegisterObject()](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-GetMetadataOrRegisterObject-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.GetMetadataOrRegisterObject(System.Object)')
  - [GetObject()](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-GetObject-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId- 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.GetObject(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId)')
  - [UpdateCollection()](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-UpdateCollection-System-Object,System-Int32,System-Object,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion}- 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.UpdateCollection(System.Object,System.Int32,System.Object,System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion})')
- [NotifyPropertyChangedObject](#T-Microsoft-VisualStudio-Extensibility-UI-NotifyPropertyChangedObject 'Microsoft.VisualStudio.Extensibility.UI.NotifyPropertyChangedObject')
  - [SetProperty\`\`1(storage,value,propertyName)](#M-Microsoft-VisualStudio-Extensibility-UI-NotifyPropertyChangedObject-SetProperty``1-``0@,``0,System-String- 'Microsoft.VisualStudio.Extensibility.UI.NotifyPropertyChangedObject.SetProperty``1(``0@,``0,System.String)')
- [PropertyChangedDelegate](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-PropertyChangedDelegate 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.PropertyChangedDelegate')
- [RemoteUserControl](#T-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl')
  - [#ctor(dataContext,synchronizationContext)](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-#ctor-System-Object,System-Threading-SynchronizationContext- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.#ctor(System.Object,System.Threading.SynchronizationContext)')
  - [extToVsSerializerOption](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-extToVsSerializerOption 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.extToVsSerializerOption')
  - [extToVsSerializerOptionForceRoot](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-extToVsSerializerOptionForceRoot 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.extToVsSerializerOptionForceRoot')
  - [notificationsDispatcher](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-notificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.notificationsDispatcher')
  - [synchronizationContext](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-synchronizationContext 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.synchronizationContext')
  - [vsToExtSerializerOption](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-vsToExtSerializerOption 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.vsToExtSerializerOption')
  - [DataContext](#P-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-DataContext 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.DataContext')
  - [ControlLoadedAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-ControlLoadedAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.ControlLoadedAsync(System.Threading.CancellationToken)')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-Dispose 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.Dispose')
  - [Dispose(disposing)](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.Dispose(System.Boolean)')
  - [GetObjectAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-GetObjectAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.GetObjectAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,System.Threading.CancellationToken)')
  - [GetXamlAsync(cancellationToken)](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-GetXamlAsync-System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.GetXamlAsync(System.Threading.CancellationToken)')
  - [InitializeAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-InitializeAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControlClient,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.InitializeAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControlClient,System.Threading.CancellationToken)')
  - [InvokeAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-InvokeAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.InvokeAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,Microsoft.VisualStudio.RpcContracts.RemoteUI.MessagePackFragment,System.Threading.CancellationToken)')
  - [SerializeValueAsync(value)](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SerializeValueAsync-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.SerializeValueAsync(System.Object)')
  - [SetCollectionEntryAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SetCollectionEntryAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Int32,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion},System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.SetCollectionEntryAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,System.Int32,Microsoft.VisualStudio.RpcContracts.RemoteUI.MessagePackFragment,System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion},System.Threading.CancellationToken)')
  - [SetObjectPropertyAsync()](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SetObjectPropertyAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-String,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.SetObjectPropertyAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,System.String,Microsoft.VisualStudio.RpcContracts.RemoteUI.MessagePackFragment,System.Threading.CancellationToken)')
- [ResourceManagerDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary')
  - [#ctor(resourceManager)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-#ctor-System-Resources-ResourceManager- 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary.#ctor(System.Resources.ResourceManager)')
  - [GetStringResourceAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary.GetStringResourceAsync(System.Globalization.CultureInfo,System.String,System.Threading.CancellationToken)')
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Framework-Resources 'Microsoft.VisualStudio.Extensibility.Framework.Resources')
  - [CollectionBeingUpdated](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CollectionBeingUpdated 'Microsoft.VisualStudio.Extensibility.Framework.Resources.CollectionBeingUpdated')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Framework.Resources.CommandIdAlreadyRegistered')
  - [ControlAlreadyInitialized](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ControlAlreadyInitialized 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ControlAlreadyInitialized')
  - [ControlNotInitializedOrDisposed](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ControlNotInitializedOrDisposed 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ControlNotInitializedOrDisposed')
  - [CorruptedDictionary](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CorruptedDictionary 'Microsoft.VisualStudio.Extensibility.Framework.Resources.CorruptedDictionary')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Framework.Resources.Culture')
  - [DuplicateKey](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-DuplicateKey 'Microsoft.VisualStudio.Extensibility.Framework.Resources.DuplicateKey')
  - [ICommandIsNotSupported](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ICommandIsNotSupported 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ICommandIsNotSupported')
  - [InvalidPropertyNameForType](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-InvalidPropertyNameForType 'Microsoft.VisualStudio.Extensibility.Framework.Resources.InvalidPropertyNameForType')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Framework.Resources.InvalidVersionString')
  - [MaximumDictionarySizeExceeded](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MaximumDictionarySizeExceeded 'Microsoft.VisualStudio.Extensibility.Framework.Resources.MaximumDictionarySizeExceeded')
  - [MetadataNotAvailable](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MetadataNotAvailable 'Microsoft.VisualStudio.Extensibility.Framework.Resources.MetadataNotAvailable')
  - [MissingVersionUpdatingVersionedCollection](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MissingVersionUpdatingVersionedCollection 'Microsoft.VisualStudio.Extensibility.Framework.Resources.MissingVersionUpdatingVersionedCollection')
  - [ObjectMetadataNotVersioned](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ObjectMetadataNotVersioned 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ObjectMetadataNotVersioned')
  - [ObjectReferenceNotAvailable](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ObjectReferenceNotAvailable 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ObjectReferenceNotAvailable')
  - [OnlyIListCanBeUpdatedByIndex](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-OnlyIListCanBeUpdatedByIndex 'Microsoft.VisualStudio.Extensibility.Framework.Resources.OnlyIListCanBeUpdatedByIndex')
  - [OnlyTypeObjectSupported](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-OnlyTypeObjectSupported 'Microsoft.VisualStudio.Extensibility.Framework.Resources.OnlyTypeObjectSupported')
  - [PropertyNameNull](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-PropertyNameNull 'Microsoft.VisualStudio.Extensibility.Framework.Resources.PropertyNameNull')
  - [RemoteUserControlAreadyInitialized](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-RemoteUserControlAreadyInitialized 'Microsoft.VisualStudio.Extensibility.Framework.Resources.RemoteUserControlAreadyInitialized')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Framework.Resources.ResourceManager')
  - [TypeDoesntHaveProperty](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeDoesntHaveProperty 'Microsoft.VisualStudio.Extensibility.Framework.Resources.TypeDoesntHaveProperty')
  - [TypeIsBothCollectionAndCommand](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeIsBothCollectionAndCommand 'Microsoft.VisualStudio.Extensibility.Framework.Resources.TypeIsBothCollectionAndCommand')
  - [TypeIsCollectionWithDataMember](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeIsCollectionWithDataMember 'Microsoft.VisualStudio.Extensibility.Framework.Resources.TypeIsCollectionWithDataMember')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Framework.Resources.UnsupportedDocumentMoniker')
  - [VersionConflictUpdatingCollection](#P-Microsoft-VisualStudio-Extensibility-Framework-Resources-VersionConflictUpdatingCollection 'Microsoft.VisualStudio.Extensibility.Framework.Resources.VersionConflictUpdatingCollection')
- [ServiceBrokerNonDisposableWrapper](#T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper')
  - [#ctor(serviceBroker)](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker)')
  - [GetPipeAsync()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetPipeAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.GetPipeAsync(Microsoft.ServiceHub.Framework.ServiceMoniker,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.Threading.CancellationToken)')
  - [GetProxyAsync\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetProxyAsync``1-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken- 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper.GetProxyAsync``1(Microsoft.ServiceHub.Framework.ServiceRpcDescriptor,Microsoft.ServiceHub.Framework.ServiceActivationOptions,System.Threading.CancellationToken)')
- [TransientServiceProvider](#T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider')
  - [#ctor(serviceProvider)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-IServiceProvider- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.#ctor(System.IServiceProvider)')
  - [#ctor(serviceProviders)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-Collections-Generic-IEnumerable{System-IServiceProvider}- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.#ctor(System.Collections.Generic.IEnumerable{System.IServiceProvider})')
  - [AddSingleton(type,value)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton-System-Type,System-Object- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.AddSingleton(System.Type,System.Object)')
  - [AddSingleton\`\`1(value)](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton``1-``0- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.AddSingleton``1(``0)')
  - [GetService()](#M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-GetService-System-Type- 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider.GetService(System.Type)')
- [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility')
  - [#ctor(serviceBroker,serviceProvider,resourceDictionary)](#M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary- 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility.#ctor(Microsoft.ServiceHub.Framework.IServiceBroker,System.IServiceProvider,Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary)')
- [WeakDoubleDictionary\`3](#T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3')
  - [#ctor(keyExtractor)](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-#ctor-System-Func{`2,`0}- 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.#ctor(System.Func{`2,`0})')
  - [ArraySizes](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-ArraySizes 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.ArraySizes')
  - [currentArraySize](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-currentArraySize 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.currentArraySize')
  - [entries](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-entries 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.entries')
  - [firstUnusedEntry](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-firstUnusedEntry 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.firstUnusedEntry')
  - [hasCrashed](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-hasCrashed 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.hasCrashed')
  - [keyBuckets](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-keyBuckets 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.keyBuckets')
  - [keyExtractor](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-keyExtractor 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.keyExtractor')
  - [refBuckets](#F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-refBuckets 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.refBuckets')
  - [Clear()](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Clear 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Clear')
  - [Dispose()](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Dispose 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.Dispose')
  - [GetByReferenceOrAdd(reference,valueFactory)](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-GetByReferenceOrAdd-`1,System-Func{`1,`2}- 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.GetByReferenceOrAdd(`1,System.Func{`1,`2})')
  - [TryGetByReference(reference,value)](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-TryGetByReference-`1,`2@- 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.TryGetByReference(`1,`2@)')
  - [TryGetBySecondaryKey(key,value,reference)](#M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-TryGetBySecondaryKey-`0,`2@,`1@- 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3.TryGetBySecondaryKey(`0,`2@,`1@)')
- [XamlFragment](#T-Microsoft-VisualStudio-Extensibility-UI-XamlFragment 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment')
  - [#ctor(xaml)](#M-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment.#ctor(System.String)')
  - [#ctor(xamlSerializable)](#M-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-#ctor-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment.#ctor(System.Object)')
  - [Xaml](#P-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-Xaml 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment.Xaml')

<a name='T-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand'></a>
## AsyncCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

A generic implementation of [IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand') that invokes an async callback when executed.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-#ctor-System-Func{System-Object,System-Threading-CancellationToken,System-Threading-Tasks-Task}-'></a>
### #ctor(executeCallback) `constructor`

##### Summary

Initializes a new instance of the [AsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.AsyncCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| executeCallback | [System.Func{System.Object,System.Threading.CancellationToken,System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Object,System.Threading.CancellationToken,System.Threading.Tasks.Task}') | The callback to be invoked when the command is executed. |

<a name='P-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-CanExecute'></a>
### CanExecute `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-UI-AsyncCommand-ExecuteAsync-System-Object,System-Threading-CancellationToken-'></a>
### ExecuteAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ClientContext'></a>
## ClientContext `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for accessing client context JSON blob in a structured method.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContext-#ctor-System-Collections-Generic-IReadOnlyDictionary{System-String,System-Object},Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(contextProperties,extensibility) `constructor`

##### Summary

Initializes a new instance of the [ClientContext](#T-Microsoft-VisualStudio-Extensibility-ClientContext 'Microsoft.VisualStudio.Extensibility.ClientContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextProperties | [System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{System.String,System.Object}') | Client context bag passed by remote commands provider. |
| extensibility | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility object instance. |

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-Extensibility'></a>
### Extensibility `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-Item-System-String-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContext-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

*Inherit from parent.*

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContext-AsDictionary'></a>
### AsDictionary() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContext-DisposeManagedResources'></a>
### DisposeManagedResources() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-CollectionChangedDelegate'></a>
## CollectionChangedDelegate `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher

##### Summary

Delegate type for the [](#E-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-CollectionChanged 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.CollectionChanged') event. This is equivalent to
 [NotifyCollectionChangedEventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.NotifyCollectionChangedEventHandler 'System.Collections.Specialized.NotifyCollectionChangedEventHandler').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [T:Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.CollectionChangedDelegate](#T-T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-CollectionChangedDelegate 'T:Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.CollectionChangedDelegate') | Identifier of the uniquely identifiable object that was updated. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter'></a>
## DataContextFormatter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-AsyncCommandCanExecuteGetter'></a>
### AsyncCommandCanExecuteGetter `constants`

##### Summary

Getter method for [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.CanExecute').

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-BoolSerializer'></a>
### BoolSerializer `constants`

##### Summary

[SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') for `bool`.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Instance'></a>
### Instance `constants`

##### Summary

Singleton instance of [DataContextFormatter](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter').

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeMethods'></a>
### SerializeMethods `constants`

##### Summary

[SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') cache.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-TypeConversions'></a>
### TypeConversions `constants`

##### Summary

Types that are converted to a different data type before being serialized.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Deserialize-MessagePack-MessagePackReader@,MessagePack-MessagePackSerializerOptions-'></a>
### Deserialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetAndCacheTypeSerializer-System-Type-'></a>
### GetAndCacheTypeSerializer(type) `method`

##### Summary

Generates the [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') for `type` and caches it.

##### Returns

A [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegate and other information about `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | `type` for which the serialize method should be generated. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetSerializeMethodForCollection-System-Type-'></a>
### GetSerializeMethodForCollection(type) `method`

##### Summary

Generates the [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') for collection types.

##### Returns

A [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegate or `null` if `type` is
not a collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | `type` for which the serialize method should be generated. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetSerializeMethodForMapObject-System-Type-'></a>
### GetSerializeMethodForMapObject(type) `method`

##### Summary

Generates the [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') for complex types that are serialized as a MessagePack map.

##### Returns

A [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegate.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | `type` for which the serialize method should be generated. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetTypeSerializer-System-Type,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@,System-Boolean@-'></a>
### GetTypeSerializer(type,omitNullableHeader,dataTypeCode,isSimpleValueTypeNullable) `method`

##### Summary

Generates the [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') for `type`.

##### Returns

A [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegate and other information about `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | `type` for which the serialize method should be generated. |
| omitNullableHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | When `true` the returned delegate will write nullable
values as Nil or their non-nullable equivalent. This is used when writing [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1'). |
| dataTypeCode | [Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@](#T-Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@ 'Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@') | Returns the [DataTypeCode](#T-Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode 'Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode') corresponding to `type`
or [Invalid](#F-Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode-Invalid 'Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode.Invalid'). |
| isSimpleValueTypeNullable | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') | Returns whether `type` is a
[Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') where T is a type having a corresponding by [DataTypeCode](#T-Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode 'Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode'). |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-IsCollection-System-Type,System-Type@,System-Reflection-MethodInfo@-'></a>
### IsCollection(type,itemType,getCountMethod) `method`

##### Summary

Evaluates if `type` should be serialized as a collection.

##### Returns

Whether `type` should be serialized as a collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') to be evaluated. |
| itemType | [System.Type@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type@ 'System.Type@') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the collection items if the collection implements
[ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1'), `null` otherwise. |
| getCountMethod | [System.Reflection.MethodInfo@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo@ 'System.Reflection.MethodInfo@') | The method that returns the Count for the collection. |

##### Remarks

Objects implementing [ICollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ICollection 'System.Collections.ICollection') or [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') are serialized as
collections.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-Serialize-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions-'></a>
### Serialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeAsXamlFragment-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions-'></a>
### SerializeAsXamlFragment(writer,value,options) `method`

##### Summary

Serialization method for objects that can be written to XAML by [XamlWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Markup.XamlWriter 'System.Windows.Markup.XamlWriter').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeComplexNullable-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod-'></a>
### SerializeComplexNullable(writer,value,options,serializeMethod) `method`

##### Summary

Serialization method for nullable types not supported by [SimpleDataTypesSerializer](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer'). This is
used by [GetTypeSerializer](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetTypeSerializer-System-Type,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@,System-Boolean@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetTypeSerializer(System.Type,System.Boolean,Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@,System.Boolean@)') to construct [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |
| serializeMethod | [Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') | Delegate to be used for serializing the object value when not
`null`. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeComplexObjectWithMetadata-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeNonNullMethod,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode-'></a>
### SerializeComplexObjectWithMetadata(writer,value,options,fieldCode,isUniquelyIdentifiable,serializeMethod,collectionDataTypeCode) `method`

##### Summary

Serialization method for uniquely identifiable objects. This is used by [GetTypeSerializer](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetTypeSerializer-System-Type,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@,System-Boolean@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetTypeSerializer(System.Type,System.Boolean,Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@,System.Boolean@)') to
 construct [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegates.

 This method may write the full object or only a [Reference](#F-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode-Reference 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode.Reference') depending upon
 whether the object has already been serialized before and on
 [ForceRootSerialization](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-ForceRootSerialization 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.ForceRootSerialization').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |
| fieldCode | [Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode](#T-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode') | Either [Object](#F-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode-Object 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode.Object'),
 [Command](#F-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode-Command 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode.Command'),
 [Collection](#F-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode-Collection 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode.Collection') or
 [NullableCollection](#F-Microsoft-Internal-VisualStudio-RemoteUI-SerializerFieldCode-NullableCollection 'Microsoft.Internal.VisualStudio.RemoteUI.SerializerFieldCode.NullableCollection'). |
| isUniquelyIdentifiable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether `value` is a uniquely identifiable object: a
 non-empty reference type object. |
| serializeMethod | [Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeNonNullMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeNonNullMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeNonNullMethod') | Delegate to be used for serializing the object value. |
| collectionDataTypeCode | [Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode](#T-Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode 'Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode') | Type of entries when serializing an [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') or an
 [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') of nullable values. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeConvertible-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,System-Func{System-Object,System-Object},Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod-'></a>
### SerializeConvertible(writer,value,options,convertMethod,serializeMethod) `method`

##### Summary

Serialization method for types that should be converted to a different type before serialization.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |
| convertMethod | [System.Func{System.Object,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Object,System.Object}') | Delegate that will be used to perform the conversion. |
| serializeMethod | [Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') | Delegate that will be used to perform the serialization of the converted
value. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-SerializeXamlFragment-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions-'></a>
### SerializeXamlFragment(writer,value,options) `method`

##### Summary

Serialization method for [XamlFragment](#T-Microsoft-VisualStudio-Extensibility-UI-XamlFragment 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment') objects.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-WriteClass-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions,System-Collections-Generic-Dictionary{System-String,System-ValueTuple{System-Reflection-MethodInfo,Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod}}-'></a>
### WriteClass(writer,value,options,propertySerializers) `method`

##### Summary

Serialization method for reference types objects with fields. This is used by
[GetTypeSerializer](#M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-GetTypeSerializer-System-Type,System-Boolean,Microsoft-Internal-VisualStudio-RemoteUI-DataTypeCode@,System-Boolean@- 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatter.GetTypeSerializer(System.Type,System.Boolean,Microsoft.Internal.VisualStudio.RemoteUI.DataTypeCode@,System.Boolean@)') to construct [SerializeMethod](#T-Microsoft-Internal-VisualStudio-RemoteUI-SimpleDataTypesSerializer-SerializeMethod 'Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod') delegates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |
| propertySerializers | [System.Collections.Generic.Dictionary{System.String,System.ValueTuple{System.Reflection.MethodInfo,Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.ValueTuple{System.Reflection.MethodInfo,Microsoft.Internal.VisualStudio.RemoteUI.SimpleDataTypesSerializer.SerializeMethod}}') | Properties of the type to be serialized and how to serialize them. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatter-WriteUntypedField-MessagePack-MessagePackWriter@,System-Object,MessagePack-MessagePackSerializerOptions-'></a>
### WriteUntypedField(writer,value,options) `method`

##### Summary

Serialization method for property values not having a sealed type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [MessagePack.MessagePackWriter@](#T-MessagePack-MessagePackWriter@ 'MessagePack.MessagePackWriter@') | MessagePack writer to which `value` is serialized. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be serialized. |
| options | [MessagePack.MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') | [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') used for the serialization. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver'></a>
## DataContextFormatterResolver `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver-Instance'></a>
### Instance `constants`

##### Summary

Singleton instance of [DataContextFormatterResolver](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.DataContextFormatterResolver').

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-DataContextFormatterResolver-GetFormatter``1'></a>
### GetFormatter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions'></a>
## DataContextSerializerOptions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

MessagePack options used to serialize data sent by the extension to Visual studio.

 This [MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') doesn't support deserialization and only support serialization of
 values or references cast to [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')`object`.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-#ctor-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher,System-Boolean-'></a>
### #ctor(dispatcher,forceRootSerialization) `constructor`

##### Summary

Initializes a new instance of the [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher') | An instance of [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher'). |
| forceRootSerialization | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the serialized data should always include the full content of the
first uniquely identifiable object encountered even if such object has already an assigned id and would
normally be serialized as a reference. |

##### Remarks

When creating an instance of [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') setting
`forceRootSerialization` to `true`, an equivalent
[DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') that doesn't force full serialization for the root object can
be retrieved from [NonForceRootOptions](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-NonForceRootOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.NonForceRootOptions').

<a name='P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-Dispatcher'></a>
### Dispatcher `property`

##### Summary

Gets the [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') to be used during serialization.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-ForceRootSerialization'></a>
### ForceRootSerialization `property`

##### Summary

Gets a value indicating whether the serialized data should always include the full content of the first uniquely
identifiable object encountered even if such object has already an assigned id and would normally be serialized
as a reference.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-NonForceRootOptions'></a>
### NonForceRootOptions `property`

##### Summary

Gets an equivalent [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions') having [ForceRootSerialization](#P-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-ForceRootSerialization 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions.ForceRootSerialization') set
to `false`.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-HasSerializableProperties-System-Type-'></a>
### HasSerializableProperties(type) `method`

##### Summary

Evaluates if `type` will have its properties serialized when using
 [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions').

##### Returns

Whether the object will have its properties serialized.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') to evaluate. |

##### Remarks

If the type isn't marked with a [DataContractAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataContractAttribute 'System.Runtime.Serialization.DataContractAttribute') we serialize it as an empty object.

 Types implementing [IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand') are always serializable.

 [DataContractAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataContractAttribute 'System.Runtime.Serialization.DataContractAttribute') has [Inherited](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.AttributeUsageAttribute.Inherited 'System.AttributeUsageAttribute.Inherited') set to
 `false` so we don't consider a [DataContractAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataContractAttribute 'System.Runtime.Serialization.DataContractAttribute') defined in a base class.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-IsCollection-System-Type,System-Type@-'></a>
### IsCollection(type,itemType) `method`

##### Summary

Evaluates if `type` will be serialized as a collection.

##### Returns

Whether `type` will be serialized as a collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') to evaluate. |
| itemType | [System.Type@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type@ 'System.Type@') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the collection items if the collection implements
[ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1'), `null` otherwise. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions-IsPropertySerializable-System-Type,System-Reflection-PropertyInfo,System-Reflection-MethodInfo@,System-Boolean-'></a>
### IsPropertySerializable(owningType,property,getter,includeSpecialProperties) `method`

##### Summary

Evaluates if `property` should be serialized when using
 [DataContextSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextSerializerOptions').

##### Returns

Whether the property should be serialized.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owningType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type owning `property`. |
| property | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') | The property to evaluate. |
| getter | [System.Reflection.MethodInfo@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo@ 'System.Reflection.MethodInfo@') | If the property should be serialized, returns its getter method. |
| includeSpecialProperties | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether include properties, like [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.CanExecute'),
 that are always considered serializable even if they lack [DataMemberAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataMemberAttribute 'System.Runtime.Serialization.DataMemberAttribute'). |

##### Remarks

We only serialize properties having a [DataMemberAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataMemberAttribute 'System.Runtime.Serialization.DataMemberAttribute').

 [DataMemberAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataMemberAttribute 'System.Runtime.Serialization.DataMemberAttribute') has [Inherited](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.AttributeUsageAttribute.Inherited 'System.AttributeUsageAttribute.Inherited') set to
 `false` so we don't consider a [DataMemberAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.DataMemberAttribute 'System.Runtime.Serialization.DataMemberAttribute') defined for an overridden
 property in a base class.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter'></a>
## DataContextUpdateFormatter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-Instance'></a>
### Instance `constants`

##### Summary

Singleton instance of [DataContextUpdateFormatter](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatter').

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-DeserializeComplexObject-MessagePack-MessagePackReader@,MessagePack-MessagePackSerializerOptions-'></a>
### DeserializeComplexObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-GetEmptyObject'></a>
### GetEmptyObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatter-GetReference-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,MessagePack-MessagePackSerializerOptions-'></a>
### GetReference() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver'></a>
## DataContextUpdateFormatterResolver `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions

<a name='F-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver-Instance'></a>
### Instance `constants`

##### Summary

Singleton instance of [DataContextUpdateFormatterResolver](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions.DataContextUpdateFormatterResolver').

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-DataContextUpdateFormatterResolver-GetFormatter``1'></a>
### GetFormatter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions'></a>
## DataContextUpdateSerializerOptions `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

MessagePack options used to deserialize data sent by Visual studio to the extension.

 This [MessagePackSerializerOptions](#T-MessagePack-MessagePackSerializerOptions 'MessagePack.MessagePackSerializerOptions') doesn't support serialization and only support
 deserialization to target [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')`object`.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-#ctor-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-'></a>
### #ctor(dispatcher) `constructor`

##### Summary

Initializes a new instance of the [DataContextUpdateSerializerOptions](#T-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions 'Microsoft.VisualStudio.Extensibility.UI.DataContextUpdateSerializerOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher') | An instance of [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher'). |

<a name='P-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-Dispatcher'></a>
### Dispatcher `property`

##### Summary

Gets the [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') to be used during deserialization.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-DataContextUpdateSerializerOptions-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory'></a>
## DefaultJsonServiceFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.
This default factory uses either the service moniker name as the type name, or type information from [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute') attribute
and creates an instance using dependency injection (TBD) and uses JSON serialization.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultJsonServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory'></a>
## DefaultMessagePackServiceFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.
This default factory uses either the service moniker name as the type name, or type information from [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute') attribute
and creates an instance using dependency injection and uses MessagePack serialization.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DefaultMessagePackServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject'></a>
## DisposableObject `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

An helper for implementating disposable instances following the recommended pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object has been disposed once, protects against double disposal.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the current object then suppresses further finalization.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Standard virtual overload for [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable') pattern.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `True` means this is a call to [Dispose](#M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Dispose 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject.Dispose').
`False` means it has been called from the finalizer. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeManagedResources'></a>
### DisposeManagedResources() `method`

##### Summary

Allows derived classes to provide custom dispose handling for managed resources.

##### Parameters

This method has no parameters.

##### Remarks

Derived classes are expected to override this method to dispose their managed resources, then call the base class.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-DisposeNativeResources'></a>
### DisposeNativeResources() `method`

##### Summary

Allows derived classes to provide custom dispose handling for native resources.

##### Parameters

This method has no parameters.

##### Remarks

Derived classes are expected to override this method to dispose their native resources, then call the base class.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject-Finalize'></a>
### Finalize() `method`

##### Summary

Finalizes an instance of the [DisposableObject](#T-Microsoft-VisualStudio-Extensibility-Helpers-DisposableObject 'Microsoft.VisualStudio.Extensibility.Helpers.DisposableObject') class.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary'></a>
## EmptyResourceDictionary `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A resource string dictionatry that is empty, always throws.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [EmptyResourceDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.EmptyResourceDictionary') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-Instance'></a>
### Instance `property`

##### Summary

Gets the singleton instance.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-EmptyResourceDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken-'></a>
### GetStringResourceAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry'></a>
## Entry `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-KeyHashCode'></a>
### KeyHashCode `constants`

##### Summary

Cached copy of secondary key's hashcode.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-NextKey'></a>
### NextKey `constants`

##### Summary

Index of next entry for the current secondary-key bucket, -1 if last.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-NextRef'></a>
### NextRef `constants`

##### Summary

Index of next entry for the current primary-key bucket, -1 if last.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-RefHasCode'></a>
### RefHasCode `constants`

##### Summary

Cached copy of primary key's hashcode.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-Value'></a>
### Value `constants`

##### Summary

The value.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Entry-WeakReference'></a>
### WeakReference `constants`

##### Summary

The key.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint'></a>
## ExtensibilityPoint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary-'></a>
### #ctor(serviceBroker,localServiceProvider,resourceDictionary) `constructor`

##### Summary

Initializes a new instance of the [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to use for the extensibility wrapper. |
| localServiceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for local services. |
| resourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resource dictionary instance to utilize for accessing localized resources. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-#ctor-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### #ctor(extensibilityPoint) `constructor`

##### Summary

Initializes a new instance of the [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Another instance of extensibility point object to use for initialization. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object is disposed.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider'></a>
### LocalServiceProvider `property`

##### Summary

Gets the local service provider.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ResourceDictionary'></a>
### ResourceDictionary `property`

##### Summary

Gets the resource dictionary instance for querying localized strings.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker'></a>
### ServiceBroker `property`

##### Summary

Gets the underlying service broker instance.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

Gets the service broker client instance that can be used to query for brokered services.

##### Remarks

This instance is backed by the same [ServiceBroker](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ServiceBroker 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.ServiceBroker') instance and will be disposed at the same time.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-TraceSource'></a>
### TraceSource `property`

##### Summary

Gets the trace source instance to utilize for logging.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-CreateChildInstance``1'></a>
### CreateChildInstance\`\`1() `method`

##### Summary

Creates an instance of T based on this instances of services.

##### Returns

an instance of T.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | a type inheriting from [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-Dispose-System-Boolean-'></a>
### Dispose(isDisposing) `method`

##### Summary

Disposes the instane and underlying proxies.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDisposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-ThrowIfDisposed'></a>
### ThrowIfDisposed() `method`

##### Summary

Throws if object is disposed.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager'></a>
## ExtensibilityPointManager `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-String,System-Func{``0}-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,key,factory) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional key to identify the instance in addition to type. |
| factory | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | Factory to create the new instance. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint,System-Func{``0}-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint,factory) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |
| factory | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | Factory to create the new instance. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensibilityPointManager-GetOrCreateExtensibilityPoint``1-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-'></a>
### GetOrCreateExtensibilityPoint\`\`1(extensibilityPoint) `method`

##### Summary

Attaches an [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') instance to another [ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') object
for lifetime tracking.
This method creates T via dependency injection using the [LocalServiceProvider](#P-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint-LocalServiceProvider 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint.LocalServiceProvider').

##### Returns

The newly created or already attached instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extensibilityPoint | [Microsoft.VisualStudio.Extensibility.ExtensibilityPoint](#T-Microsoft-VisualStudio-Extensibility-ExtensibilityPoint 'Microsoft.VisualStudio.Extensibility.ExtensibilityPoint') | Instance to attach the new object. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the extensibility point being returned. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionCore'></a>
## ExtensionCore `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Base class for an extension that can host multiple service instances. This class is inteded for internal use only, extension developers should instead
inherit from Microsoft.VisualStudio.Extensibility.Extension.

##### Remarks

The instance act as the shared instance similar to previous VSPackage concept.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceDictionary'></a>
### ResourceDictionary `property`

##### Summary

Gets the resource dictionary instance that can be passed to services.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Gets the resource manager instance to be used for localization.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceFactoryMap'></a>
### ServiceFactoryMap `property`

##### Summary

Gets the service factory map from moniker to factory type.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionCore-ServiceProvider'></a>
### ServiceProvider `property`

##### Summary

Gets the service provider used for querying extension host services and local services.

##### Remarks

This provider is in-process only and does not include brokered remote services.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-CreateAsync-System-IServiceProvider,Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,Microsoft-ServiceHub-Framework-IServiceBroker,Microsoft-ServiceHub-Framework-Services-AuthorizationServiceClient,System-Threading-CancellationToken-'></a>
### CreateAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetFactory-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetFactory(serviceMoniker) `method`

##### Summary

Gets the service factory for the service moniker requested.

##### Returns

an instance of [IServiceFactory](#T-Microsoft-VisualStudio-Extensibility-IServiceFactory 'Microsoft.VisualStudio.Extensibility.IServiceFactory') that should be able to create the service instance for the requested moniker.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker requested. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when a factory registration is not present for the queried moniker. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionCore-InitializeServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### InitializeServices(serviceCollection) `method`

##### Summary

Initializes the service collection used in creating service factories.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Service collection to build. |

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods'></a>
## ExtensionMethods `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

Helper extension methods.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-AsStringResourceDictionary-System-Resources-ResourceManager-'></a>
### AsStringResourceDictionary(resman) `method`

##### Summary

Creates a string resource dictionary from a [ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') instance.

##### Returns

an instance of [IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resman | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') | Resource manager instance. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ExtensionMethods-CloneAsNonDisposable-Microsoft-ServiceHub-Framework-IServiceBroker-'></a>
### CloneAsNonDisposable(serviceBroker) `method`

##### Summary

Create a clone of [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') that does not implement any other interface including [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable').
This clone could be used to avoid accidental disposal.

##### Returns

An [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') that does not implement [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Service broker instance to clone. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionPart'></a>
## ExtensionPart `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Base class for services or parts to be returned from service factories.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-#ctor-Microsoft-VisualStudio-Extensibility-ExtensionCore,Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-'></a>
### #ctor(container,extensibilityObject) `constructor`

##### Summary

Initializes a new instance of the [ExtensionPart](#T-Microsoft-VisualStudio-Extensibility-ExtensionPart 'Microsoft.VisualStudio.Extensibility.ExtensionPart') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [Microsoft.VisualStudio.Extensibility.ExtensionCore](#T-Microsoft-VisualStudio-Extensibility-ExtensionCore 'Microsoft.VisualStudio.Extensibility.ExtensionCore') | Extension instance that can be used for sharing state across parts. |
| extensibilityObject | [Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') | Extensibility instance to be used by the service implementation. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Container'></a>
### Container `property`

##### Summary

Gets the container instance that hosts this and related parts.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the extensibility instance for this service.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPart-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the object is disposed.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-AttachServiceScope-Microsoft-Extensions-DependencyInjection-IServiceScope-'></a>
### AttachServiceScope(serviceScope) `method`

##### Summary

Attaches a service scope to follow the lifetime of this extension part.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceScope | [Microsoft.Extensions.DependencyInjection.IServiceScope](#T-Microsoft-Extensions-DependencyInjection-IServiceScope 'Microsoft.Extensions.DependencyInjection.IServiceScope') | Service scope to dispose when the part is disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-Dispose-System-Boolean-'></a>
### Dispose(isDisposing) `method`

##### Summary

Disposes the instane and underlying services.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isDisposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If false only native resources should be disposed. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeAsync-System-Threading-CancellationToken-'></a>
### InitializeAsync(cancellationToken) `method`

##### Summary

Provides an asynchronous way for extension parts to initialize their fields.
This method is called before the instance is handed to Visual Studio.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPart-InitializeInternalAsync-System-Threading-CancellationToken-'></a>
### InitializeInternalAsync(cancellationToken) `method`

##### Summary

Provides an asynchronous way for extension parts to initialize their fields.
This method is called before the instance is handed to Visual Studio.

##### Returns

a Task indicating completion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token to monitor. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand'></a>
## IAsyncCommand `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

An object implementing [IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand') in the DataContext of a control is converted to a
[ICommand](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.ICommand 'System.Windows.Input.ICommand') in the Visual Studio process and can be databound in xaml.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute'></a>
### CanExecute `property`

##### Summary

Gets a value indicating whether the command can execute in its current state.

##### Remarks

If [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.CanExecute') is not constant, implement [INotifyPropertyChanged](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged') and raise
[](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged') when the value of [CanExecute](#P-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-CanExecute 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand.CanExecute') changes.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand-ExecuteAsync-System-Object,System-Threading-CancellationToken-'></a>
### ExecuteAsync(parameter,cancellationToken) `method`

##### Summary

Defines the method to be called when the command is invoked.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') tracking the completion of the async call execution.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Data used by the command. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

<a name='T-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext'></a>
## IClientContext `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Definitions

##### Summary

Container for client context at the time of a command invocation.

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Extensibility'></a>
### Extensibility `property`

##### Summary

Gets the extensibility instance that can be used by extension methods extending the client context.

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-Item-System-String-'></a>
### Item `property`

##### Summary

Gets the value of client context category.

##### Returns

The category values in deserialized string format.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Category identifier. |

<a name='P-Microsoft-VisualStudio-Extensibility-Definitions-IClientContext-ServiceBrokerClient'></a>
### ServiceBrokerClient `property`

##### Summary

Gets the service broker instance that can be used by extension methods extending the client context.

<a name='T-Microsoft-Internal-VisualStudio-Extensibility-Definitions-IClientContextPrivate'></a>
## IClientContextPrivate `type`

##### Namespace

Microsoft.Internal.VisualStudio.Extensibility.Definitions

##### Summary

Container for client context at the time of a command invocation.

<a name='M-Microsoft-Internal-VisualStudio-Extensibility-Definitions-IClientContextPrivate-AsDictionary'></a>
### AsDictionary() `method`

##### Summary

Gets the context as a dictionary instance.

##### Returns

A read only dictionary instance representing the client context.

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher'></a>
## INotificationsDispatcher `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Interface describing the behavior of [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') to support unit testing.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-GetMetadataOrRegisterObject-System-Object-'></a>
### GetMetadataOrRegisterObject(obj) `method`

##### Summary

Returns the metadata data associated with `obj` and registers `obj`, creating
new attached data, if not registered already.

##### Returns

The metadata attached to `obj` and whether `obj` was newly
registered by this call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to retrieve attached data for and to register if necessary. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-GetObject-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId-'></a>
### GetObject(id) `method`

##### Summary

Retrieves an object based on its associated id.

##### Returns

The object to which `id` is associated.

 If `id` cannot be found the method returns `null`, the corresponding object
 may have been garbage collected.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId 'Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId') | The unique identifier previously returned by [GetMetadataOrRegisterObject](#M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-GetMetadataOrRegisterObject-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.INotificationsDispatcher.GetMetadataOrRegisterObject(System.Object)'). |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-INotificationsDispatcher-UpdateCollection-System-Object,System-Int32,System-Object,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion}-'></a>
### UpdateCollection(obj,index,value,version) `method`

##### Summary

Handles the update, initiated by Visual Studio, of an entry of a uniquely identifiable collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to be udpated. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the collection entry to be updated. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value to assign to the collection entry. |
| version | [System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion}') | Current version of the object. |

<a name='T-Microsoft-VisualStudio-Extensibility-IServiceFactory'></a>
## IServiceFactory `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Constructs services registered in an extension based on the descriptors in metadata.

<a name='M-Microsoft-VisualStudio-Extensibility-IServiceFactory-CreateAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-IServiceProvider,System-Type,System-Type-'></a>
### CreateAsync(serviceMoniker,activationOptions,serviceProvider,instanceType,interfaceType) `method`

##### Summary

Creates the service instance of T when requested.

##### Returns

a Task returning instance of the service object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker that was requested. |
| activationOptions | [Microsoft.ServiceHub.Framework.ServiceActivationOptions](#T-Microsoft-ServiceHub-Framework-ServiceActivationOptions 'Microsoft.ServiceHub.Framework.ServiceActivationOptions') | Service activation options. |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for extension host services including service broker assigned to instance being created. |
| instanceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional instance type if it was specified in the service registration. |
| interfaceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Optional interface type if it was specified in the service registration to indicate the interface being queried. |

<a name='M-Microsoft-VisualStudio-Extensibility-IServiceFactory-GetServiceDescriptor-Microsoft-ServiceHub-Framework-ServiceMoniker-'></a>
### GetServiceDescriptor(serviceMoniker) `method`

##### Summary

Gets the description of a service.

##### Returns

An instance of a [ServiceRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceRpcDescriptor').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceMoniker | [Microsoft.ServiceHub.Framework.ServiceMoniker](#T-Microsoft-ServiceHub-Framework-ServiceMoniker 'Microsoft.ServiceHub.Framework.ServiceMoniker') | Service moniker that was requested. |

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc'></a>
## MessageContextJsonRpc `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

A JsonRpc implementation that uses a MessageVersionContext to order incoming messages.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc-#ctor-StreamJsonRpc-IJsonRpcMessageHandler,Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext-'></a>
### #ctor(messageHandler,messageVersionContext) `constructor`

##### Summary

Initializes a new instance of the [MessageContextJsonRpc](#T-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc 'Microsoft.VisualStudio.Extensibility.Framework.MessageContextJsonRpc') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageHandler | [StreamJsonRpc.IJsonRpcMessageHandler](#T-StreamJsonRpc-IJsonRpcMessageHandler 'StreamJsonRpc.IJsonRpcMessageHandler') | JsonRpc message handler instance. |
| messageVersionContext | [Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext](#T-Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext 'Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext') | Message version context instance to utilize for ordering incoming messages. |

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MessageContextJsonRpc-DispatchRequestAsync-StreamJsonRpc-Protocol-JsonRpcRequest,StreamJsonRpc-TargetMethod,System-Threading-CancellationToken-'></a>
### DispatchRequestAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection'></a>
## MultiTargetingRpcConnection `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

Specialized [JsonRpcConnection](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection') that extends the default implementation
with support for providing secondary RPC targets via interfaces annotated with
[ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute').

##### Remarks

This component enables C# APIs for extensions to be implemented in terms of interfaces,
kept entirely separate from the object implementing the RPC contract, enables a single
extension to implement multiple RPC contracts, and makes the conversion from RPC to C#
types seamless for the extender.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection-'></a>
### #ctor(jsonRpcConnection) `constructor`

##### Summary

Initializes a new instance of the [MultiTargetingRpcConnection](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingRpcConnection') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonRpcConnection | [Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor-JsonRpcConnection 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor.JsonRpcConnection') | The JsonRpc connection. |

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingRpcConnection-AddLocalRpcTarget-System-Object-'></a>
### AddLocalRpcTarget() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor'></a>
## MultiTargetingServiceJsonRpcDescriptor `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

Specialized [ServiceJsonRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor') that extends the default implementation
with support for providing secondary RPC targets via interfaces annotated with
[ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute').

##### Remarks

This component enables C# APIs for extensions to be implemented in terms of interfaces,
kept entirely separate from the object implementing the RPC contract, enables a single
extension to implement multiple RPC contracts, and makes the conversion from RPC to C#
types seamless for the extender.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-#ctor-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor,Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext-'></a>
### #ctor(innerDescriptor,messageVersionContext) `constructor`

##### Summary

Initializes a new instance of the [MultiTargetingServiceJsonRpcDescriptor](#T-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor 'Microsoft.VisualStudio.Extensibility.Framework.MultiTargetingServiceJsonRpcDescriptor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| innerDescriptor | [Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor](#T-Microsoft-ServiceHub-Framework-ServiceJsonRpcDescriptor 'Microsoft.ServiceHub.Framework.ServiceJsonRpcDescriptor') | The original descriptor. |
| messageVersionContext | [Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext](#T-Microsoft-Internal-VisualStudio-Extensibility-Framework-MessageVersionContext 'Microsoft.Internal.VisualStudio.Extensibility.Framework.MessageVersionContext') | Message version context to utilize. |

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Remarks

Needed to ensure that this object survives ServiceHub's attempts
to re-wrap it for [TraceSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Diagnostics.TraceSource 'System.Diagnostics.TraceSource') configuration.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-ConstructRpcConnection-System-IO-Pipelines-IDuplexPipe-'></a>
### ConstructRpcConnection() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Framework-MultiTargetingServiceJsonRpcDescriptor-CreateJsonRpc-StreamJsonRpc-IJsonRpcMessageHandler-'></a>
### CreateJsonRpc() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata'></a>
## NotificationDispatcherObjectMetadata `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Metadata associated by [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') with an object when it is first serialized.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata-#ctor-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [NotificationDispatcherObjectMetadata](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherObjectMetadata') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId 'Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId') | Unique identifier associated with the object. |

<a name='P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherObjectMetadata-Id'></a>
### Id `property`

##### Summary

Gets the unique identifier associated with the object.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata'></a>
## NotificationDispatcherVersionedObjectMetadata `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Metadata associated by [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') with a versioned object when it is first serialized.

##### Remarks

This class is not threadsafe, use `lock` on the instance of
[NotificationDispatcherVersionedObjectMetadata](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata') before changing its properties.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-#ctor-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [NotificationDispatcherVersionedObjectMetadata](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId 'Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId') | Unique identifier associated with the object. |

<a name='P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-BeingUpdated'></a>
### BeingUpdated `property`

##### Summary

Gets or sets a value indicating whether the curresponding object is currently being updated as an effect of a
 [SetCollectionEntryAsync](#M-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControl-SetCollectionEntryAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Int32,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion},System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControl.SetCollectionEntryAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,System.Int32,Microsoft.VisualStudio.RpcContracts.RemoteUI.MessagePackFragment,System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion},System.Threading.CancellationToken)')
 notification.

 We don't need to send
 [RemoteCollectionChangedAsync](#M-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControlClient-RemoteCollectionChangedAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion},Microsoft-VisualStudio-RpcContracts-RemoteUI-RemoteCollectionChanges,System-Threading-CancellationToken- 'Microsoft.VisualStudio.RpcContracts.RemoteUI.IRemoteUserControlClient.RemoteCollectionChangedAsync(Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId,System.Nullable{Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectVersion},Microsoft.VisualStudio.RpcContracts.RemoteUI.RemoteCollectionChanges,System.Threading.CancellationToken)')
 notifications for an object having [BeingUpdated](#P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-BeingUpdated 'Microsoft.VisualStudio.Extensibility.UI.NotificationDispatcherVersionedObjectMetadata.BeingUpdated') set to `true`.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-NotificationDispatcherVersionedObjectMetadata-Version'></a>
### Version `property`

##### Summary

Gets or sets the current version of the object.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher'></a>
## NotificationsDispatcher `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Keeps a registry of uniquely identifiable objects that were serialized and sent by the extension to Visual Studio.

 When registered, each object is assigned a unique identifier and, if the object implements
 [INotifyPropertyChanged](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged'), [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') subscribes to its notifications.

 [NotificationsDispatcher](#T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher') also allows to lookup a registered object based on its unique identifier.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-nextId'></a>
### nextId `constants`

##### Summary

The [ObjectId](#T-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId 'Microsoft.VisualStudio.RpcContracts.RemoteUI.ObjectId') value that will be assigned to the next object registered by
[GetMetadataOrRegisterObject](#M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-GetMetadataOrRegisterObject-System-Object- 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.GetMetadataOrRegisterObject(System.Object)').

<a name='F-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-objectLookup'></a>
### objectLookup `constants`

##### Summary

Dictionary of objects and their metadata.

 This dictionary doesn't prevent garbage collection of its content and garbage collected objects are
 automatically removed.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-GetMetadataOrRegisterObject-System-Object-'></a>
### GetMetadataOrRegisterObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-GetObject-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId-'></a>
### GetObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-UpdateCollection-System-Object,System-Int32,System-Object,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion}-'></a>
### UpdateCollection() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotifyPropertyChangedObject'></a>
## NotifyPropertyChangedObject `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Abstract class implementing [INotifyPropertyChanged](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged') support.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-NotifyPropertyChangedObject-SetProperty``1-``0@,``0,System-String-'></a>
### SetProperty\`\`1(storage,value,propertyName) `method`

##### Summary

Sets the value of a property's backing field and raises [](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged').

 If the value of `storage` is already the same as `value`,
 `storage` is not updated and [](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged') is not raised.
 This comparison is performed with the default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1') when `T`
 is a value types or a `string`, with [ReferenceEquals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.ReferenceEquals 'System.Object.ReferenceEquals(System.Object,System.Object)')
 otherwise.

 This method should be called from inside a property setter.

##### Returns

Whether `storage` was updated and
 [](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged') raised.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| storage | [\`\`0@](#T-``0@ '``0@') | The backing field for the property being set. |
| value | [\`\`0](#T-``0 '``0') | The new value to assign to `storage`. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property being set to be used when raising
 [](#E-System-ComponentModel-INotifyPropertyChanged-PropertyChanged 'System.ComponentModel.INotifyPropertyChanged.PropertyChanged').

 This parameter should be onitted value when this method is called from a property's setter. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property being set. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-PropertyChangedDelegate'></a>
## PropertyChangedDelegate `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher

##### Summary

Delegate type for the [](#E-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-PropertyChanged 'Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.PropertyChanged') event. This is equivalent to
[PropertyChangedEventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.PropertyChangedEventHandler 'System.ComponentModel.PropertyChangedEventHandler') but also provides the new value of the property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [T:Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.PropertyChangedDelegate](#T-T-Microsoft-VisualStudio-Extensibility-UI-NotificationsDispatcher-PropertyChangedDelegate 'T:Microsoft.VisualStudio.Extensibility.UI.NotificationsDispatcher.PropertyChangedDelegate') | Identifier of the uniquely identifiable object that owns the property that was updated. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl'></a>
## RemoteUserControl `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

Abstract class from which Remote UI controls should be derived.

##### Remarks

This class automatically retrieves the xaml for the control from an embedded resource of the same name. E.g., a
class named "Foo" which extends [RemoteUserControl](#T-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl') and is defined in its project default namespace,
would automatically retrieve its xaml definition fom an embedded resource named "Foo.xaml" defined in the same
project.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-#ctor-System-Object,System-Threading-SynchronizationContext-'></a>
### #ctor(dataContext,synchronizationContext) `constructor`

##### Summary

Initializes a new instance of the [RemoteUserControl](#T-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Data context of the remote control which can be referenced from xaml through data
binding. |
| synchronizationContext | [System.Threading.SynchronizationContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.SynchronizationContext 'System.Threading.SynchronizationContext') | Optional [synchronizationContext](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-synchronizationContext 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.synchronizationContext') that the extender can
provide to ensure that [IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand') are executed and properties are read and updated from the
extension main thread. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | When `dataContext` is a value type. |

<a name='F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-extToVsSerializerOption'></a>
### extToVsSerializerOption `constants`

##### Summary

Serializer options used when serializing data sent to Visual Studio.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-extToVsSerializerOptionForceRoot'></a>
### extToVsSerializerOptionForceRoot `constants`

##### Summary

Serializer options used to when serializing data sent to Visual Studio if the object should be sent in its
entirety, not as a reference.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-notificationsDispatcher'></a>
### notificationsDispatcher `constants`

##### Summary

Notification dispatcher that handles the registration of objects in the data context of the control.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-synchronizationContext'></a>
### synchronizationContext `constants`

##### Summary

Optional [synchronizationContext](#F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-synchronizationContext 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.synchronizationContext') that the extender can provide to ensure that
[IAsyncCommand](#T-Microsoft-VisualStudio-Extensibility-UI-IAsyncCommand 'Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand') are executed and properties are read and updated from on the extension main thread.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-vsToExtSerializerOption'></a>
### vsToExtSerializerOption `constants`

##### Summary

Serializer options used when deserializing data received from Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-DataContext'></a>
### DataContext `property`

##### Summary

Gets the data context of the remote control.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-ControlLoadedAsync-System-Threading-CancellationToken-'></a>
### ControlLoadedAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether managed resources should be disposed. `disposing` should be
`true` when [Dispose](#M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-Dispose-System-Boolean- 'Microsoft.VisualStudio.Extensibility.UI.RemoteUserControl.Dispose(System.Boolean)') is called from a finalizer, `false`
otherwise. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-GetObjectAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Threading-CancellationToken-'></a>
### GetObjectAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-GetXamlAsync-System-Threading-CancellationToken-'></a>
### GetXamlAsync(cancellationToken) `method`

##### Summary

This method retrieves the xaml describing the data template of the control.

##### Returns

A xaml string describing a data template.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token for the async call. |

##### Remarks

This method can be overridden to implement a different mechanism for retrieving the control's xaml defintion.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-InitializeAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-IRemoteUserControlClient,System-Threading-CancellationToken-'></a>
### InitializeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-InvokeAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Threading-CancellationToken-'></a>
### InvokeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SerializeValueAsync-System-Object-'></a>
### SerializeValueAsync(value) `method`

##### Summary

This method serialized the value of a part of the DataContext of the control.

##### Returns

The value of the requested object or property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SetCollectionEntryAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-Int32,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Nullable{Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectVersion},System-Threading-CancellationToken-'></a>
### SetCollectionEntryAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-RemoteUserControl-SetObjectPropertyAsync-Microsoft-VisualStudio-RpcContracts-RemoteUI-ObjectId,System-String,Microsoft-VisualStudio-RpcContracts-RemoteUI-MessagePackFragment,System-Threading-CancellationToken-'></a>
### SetObjectPropertyAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary'></a>
## ResourceManagerDictionary `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A resource string dictionatry that is backed by a ResX resource manager.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-#ctor-System-Resources-ResourceManager-'></a>
### #ctor(resourceManager) `constructor`

##### Summary

Initializes a new instance of the [ResourceManagerDictionary](#T-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary 'Microsoft.VisualStudio.Extensibility.Helpers.ResourceManagerDictionary') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceManager | [System.Resources.ResourceManager](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Resources.ResourceManager 'System.Resources.ResourceManager') | Resource manager instance to utilize. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ResourceManagerDictionary-GetStringResourceAsync-System-Globalization-CultureInfo,System-String,System-Threading-CancellationToken-'></a>
### GetStringResourceAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Framework-Resources'></a>
## Resources `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Framework

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CollectionBeingUpdated'></a>
### CollectionBeingUpdated `property`

##### Summary

Looks up a localized string similar to The collection is currently being updated..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CommandIdAlreadyRegistered'></a>
### CommandIdAlreadyRegistered `property`

##### Summary

Looks up a localized string similar to Command ID is already registered..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ControlAlreadyInitialized'></a>
### ControlAlreadyInitialized `property`

##### Summary

Looks up a localized string similar to The control was already initialized..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ControlNotInitializedOrDisposed'></a>
### ControlNotInitializedOrDisposed `property`

##### Summary

Looks up a localized string similar to The control is not initialized yet or disposed already..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-CorruptedDictionary'></a>
### CorruptedDictionary `property`

##### Summary

Looks up a localized string similar to Corrupted dictionary..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-DuplicateKey'></a>
### DuplicateKey `property`

##### Summary

Looks up a localized string similar to Duplicate key..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ICommandIsNotSupported'></a>
### ICommandIsNotSupported `property`

##### Summary

Looks up a localized string similar to ICommand is not supported, please implement Microsoft.VisualStudio.Extensibility.UI.IAsyncCommand instead..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-InvalidPropertyNameForType'></a>
### InvalidPropertyNameForType `property`

##### Summary

Looks up a localized string similar to Invalid property name for current type..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-InvalidVersionString'></a>
### InvalidVersionString `property`

##### Summary

Looks up a localized string similar to Invalid version identifier..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MaximumDictionarySizeExceeded'></a>
### MaximumDictionarySizeExceeded `property`

##### Summary

Looks up a localized string similar to Maximum dictionary size exceeded..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MetadataNotAvailable'></a>
### MetadataNotAvailable `property`

##### Summary

Looks up a localized string similar to Metadata for the object is not available..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-MissingVersionUpdatingVersionedCollection'></a>
### MissingVersionUpdatingVersionedCollection `property`

##### Summary

Looks up a localized string similar to Missing version when updating versioned collection..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ObjectMetadataNotVersioned'></a>
### ObjectMetadataNotVersioned `property`

##### Summary

Looks up a localized string similar to The object's metadata is not versioned..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ObjectReferenceNotAvailable'></a>
### ObjectReferenceNotAvailable `property`

##### Summary

Looks up a localized string similar to Object reference is not available anymore..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-OnlyIListCanBeUpdatedByIndex'></a>
### OnlyIListCanBeUpdatedByIndex `property`

##### Summary

Looks up a localized string similar to Only objects implementing IList can be updated by index..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-OnlyTypeObjectSupported'></a>
### OnlyTypeObjectSupported `property`

##### Summary

Looks up a localized string similar to Only the type System.Object is supported..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-PropertyNameNull'></a>
### PropertyNameNull `property`

##### Summary

Looks up a localized string similar to PropertyName missing from property changed event..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-RemoteUserControlAreadyInitialized'></a>
### RemoteUserControlAreadyInitialized `property`

##### Summary

Looks up a localized string similar to The control has already been initialized..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeDoesntHaveProperty'></a>
### TypeDoesntHaveProperty `property`

##### Summary

Looks up a localized string similar to Type {0} doesn't have a property named {1}..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeIsBothCollectionAndCommand'></a>
### TypeIsBothCollectionAndCommand `property`

##### Summary

Looks up a localized string similar to Type {0} is not supported because it is both a collection and a command..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-TypeIsCollectionWithDataMember'></a>
### TypeIsCollectionWithDataMember `property`

##### Summary

Looks up a localized string similar to Type {0} is not supported because it is a collection with DataMember properties..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-UnsupportedDocumentMoniker'></a>
### UnsupportedDocumentMoniker `property`

##### Summary

Looks up a localized string similar to Unsupported document moniker..

<a name='P-Microsoft-VisualStudio-Extensibility-Framework-Resources-VersionConflictUpdatingCollection'></a>
### VersionConflictUpdatingCollection `property`

##### Summary

Looks up a localized string similar to Version conflict when updating collection..

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper'></a>
## ServiceBrokerNonDisposableWrapper `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A wrapper for [IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') to hide away other interfaces.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker-'></a>
### #ctor(serviceBroker) `constructor`

##### Summary

Initializes a new instance of the [ServiceBrokerNonDisposableWrapper](#T-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper 'Microsoft.VisualStudio.Extensibility.Helpers.ServiceBrokerNonDisposableWrapper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Service broker instance to wrap. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetPipeAsync-Microsoft-ServiceHub-Framework-ServiceMoniker,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken-'></a>
### GetPipeAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-ServiceBrokerNonDisposableWrapper-GetProxyAsync``1-Microsoft-ServiceHub-Framework-ServiceRpcDescriptor,Microsoft-ServiceHub-Framework-ServiceActivationOptions,System-Threading-CancellationToken-'></a>
### GetProxyAsync\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider'></a>
## TransientServiceProvider `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Helpers

##### Summary

A service provider that contains transient values and passes other types to another service provider.

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-IServiceProvider-'></a>
### #ctor(serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [TransientServiceProvider](#T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider to pass queries to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-#ctor-System-Collections-Generic-IEnumerable{System-IServiceProvider}-'></a>
### #ctor(serviceProviders) `constructor`

##### Summary

Initializes a new instance of the [TransientServiceProvider](#T-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider 'Microsoft.VisualStudio.Extensibility.Helpers.TransientServiceProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProviders | [System.Collections.Generic.IEnumerable{System.IServiceProvider}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.IServiceProvider}') | Service providers to pass queries to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton-System-Type,System-Object-'></a>
### AddSingleton(type,value) `method`

##### Summary

Adds a singleton value to the service provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the object. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value to add. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-AddSingleton``1-``0-'></a>
### AddSingleton\`\`1(value) `method`

##### Summary

Adds a singleton value to the service provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | Value to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the value. |

<a name='M-Microsoft-VisualStudio-Extensibility-Helpers-TransientServiceProvider-GetService-System-Type-'></a>
### GetService() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility'></a>
## VisualStudioExtensibility `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Provides functionality for extending Visual Studio through brokered services.

<a name='M-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility-#ctor-Microsoft-ServiceHub-Framework-IServiceBroker,System-IServiceProvider,Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary-'></a>
### #ctor(serviceBroker,serviceProvider,resourceDictionary) `constructor`

##### Summary

Initializes a new instance of the [VisualStudioExtensibility](#T-Microsoft-VisualStudio-Extensibility-VisualStudioExtensibility 'Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceBroker | [Microsoft.ServiceHub.Framework.IServiceBroker](#T-Microsoft-ServiceHub-Framework-IServiceBroker 'Microsoft.ServiceHub.Framework.IServiceBroker') | Underlying service broker instance to use for the extensibility wrapper. |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | Service provider for local services. |
| resourceDictionary | [Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary](#T-Microsoft-VisualStudio-RpcContracts-IStringResourceDictionary 'Microsoft.VisualStudio.RpcContracts.IStringResourceDictionary') | Resource dictionary instance to utilize for accessing localized resources. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3'></a>
## WeakDoubleDictionary\`3 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

A dictionary that allows looking up pairs of type [First: `TReference`, Second: `TValue`]
by two different keys. The primary key is the first object of the pair (of type `TReference`), the
secondary key is a value of type `TSecondaryKey` that can be extracted from the second object of the
pair (of type `TValue`) using a delegate provided during construction. The
[WeakDoubleDictionary\`3](#T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3') doesn't prevent garbage collection of the first object
of the pair (of type `TReference`). When a pair inside the dictionary has its first value garbage
collected, it is automatically removed from the dictionary.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSecondaryKey | The type of the secondary key. |
| TReference | The type of the primary key. |
| TValue | The type of the value associated with the primary key and which contains the secondary
key. |

##### Remarks

This is a variation of the implementation of
.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-#ctor-System-Func{`2,`0}-'></a>
### #ctor(keyExtractor) `constructor`

##### Summary

Initializes a new instance of the [WeakDoubleDictionary\`3](#T-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3 'Microsoft.VisualStudio.Extensibility.UI.WeakDoubleDictionary`3') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyExtractor | [System.Func{\`2,\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`2,`0}') | Delegate that calculates the value of the secondary key given the corresponding
value. |

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-ArraySizes'></a>
### ArraySizes `constants`

##### Summary

Possible sizes of the data storage, they need to be prime numbers.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-currentArraySize'></a>
### currentArraySize `constants`

##### Summary

Current capacity of the dictionary expressed as an index of ArraySizes.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-entries'></a>
### entries `constants`

##### Summary

Storage for the dictionary data.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-firstUnusedEntry'></a>
### firstUnusedEntry `constants`

##### Summary

-1 = empty, else index of first unused Entry.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-hasCrashed'></a>
### hasCrashed `constants`

##### Summary

Flag that detect that an exception was thrown when resizing.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-keyBuckets'></a>
### keyBuckets `constants`

##### Summary

KeyBuckets[hashcode % KeyBuckets.Length] contains index of first entry in bucket (-1 if empty).

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-keyExtractor'></a>
### keyExtractor `constants`

##### Summary

Function that allows extracting the secondary key from the value.

<a name='F-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-refBuckets'></a>
### refBuckets `constants`

##### Summary

RefBuckets[hashcode % RefBuckets.Length] contains index of first entry in bucket (-1 if empty).

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Clear'></a>
### Clear() `method`

##### Summary

Clears the dictionary.

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-GetByReferenceOrAdd-`1,System-Func{`1,`2}-'></a>
### GetByReferenceOrAdd(reference,valueFactory) `method`

##### Summary

Gets the entry corresponding to the provided primary key or creates a new one using
`valueFactory`.

##### Returns

The value associanted with `reference` and whether the entry was newly added.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reference | [\`1](#T-`1 '`1') | The primary key to use for the lookup. |
| valueFactory | [System.Func{\`1,\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`1,`2}') | The delegate used to create the value. This delegate will be invoked only when the
object is added to the dictionary and is only invoked once. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-TryGetByReference-`1,`2@-'></a>
### TryGetByReference(reference,value) `method`

##### Summary

Gets the entry corresponding to the provided primary key.

##### Returns

Whether the entry was found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reference | [\`1](#T-`1 '`1') | The primary key to use for the lookup. |
| value | [\`2@](#T-`2@ '`2@') | The value associated with `reference` or `default` if not
found. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-WeakDoubleDictionary`3-TryGetBySecondaryKey-`0,`2@,`1@-'></a>
### TryGetBySecondaryKey(key,value,reference) `method`

##### Summary

Gets the entry corresponding to the provided secondary key.

##### Returns

Whether the entry was found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | The secondary key to use for the lookup. |
| value | [\`2@](#T-`2@ '`2@') | The value associated with `key` or `default` if not found. |
| reference | [\`1@](#T-`1@ '`1@') | The primary key associated with `key` or `null` if not
found. |

<a name='T-Microsoft-VisualStudio-Extensibility-UI-XamlFragment'></a>
## XamlFragment `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.UI

##### Summary

A XAML document.

<a name='M-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-#ctor-System-String-'></a>
### #ctor(xaml) `constructor`

##### Summary

Initializes a new instance of the [XamlFragment](#T-Microsoft-VisualStudio-Extensibility-UI-XamlFragment 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xaml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The XAML document text. |

<a name='M-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-#ctor-System-Object-'></a>
### #ctor(xamlSerializable) `constructor`

##### Summary

Initializes a new instance of the [XamlFragment](#T-Microsoft-VisualStudio-Extensibility-UI-XamlFragment 'Microsoft.VisualStudio.Extensibility.UI.XamlFragment') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xamlSerializable | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to be converted to XAML using [Save](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Markup.XamlWriter.Save 'System.Windows.Markup.XamlWriter.Save(System.Object)'). |

##### Remarks

This constructor must be called from the thread owning `xamlSerializable`.

<a name='P-Microsoft-VisualStudio-Extensibility-UI-XamlFragment-Xaml'></a>
### Xaml `property`

##### Summary

Gets the XAML document.
