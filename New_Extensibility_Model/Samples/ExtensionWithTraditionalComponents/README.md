---
title: out-of-proc Extension with VSSDK components
description: A reference sample for out-of-proc extensions that package traditional VSSDK components
date: 2025-01-15
---

# Walkthrough: In-proc/out-of-proc Composite Extension Sample

This is sample of how to write an out-of-proc VisualStudio.Extensibility extensions that
packages some traditional VSSDK components. This sample implements a Remote UI-based tool window
and packages a WPF user control to be loaded in-proc in VS.

This sample is similar to [CompositeExtension](../CompositeExtension) but it doesn't contribute any
in-proc VisualStudio.Extensibility components.

`Extension.csproj` targets .NET 8.0 and uses the VisualStudio.Extensibility packages.

`Container.csproj` targets .NET Framework and packages the output of `Extension.csproj` into a VSIX
while also packaging its own assembly containing the WPF user control.

The same structure can be applied to package any traditional VSSDK content (like classification type
definitions, editor format definitions, project templates, TextMate files, ect.)

Because the out-of-proc extension is packaged together with VSSDK components, hot-load is not available
and the extension's installatio will require VS to restart.

## Implementing the extension component

The extension starts as a [standard VisualStudio.Extensibility project](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension).

### Updating the out-of-proc component's csproj file

Since the out-of-proc component will be packaged into the `CompositeExtension` VSIX, we don't need to
create a VSIX package. Let's add the following to the csproj:

```xml
<CreateVsixContainer>false</CreateVsixContainer>
```

As mentioned above, `Extension.csproj` and `Container.csproj` have different target frameworks.
This results in them potentially having incompatible versions of the same dependencies. To avoid issues, we
will package the `Extension` assembly and it's dependencies in a subfolder of the VSIX. Let's add
the following to the csproj:

```xml
<AssemblyVSIXSubPath>OutOfProc</AssemblyVSIXSubPath>
```

This is not as important as for [CompositeExtension](../CompositeExtension), since `Container.csproj`
doesn't share dependencies with `Container.csproj`, but it's still better to keep them separate.

### Other changes

One of the steps in creating an out-of-proc VisualStudio.Extensibility extension is to fill in the 
`ExtensionConfiguration`'s `Metadata` in the `Extension` class. While it's a good practice to do this, it's
worth noting that most of this information will be ignored since the `Container` will provide this
information for the entire VSIX using a `vsixmanifest` file.

## Implementing the in-proc component (`CompositeExtension`)

The `Container` project starts as a [standard VSSDK-compatible VisualStudio.Extensibility extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions)
but it is stripped of most of its content. The `Extension` class and the project reference to
`Microsoft.VisualStudio.Extensibility.Sdk` are removed.

### Updating the `Container`'s csproj file

#### Packaging the `Extension` in the `Container`'s VSIX

The first step after creating the `Container` and filling in the information in the `source.extension.vsixmanifest`
file is to add a reference to `Extension.csproj` so that it's output is packaged into the `Container`'s VSIX:

```xml
<ProjectReference Include="..\Extension\Extension.csproj">
  <ReferenceOutputAssembly>false</ReferenceOutputAssembly>
  <SkipGetTargetFrameworkProperties>true</SkipGetTargetFrameworkProperties>
  <IncludeInVSIX>true</IncludeInVSIX>
  <IncludeOutputGroupsInVSIX>ExtensionFilesOutputGroup</IncludeOutputGroupsInVSIX>
</ProjectReference>
```

You can see that `Container` doesn't reference the out-of-proc component's assembly directly, since they
have different target frameworks.

Including the `ExtensionFilesOutputGroup` output in the VSIX ensures that all the `Extension`'s
dependencies are correctly packaged (in a separate subfolder, since `Extension` specifies an
`AssemblyVSIXSubPath`).

`SetTargetFramework` allows the out-of-proc component to correctly build as a dependency of `CompositeExtension`
even if the two project have different target frameworks.

#### Including the `Extension`'s `extension.json`

VisualStudio.Extensibility extension projects generate a file named `extension.json` which is packaged in the
VSIX and contains information about what features the extension contributes to VS.

Since the `Extension` is a separate project, the `Container`'s csproj needs to package it into its own
vsix:

```xml
<ItemGroup>
  <VSIXSourceItem Include="$(BaseOutputPath)..\Extension\$(Configuration)\net8.0-windows8.0\.vsextension\extension.json" VsixSubPath=".vsextension" />
</ItemGroup>
```

You may need to adjust the path to match your project structure. The `ProjectReference`
added [before](#packaging-the-extension-in-the-containers-vsix) guarantees that the
out-of-proc component's `extension.json` is generated before the `Container`'s compilation starts.

Note that this is different than what we did in the [CompositeExtension sample](../CompositeExtension/README.md#merging-the-out-of-proc-components-extensionjson)
since `Container` doesn't generate its own `extension.json` file. So we need to include `Extension`'s one
instead of merging the two `extension.json` files together.

## Exposing the WPF user control

After adding `<UseWPF>true</UseWPF>` to `Container.csproj`, we add the [MyUserControl.xaml](./Container/MyUserControl.xaml)
WPF user control as we would to to any class library.

Since `Container.csproj` has a package reference to `Microsoft.VisualStudio.SDK` and this assembly is meant
to be loaded inside the Visual Studio process, the xaml file can reference Visual Studio types:

```xml
xmlns:styles="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
xmlns:colors="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0"
```

We also need to add a `ProvideCodeBase` attribute to the project:

```cs
[assembly: ProvideCodeBase]
```
As well as configuring `Container.csproj` to generate a `.pkgdef` file, use codebases for the pkgdef generation,
and sign the assembly with a strong name.

```xml
<GeneratePkgDefFile>true</GeneratePkgDefFile>
<UseCodebase>true</UseCodebase>
<SignAssembly>True</SignAssembly>
<AssemblyOriginatorKeyFile>sgKey.snk</AssemblyOriginatorKeyFile>
```

These steps allow the `Container.dll` to be available to Visual Studio to load, which will allow us to reference
the WPF user control from the extension. Only strong-named assemblies can be loaded by Visual Studio in this
manner.

## Referencing the WPF user control

The extension can now reference the WPF control from Remote UI XAML:

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:container="clr-namespace:Container;assembly=Container, Version=1.0.0.0, Culture=neutral, PublicKeyToken=ebbd189e9e224069">
    <!-- The xmlns:container above must use the fully qualified name of the assembly and the assembly must be strong named!  -->
    <container:MyUserControl />
</DataTemplate>
```
