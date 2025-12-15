---
title: In-proc VisualStudio.Extensibility extension with MEF components and AsyncPackage sample
description: A reference sample for how VisualStudio.Extensibility in-proc extensions can include MEF components and AsyncPackages.
date: 2025-11-07
---

# Walkthrough: In-proc VisualStudio.Extensibility extension with MEF components and AsyncPackage sample

This is sample of how to write an in-proc VisualStudio.Extensibility extensions that also includes components
that are common in VSSDK extensions: `AsyncPackage`s and MEF components.

Many functions of the `AsyncPackage`, like providing commands and tool windows, have a more modern
alternative in VisualStudio.Extensibility APIs. Similarly functionalities, like classifications and taggers,
that used to require MEF have now easier to use alternatives provided by VisualStudio.Extensibility APIs.
This sample is not meant as an invitation for extenders to use `AsyncPackage`s and MEF, but as instructions
on how to correctly interact with `AsyncPackage`s and MEF components in those cases when an extender needs to
rely on APIs that don't have a VisualStudio.Extensibility alternative.

When creating such an extension, there is one important considerations to keep in mind: the
VisualStudio.Extensibility extension class, the MEF component and the AsyncPackage are all initialized
independently from each others. Before any interaction between them, the initiator must ensure that the other
component is initialized.

