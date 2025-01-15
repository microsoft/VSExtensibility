---
title: In-proc/out-of-proc Composite Extension sample reference
description: A reference sample for in-proc/out-of-proc composite extensions
date: 2025-01-15
---

# Walkthrough: In-proc/out-of-proc Composite Extension Sample

This is sample of how to write a VisualStudio.Extensibility extensions with both in-proc and out-of-proc
components and have them communicate with each other.

The out-of-proc component is a project targeting .NET 8.0 and using the VisualStudio.Extensibility
packages.

The in-proc-component, named `CompositeExtension`, is a project targeting .NET Framework and using the
VisualStudio.Extensibility packages and, optionally, the VSSDK packages. The `CompositeExtension` project
packages the output of the out-of-proc component in its own VSIX.

While this sample doesn't demonstrate this, the in-proc-component can also include any content that is
otherwise supported by VSSDK extensions like an [AsyncPackage](https://learn.microsoft.com/visualstudio/extensibility/how-to-use-asyncpackage-to-load-vspackages-in-the-background),
[MEF components](https://github.com/microsoft/vs-mef), [project and item templates](https://learn.microsoft.com/visualstudio/extensibility/creating-custom-project-and-item-templates),
and more.

## Implementing the out-of-proc component

The out-of-proc component starts as a [standard VisualStudio.Extensibility project](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension).

### Updating the out-of-proc component's csproj file

Since the out-of-proc component will be packaged into the `CompositeExtension` VSIX, we don't need to
create a VSIX package. Let's add the following to the csproj:

```xml
<CreateVsixContainer>false</CreateVsixContainer>
```

As mentioned above, the out-of-proc component and the in-proc component have different target frameworks.
This results in them potentially having incompatible versions of the same dependencies. To avoid issues, we
will package the out-of-proc component assembly and it's dependencies in a subfolder of the VSIX. Let's add
the following to the csproj:

```xml
<AssemblyVSIXSubPath>OutOfProc</AssemblyVSIXSubPath>
```

### Other changes

One of the steps in creating an out-of-proc VisualStudio.Extensibility extension is to fill in the 
`ExtensionConfiguration`'s `Metadata` in the `Extension` class. While it's a good practice to do this, it's
worth noting that most of this information will be ignored since the `CompositeExtension` will provide this
information for the entire VSIX using a `vsixmanifest` file.

We will also [later](#merging-the-out-of-proc-components-string-resources) move the content of the `.vsextension/string-resources.json` file into `CompositeExtension`.

## Implementing the in-proc component (`CompositeExtension`)

The `CompositeExtension` project starts as a [standard VSSDK-compatible VisualStudio.Extensibility extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions).

### Updating the `CompositeExtension`'s csproj file

#### Packaging the out-of-proc component in the `CompositeExtension`'s VSIX

The first step after creating the `CompositeExtension` and filling in the information in the `source.extension.vsixmanifest`
file is to add a reference to the out-of-proc component's project so that it's output is packaged into the
`CompositeExtension`'s VSIX:

```xml
<ProjectReference Include="..\OutOfProcComponent\OutOfProcComponent.csproj">
  <ReferenceOutputAssembly>false</ReferenceOutputAssembly>
  <SetTargetFramework>TargetFramework=net8.0-windows8.0</SetTargetFramework>
  <IncludeInVSIX>true</IncludeInVSIX>
  <IncludeOutputGroupsInVSIX>ExtensionFilesOutputGroup</IncludeOutputGroupsInVSIX>
</ProjectReference>
```

You can see that `CompositeExtension` doesn't reference the out-of-proc component's assembly directly, since they
have different target frameworks. Any shared types will have to be either compiled into both assemblies, or placed
in a shared `netstandard2.0` shared dependency.

Including the `ExtensionFilesOutputGroup` output in the VSIX ensures that all the out-of-proc component's
dependencies are correctly packaged (in a separate subfolder, since the out-of-proc component declares an
`AssemblyVSIXSubPath`).

`SetTargetFramework` allows the out-of-proc component to correctly build as a dependency of `CompositeExtension`
even if the two project have different target frameworks.

#### Merging the out-of-proc component's `extension.json`

VisualStudio.Extensibility extension projects generate a file named `extension.json` which is packaged in the
VSIX and contains information about what features the extension contributes to VS.

Since the out-of-proc component is a separate project, it will generate its own `extension.json` file. The
`CompositeExtension`'s csproj needs to merge that information into its own `extension.json` file:

```xml
<ItemGroup>
  <DependentExtensionJson Include="$(BaseOutputPath)..\OutOfProcComponent\$(Configuration)\net8.0-windows8.0\.vsextension\extension.json" />
</ItemGroup>
```

You may need to adjust the `DependentExtensionJson`'s path to match your project structure. The `ProjectReference`
added [before](#packaging-the-out-of-proc-component-in-the-compositeextensions-vsix) guarantees that the
out-of-proc component's `extension.json` is generated before the `CompositeExtension`'s compilation starts.

### Merging the out-of-proc component's string resources

Lastly, we need to merge the out-of-proc component's string resources into `CompositeExtension`'s. To do this, we
simply delete the out-of-proc component's `.vsextension/string-resources.json` file and add its content to
`CompositeExtension`'s. Any further string resources referenced by the out-of-proc component code will need to be
defined in the `CompositeExtension`'s `string-resources.json` file.

Note that this only applies to string resources defined in `string-resources.json`. If localized strings are added
as `.resx` files, they will need to be defined locally in the project consuming them.

## Allowing the in-proc component to communicate with the out-of-proc component

Having a VSIX with both in-proc and out-of-proc components would not be very useful if they could not communicate.

We will now add a brokered service which allows the in-proc component to initiate a communication with the
out-of-proc component. We will [later](#allowing-the-out-of-proc-component-to-communicate-with-the-in-proc-component)
learn how to do the same in the opposite direction.

### Create a brokered service in the out-of-proc component

In the out-of-proc component's project, let's create an interface ([IOutOfProcService](./OutOfProcComponent/IOutOfProcService.cs))
defining the brokered service and a class ([OutOfProcService](./OutOfProcComponent/OutOfProcService.cs))
implementing the interface.

Note that the `OutOfProcService` has the `VisualStudioContribution` attribute, which makes it available to Visual
Studio (and to the in-proc component). It also defines a service descriptor and a service configuration that are
needed for the service to be proffered and to be consumed.

Additional methods, like [DoSomethingAsync](./OutOfProcComponent/OutOfProcService.cs) can be added to the service
and it's interface as needed. If the communication between the in-proc and out-of-proc components needs to be
bi-directional, you can also add events to the service or add [marshalable](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/rpc_marshalable_objects.md)
parameters to its methods.

### Proffer the out-of-proc brokered service

As the final step, the service has to be proffered. To do this, we add a `ProfferBrokeredService` call to the
`OnInitializeAsync` method in the out-of-proc component's `Extension` class:

```csharp
protected override void InitializeServices(IServiceCollection serviceCollection)
{
    serviceCollection.ProfferBrokeredService<OutOfProcService>();
    base.InitializeServices(serviceCollection);
}
```

This call also makes the service available to be consumed through dependency injection within the out-of-proc
component, if needed.

### Consuming the brokered service from the in-proc component

In order to consume the brokered service from the in-proc component, we need to make the ([IOutOfProcService](./OutOfProcComponent/IOutOfProcService.cs))
interface available to the in-proc component:

```xml
<ItemGroup>
  <Compile Include="..\OutOfProcComponent\IOutOfProcService.cs" Link="IOutOfProcService.cs" />
</ItemGroup>
```

As mentioned before, having a shared `netstandard2.0` dependency defining the types shared between the
in-proc and out-of-proc components is also a viable solution.

Now the in-proc component can communicate with the out-of-proc component by acquiring a proxy to the service
and calling its methods. For example, the `ExecuteCommandAsync` method in the [InProcToOutOfProcCommand](./CompositeExtension/InProcToOutOfProcCommand.cs)
calls the `DoSomethingAsync` method.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    var outOfProcService = await this.Extensibility.ServiceBroker.GetProxyAsync<IOutOfProcService>(
        IOutOfProcService.Configuration.ServiceDescriptor,
        cancellationToken);
    try
    {
        Assumes.NotNull(outOfProcService);
        await outOfProcService.DoSomethingAsync(cancellationToken);
    }
    finally
    {
        (outOfProcService as IDisposable)?.Dispose();
    }
}
```

Even if the `IOutOfProcService` interface isn't marked as disposable, it's important to dispose of the proxy
when it's not needed anymore.

It's preferrable not to hold the same proxy for a long period of time since brokered service can be restarted
under certain circumstances. For this reason, we don't add the `IOutOfProcService` to be consumed through
dependency injection and instead use `GetProxyAsync` when the service is needed.

Note that every time `GetProxyAsync` is called, a new instance of the `OutOfProcService` class is created.

## Allowing the out-of-proc component to communicate with the in-proc component

If the out-of-proc component needs to initiate a communication with the in-proc component, we can instead
(or additionally) create a brokered service in the in-proc component and have the out-of-proc component
consume it.

This is equivalent to what we did [before](#allowing-the-in-proc-component-to-communicate-with-the-out-of-component),
just in the opposite direction. A few differences are described below and are needed due to limitation of
the .NET Framework target.

### Create a brokered service in the in-proc component

We create an interface ([IInProcService](./CompositeExtension/IInProcService.cs)) and a class ([InProcService](./CompositeExtension/InProcService.cs))
implementing the interface.

Note that the `InProcService` has two `VisualStudioContribution` attribute (the second being on the
`BrokeredServiceConfiguration` property) and doesn't implement the `IBrokeredService` interface. These
differenced are due to limitations of the .NET Framework runtime.

### Proffer the in-proc brokered service

Let's then proffer the service by calling `ProfferBrokeredService` in the `OnInitializeAsync` method of the
in-proc component's `Extension` class:

```csharp
protected override void InitializeServices(IServiceCollection serviceCollection)
{
    serviceCollection.ProfferBrokeredService(
        InProcService.BrokeredServiceConfiguration,
        IInProcService.Configuration.ServiceDescriptor);
    base.InitializeServices(serviceCollection);
}
```

This call also makes the service available to be consumed through dependency injection within the in-proc
component, if needed.

The `ProfferBrokeredService` call is also slightly different than its out-of-proc counterpart because of
limitations of the .NET Framework runtime.

### Consuming the brokered service from the out-of-proc component

In order to consume the brokered service from the out-of-proc component, we need to make the
([IInOfProcService](./CompositeExtension/IInProcService.cs)) interface available to the out-of-proc
component:

```xml
<ItemGroup>
  <Compile Include="..\CompositeExtension\IInProcService.cs" Link="IInProcService.cs" />
</ItemGroup>
```

Similarly as before, the out-of-proc component can communicate with the in-proc component by acquiring a proxy
to the service, calling its methods and disposing of the proxy when done. See the
[OutOfProcToInProcCommand](./OutOfProcComponent/OutOfProcToInProcCommand.cs) for an example.
