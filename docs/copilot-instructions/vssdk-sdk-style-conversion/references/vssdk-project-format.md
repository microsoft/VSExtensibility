# VSSDK Project Format Reference

## Contents

- [Core Properties](#core-properties)
- [Project Capabilities](#project-capabilities)
- [Auto-Generated Files](#auto-generated-files)
- [VSCT Command Table](#vsct-command-table)
- [VSIX Manifest](#vsix-manifest)
- [Content Items](#content-items)
- [Framework References](#framework-references)
- [Package References](#package-references)
- [Properties to Remove](#properties-to-remove)
- [Complete Template](#complete-template)

## Core Properties

Add these to the main `<PropertyGroup>`:

```xml
<PropertyGroup>
    <TargetFramework>net48</TargetFramework>
    <Nullable>enable</Nullable>
    <LangVersion>latest</LangVersion>

    <!-- VSIX settings -->
    <VSSDKBuildToolsAutoSetup>true</VSSDKBuildToolsAutoSetup>
    <VsixDeployOnDebug>true</VsixDeployOnDebug>
    <GeneratePkgDefFile>true</GeneratePkgDefFile>
    <UseCodebase>true</UseCodebase>
</PropertyGroup>
```

| Property | Purpose |
|----------|---------|
| `VSSDKBuildToolsAutoSetup` | Auto-configures VSSDK build pipeline |
| `VsixDeployOnDebug` | Deploys VSIX to experimental instance on F5 |
| `GeneratePkgDefFile` | Generates .pkgdef for VS Package registration. Only add if not already set — preserve existing value. |
| `UseCodebase` | Uses codebase probing for MEF component registration |

## Project Capabilities

```xml
<ItemGroup>
    <ProjectCapability Include="CreateVsixContainer" />
</ItemGroup>
```

Tells the build system to produce a `.vsix` package.

## Auto-Generated Files

SDK-style projects auto-include all `*.cs` files via globbing. Files with generator metadata must use `<Compile Update>` (not `Include`) to avoid duplicate errors:

```xml
<ItemGroup>
    <Compile Update="source.extension.cs">
        <AutoGen>True</AutoGen>
        <DesignTime>True</DesignTime>
        <DependentUpon>source.extension.vsixmanifest</DependentUpon>
    </Compile>
    <Compile Update="VSCommandTable.cs">
        <AutoGen>True</AutoGen>
        <DesignTime>True</DesignTime>
        <DependentUpon>VSCommandTable.vsct</DependentUpon>
    </Compile>
</ItemGroup>
```

## VSCT Command Tables

Preserve all `VSCTCompile` items unchanged — there may be more than one, and they work identically in SDK-style:

```xml
<ItemGroup>
    <VSCTCompile Include="VSCommandTable.vsct">
        <ResourceName>Menus.ctmenu</ResourceName>
        <Generator>VsctGenerator</Generator>
        <LastGenOutput>VSCommandTable.cs</LastGenOutput>
    </VSCTCompile>
    <!-- Additional .vsct files if present -->
    <VSCTCompile Include="AnotherCommandTable.vsct">
        <ResourceName>Menus.ctmenu</ResourceName>
    </VSCTCompile>
</ItemGroup>
```

## VSIX Manifest

Keep the manifest as a `None` item with generator metadata:

```xml
<ItemGroup>
    <None Include="source.extension.vsixmanifest">
        <SubType>Designer</SubType>
        <Generator>VsixManifestGenerator</Generator>
        <LastGenOutput>source.extension.cs</LastGenOutput>
    </None>
</ItemGroup>
```

## Content Items

Files included in the VSIX package use `<Content>` with `<IncludeInVSIX>`:

```xml
<ItemGroup>
    <Content Include="Resources/LICENSE.txt">
        <CopyToOutputDirectory>Always</CopyToOutputDirectory>
        <IncludeInVSIX>true</IncludeInVSIX>
    </Content>
    <Content Include="Resources/Icon.png">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        <IncludeInVSIX>true</IncludeInVSIX>
    </Content>
</ItemGroup>
```

## Framework References

Add based on what the extension actually uses — not all extensions need all of these:

```xml
<ItemGroup>
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="System.ComponentModel.Composition" />
    <Reference Include="System.Design" />
</ItemGroup>
```

| Assembly | When Needed |
|----------|-------------|
| `PresentationCore` | WPF types (`Brush`, `Typeface`, `Visual`) — editor adornments |
| `PresentationFramework` | WPF controls (`TextBlock`, `Border`, `UserControl`) — tool windows, adornments |
| `System.ComponentModel.Composition` | MEF1 attributes (`[Export]`, `[Import]`) — taggers, adornment providers, QuickInfo |
| `System.Design` | `System.Drawing.Design` types — rare, only if options pages use UITypeEditor |

Simple command/package extensions with no editor adornments or MEF exports typically need none of these.

## Package References

```xml
<ItemGroup>
    <!-- VSCT compilation (if extension has commands) -->
    <PackageReference Include="Community.VisualStudio.VSCT" Version="16.0.29.6" PrivateAssets="all" />

    <!-- Community Toolkit (if used) -->
    <PackageReference Include="Community.VisualStudio.Toolkit.17" Version="17.0.549" ExcludeAssets="Runtime">
        <IncludeAssets>compile; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>

    <!-- VS SDK metapackage (replaces individual VS interop packages) -->
    <PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.14.40265" ExcludeAssets="runtime" />

    <!-- VSSDK Build Tools (produces .vsix, generates pkgdef) -->
    <PackageReference Include="Microsoft.VSSDK.BuildTools" Version="18.5.38461">
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
        <PrivateAssets>all</PrivateAssets>
    </PackageReference>
</ItemGroup>
```

### Version Policy

`Microsoft.VSSDK.BuildTools` **must be at least version 18.5.38461 — but NEVER downgrade an existing higher version**. The minimum is a hard floor for SDK-style VSIX projects; older versions do not support this format. However, if the project or central package management already specifies a version *above* 18.5.38461, **keep the existing version as-is**. Downgrading the build tools causes obscure build failures, stale target imports, and missing task assemblies — it is never the correct action. Only raise the version when the current version is below the minimum.

If the project or solution uses central package management (Directory.Packages.props) or version constraints that prevent the minimum, resolve the conflict before proceeding. If the minimum cannot be met, the conversion is blocked.

After updating the build tools version, perform a **full clean** before building. Stale artifacts from older build tools versions persist in `bin`/`obj` folders and cause misleading build errors. Use `msbuild /t:Clean` or delete the `bin` and `obj` directories manually. Never delete or clear NuGet caches — this causes broader restoration issues across the machine and is never the correct fix for build tool version problems.

If the build or restore fails with file-lock errors after cleaning, or if the `CreatePkgDef` task fails or hangs (typically caused by stale processes caching old build tool assemblies), kill all `dotnet` and `msbuild` processes (`Stop-Process -Name dotnet -Force; Stop-Process -Name msbuild -Force`) and retry. If insufficient permissions prevent killing the processes, ask the user to close Visual Studio and terminate the processes from an elevated prompt.

Keep existing versions for `Microsoft.VisualStudio.SDK`, `Community.VisualStudio.Toolkit.17`, and `Community.VisualStudio.VSCT` — version bumps beyond the build tools are out of scope for format conversion. Only include the Community packages if the extension already uses them.

## Properties to Remove

These legacy properties are no longer needed in SDK-style:

| Property/Element | Why Removed |
|-----------------|-------------|
| `VSToolsPath` | SDK handles VS tools path resolution |
| `Configuration`/`Platform` defaults | SDK provides these |
| `SchemaVersion` | Not used in SDK-style |
| `ProjectTypeGuids` | SDK-style uses project capabilities instead |
| `ProjectGuid` | Only needed in `.sln` files, not project files |
| `OutputType` | Defaults to `Library` |
| `AppDesignerFolder` | SDK convention replaces this |
| `RootNamespace`/`AssemblyName` | Only needed if they differ from the project file name |
| Per-config blocks (Debug/Release AnyCPU) | SDK defaults handle `DebugSymbols`, `Optimize`, `OutputPath`, `DefineConstants` |
| `IncludeAssemblyInVSIXContainer` | VSSDK build tools defaults handle this |
| `IncludeDebugSymbolsInVSIXContainer` | VSSDK build tools defaults handle this |
| `CopyBuildOutputToOutputDirectory` | VSSDK build tools defaults handle this |
| `CopyOutputSymbolsToOutputDirectory` | VSSDK build tools defaults handle this |
| `StartAction`/`StartProgram`/`StartArguments` | Replaced by `VsixDeployOnDebug` + solution deploy markers |
| `<Import>` for `Microsoft.Common.props` | SDK includes this automatically |
| `<Import>` for `Microsoft.CSharp.targets` | SDK includes this automatically |
| `<Import>` for `Microsoft.VsSDK.targets` | VSSDK.BuildTools package handles this |

## Complete Template

A fully converted SDK-style VSIX project file. Include only the sections relevant to your extension:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net48</TargetFramework>
    <Nullable>enable</Nullable>
    <LangVersion>latest</LangVersion>
    <VSSDKBuildToolsAutoSetup>true</VSSDKBuildToolsAutoSetup>
    <VsixDeployOnDebug>true</VsixDeployOnDebug>
    <GeneratePkgDefFile>true</GeneratePkgDefFile>
    <UseCodebase>true</UseCodebase>
  </PropertyGroup>

  <ItemGroup>
    <ProjectCapability Include="CreateVsixContainer" />
  </ItemGroup>

  <!-- Auto-generated files (use Update — SDK already includes *.cs) -->
  <ItemGroup>
    <Compile Update="source.extension.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>source.extension.vsixmanifest</DependentUpon>
    </Compile>
    <Compile Update="VSCommandTable.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>VSCommandTable.vsct</DependentUpon>
    </Compile>
  </ItemGroup>

  <!-- VSCT command table (if extension has commands) -->
  <ItemGroup>
    <VSCTCompile Include="VSCommandTable.vsct">
      <ResourceName>Menus.ctmenu</ResourceName>
      <Generator>VsctGenerator</Generator>
      <LastGenOutput>VSCommandTable.cs</LastGenOutput>
    </VSCTCompile>
  </ItemGroup>

  <!-- VSIX manifest -->
  <ItemGroup>
    <None Include="source.extension.vsixmanifest">
      <SubType>Designer</SubType>
      <Generator>VsixManifestGenerator</Generator>
      <LastGenOutput>source.extension.cs</LastGenOutput>
    </None>
  </ItemGroup>

  <!-- Resources included in VSIX -->
  <ItemGroup>
    <Content Include="Resources/LICENSE.txt">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
      <IncludeInVSIX>true</IncludeInVSIX>
    </Content>
    <Content Include="Resources/Icon.png">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      <IncludeInVSIX>true</IncludeInVSIX>
    </Content>
  </ItemGroup>

  <!-- Framework refs — add only what your extension uses:
       PresentationCore/PresentationFramework: WPF (adornments, tool windows)
       System.ComponentModel.Composition: MEF1 ([Export], [Import])
       System.Design: UITypeEditor (rare) -->
  <ItemGroup>
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="System.ComponentModel.Composition" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Community.VisualStudio.VSCT" Version="16.0.29.6" PrivateAssets="all" />
    <PackageReference Include="Community.VisualStudio.Toolkit.17" Version="17.0.549" ExcludeAssets="Runtime">
      <IncludeAssets>compile; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.14.40265" ExcludeAssets="runtime" />
    <PackageReference Include="Microsoft.VSSDK.BuildTools" Version="18.5.38461">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
  </ItemGroup>

</Project>
```