We start with an empty in-proc VisualStudio.Extensibility extension project as described
[here](https://learn.microsoft.com/en-us/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions).

## Adding an AsyncPackage

In a VSSDK extension, the `AsyncPackage` acts as the main entry point for the extension. This is similar to how
the `Extension` class acts as the main entry point for a VisualStudio.Extensibility extension. The `AsyncPackage`
allows the extension to provide many functionalities, including providing VS services.

To add an `AsyncPackage` to the extension, we need to add a new class that derives from `AsyncPackage` and override
the necessary methods. We will also define a new service (`MyService`) that will be provided by the package. This
service will allow the VisualStudio.Extensibility `Extension` to interact with the package guaranteeing that the
necessary initialization is performed.

```cs
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(MyPackage.PackageGuidString)]
[ProvideService(typeof(MyService), IsAsyncQueryable = true)]
public sealed class MyPackage : AsyncPackage
{
    public const string PackageGuidString = "ac1de0e2-bc69-4a63-bb7e-15f3274448c7";

    protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        this.AddService(
            typeof(MyService),
            (container, cancellationToken, serviceType) => Task.FromResult<object>(new MyService()),
            promote: true);

        return Task.CompletedTask;
    }
}
```

We also need to update the project to generate a pkgdef file for the extension:

```xml
<PropertyGroup>
  <GeneratePkgDefFile>true</GeneratePkgDefFile>
  <UseCodebase>true</UseCodebase>
</PropertyGroup>
```

And add the corresponding asset to the `.vsixmanifest` file:

```xml
<Assets>
  <Asset Type="Microsoft.VisualStudio.VsPackage" Path="AsyncPackageAndMEF.pkgdef" />
</Assets>
```

With this setup, we can add any VSSDK functionality to the `AsyncPackage` and use the `MyService` to expose
it to the VisualStudio.Extensibility part of the extension.

For example, we can add a command like this:

```cs
[VisualStudioContribution]
internal class InteractWithAsyncPackageCommand : Command
{
    private readonly AsyncServiceProviderInjection<MyService, MyService> myServiceInjection;

    public InteractWithAsyncPackageCommand(AsyncServiceProviderInjection<MyService, MyService> myServiceInjection)
    {
        this.myServiceInjection = myServiceInjection;
    }

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var myService = await this.myServiceInjection.GetServiceAsync();
        // Use myService
    }

    ...
```

By debugging the extension, we can verify that the `AsyncPackage` is only initialized when the command requests
`MyService` by calling `GetServiceAsync`.

## Adding a MEF component

To add a MEF component to the extension, we need to create a new class that is decorated with the `Export`
attribute.

```cs
[Export(typeof(MyMEFComponent))]
internal class MyMEFComponent
{
}
```

We can also add code to the `MyMEFComponent` to import other MEF components as needed (but we won't do it in
this example to keep it simple).

We must also add an asset to the `.vsixmanifest` file to declare that the extension contains MEF components:
```xml
<Assets>
  <Asset Type="Microsoft.VisualStudio.MefComponent" Path="AsyncPackageAndMEF.dll" />
</Assets>
```

Now we can retrieve the MEF component from the VisualStudio.Extensibility part of the extension:

```cs
[VisualStudioContribution]
internal class InteractWithMEFComponentCommand : Command
{
    private readonly MefInjection<MyMEFComponent> myMefComponentInjection;

    public InteractWithMEFComponentCommand(MefInjection<MyMEFComponent> myMefComponentInjection)
    {
        this.myMefComponentInjection = myMefComponentInjection;
    }

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var myMefComponent = await this.myMefComponentInjection.GetServiceAsync();
        // Use myMefComponent
    }

    ...
```

By debugging the extension, we can verify that `MyMEFComponent` is only initialized when the command requests
is by calling `GetServiceAsync`. We can also verify that the `AsyncPackage` is not initialized when the MEF
component is requested: MEF components and AsyncPackages are independent from each other.

## Communicating from the AsyncPackage to the VisualStudio.Extensibility extension

We have discussed how the VisualStudio.Extensibility part of an extension can interact with the VSSDK part
(`AsyncPackage` and MEF components). However, there might be scenarios where the `AsyncPackage` or a MEF
component need to interact with the VisualStudio.Extensibility part of the extension.

To achieve this we can expose a brokered service:

```cs
public interface IMyBrokeredService
{
    public static class Configuration
    {
        public const string ServiceName = "AsyncPackageAndMEF.MyBrokeredService";
        public static readonly Version ServiceVersion = new(1, 0);

        public static readonly ServiceMoniker ServiceMoniker = new(ServiceName, ServiceVersion);

        public static ServiceRpcDescriptor ServiceDescriptor => new ServiceJsonRpcDescriptor(
            ServiceMoniker,
            ServiceJsonRpcDescriptor.Formatters.MessagePack,
            ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader);
    }

    // Add public methods as needed
    ...
}

[VisualStudioContribution]
internal class MyBrokeredService : IMyBrokeredService
{
    private readonly VisualStudioExtensibility extensibility;

    private ProgressReporter? progressReporter;

    public MyBrokeredService(VisualStudioExtensibility extensibility)
    {
        this.extensibility = extensibility;
    }

    [VisualStudioContribution]
    public static BrokeredServiceConfiguration BrokeredServiceConfiguration
        => new(IMyBrokeredService.Configuration.ServiceName, IMyBrokeredService.Configuration.ServiceVersion, typeof(MyBrokeredService))
        {
            ServiceAudience = BrokeredServiceAudience.Local,
        };

    ...
}
```

and update the `Extension` class to register the service:
```cs
protected override void InitializeServices(IServiceCollection serviceCollection)
{
    serviceCollection.ProfferBrokeredService(MyBrokeredService.BrokeredServiceConfiguration, IMyBrokeredService.Configuration.ServiceDescriptor);
    base.InitializeServices(serviceCollection);
}
```

We also need to declare that `MyBrokeredService` is provided by this extension. This information is provided by a `BrokeredServices` entry in the pkgdef file. But we can
have that automatically generated by adding the following attribute to the `AsyncPackage` class:

```cs
[ProvideBrokeredServiceHubService(IMyBrokeredService.Configuration.ServiceName, Audience = ServiceAudience.Local | ServiceAudience.RemoteExclusiveClient)]
public sealed class MyPackage : AsyncPackage
{
```

Note that the brokered service is provided by the VisualStudio.Extensibility part of the extension. We simply leverage the ability of attributes on the `AsyncPackge` to
automatically generate the necessary pkgdef entries.

Now the `AsyncPackage` can retrieve a [proxy of the brokered service](https://microsoft.github.io/vs-streamjsonrpc/docs/proxies.html#proxy-traits) and interact with it:

```cs
var serviceBrokerContainer = await this.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
var serviceBroker = serviceBrokerContainer.GetFullAccessServiceBroker();
IMyBrokeredService? myBrokeredServiceProxy = null;
try
{
    myBrokeredServiceProxy = await serviceBroker.GetProxyAsync<IMyBrokeredService>(IMyBrokeredService.Configuration.ServiceDescriptor, this.DisposalToken);
    /// Use myBrokeredServiceProxy
}
finally
{
    (myBrokeredServiceProxy as IDisposable)?.Dispose();
}
```

If we wanted to do the same from some other part of the VSSDK extension where the `AsyncPackage` instance is
not readily available, we could modify the code above to retrieve the `IBrokeredServiceContainer` from the global
service provider:

```cs
var serviceBrokerContainer = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
```

By debugging the extension, we can verify that the VisualStudio.Extensibility part of the extension (the
`Extension` class) is only initialized when the brokered service proxy is retrieved by calling `GetProxyAsync`.

This is the proper way for the VSSDK part of the extension to use the VisualStudio.Extensibility features
provided by the `VisualStudioExtensibility` object.
