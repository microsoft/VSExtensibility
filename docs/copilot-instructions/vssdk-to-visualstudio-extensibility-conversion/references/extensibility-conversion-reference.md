# VSSDK → VisualStudio.Extensibility Conversion Reference

Concrete templates and mappings for converting a classic VSSDK extension to a VisualStudio.Extensibility extension. All examples are drawn from the **CommentRemover** and **AsyncPackageAndMEF** samples and the official VisualStudio.Extensibility docs.

## Contents

- [Project File (in-process)](#project-file-in-process)
- [Extension Entry Point](#extension-entry-point)
- [Command](#command)
- [Shared Base Command (service injection)](#shared-base-command-service-injection)
- [Menu / Toolbar Configuration](#menu--toolbar-configuration)
- [Dependency Injection of VS SDK Services](#dependency-injection-of-vs-sdk-services)
- [Localizable Strings](#localizable-strings)
- [VSIX Manifest (in-process)](#vsix-manifest-in-process)
- [Keeping an AsyncPackage / MEF Component](#keeping-an-asyncpackage--mef-component)
- [API Mapping: VSSDK → VisualStudio.Extensibility](#api-mapping-vssdk--visualstudioextensibility)
- [Compile-Time Constant Rules](#compile-time-constant-rules)

## Project File (in-process)

In-process (VSSDK-compatible) extensions target `net472`, set `VssdkCompatibleExtension`, and reference the Extensibility SDK/Build packages plus the VS SDK (with `ExcludeAssets="runtime"`). Pin package versions to match the consuming VS build.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net472</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <LangVersion>12</LangVersion>

    <!-- Marks the extension as in-process / VSSDK-compatible -->
    <VssdkCompatibleExtension>true</VssdkCompatibleExtension>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.VisualStudio.Extensibility.Sdk" Version="17.14.40608" PrivateAssets="all" />
    <PackageReference Include="Microsoft.VisualStudio.Extensibility.Build" Version="17.14.40608" PrivateAssets="all" />
    <!-- Keep the VS SDK so in-proc VS services can be injected -->
    <PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.6.36389" ExcludeAssets="runtime" />
  </ItemGroup>

  <ItemGroup>
    <Content Include="Resources\LICENSE" />
    <Content Include="Resources\Icon.png" />
    <Content Include="Resources\Preview.png" />
  </ItemGroup>
</Project>
```

If you keep an `AsyncPackage` (see below), also add:

```xml
<PropertyGroup>
  <GeneratePkgDefFile>true</GeneratePkgDefFile>
  <UseCodebase>true</UseCodebase>
</PropertyGroup>
```

## Extension Entry Point

Replaces the `AsyncPackage`. For in-process, set `RequiresInProcessHosting = true`. The `Metadata` in `ExtensionConfiguration` generates the manifest for out-of-process extensions (for in-process, the kept `source.extension.vsixmanifest` is used instead).

```csharp
namespace CommentRemover;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

[VisualStudioContribution]
public class CommentRemoverExtension : Extension
{
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        RequiresInProcessHosting = true,

        // For out-of-process extensions, Metadata generates the .vsixmanifest:
        // Metadata = new(
        //     id: "MyExtension.<guid>",
        //     version: this.ExtensionAssemblyVersion,
        //     publisherName: "Contoso",
        //     displayName: "My Extension",
        //     description: "What it does"),
    };

    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        // Register shared local services / proffer brokered services here.
        base.InitializeServices(serviceCollection);
    }
}
```

## Command

Each VSSDK command (`OleMenuCommand` + `.vsct` button) becomes a `Command` subclass. Configuration is declarative and compile-time-constant; the handler body is async.

```csharp
[VisualStudioContribution]
internal class RemoveAllComments : CommentRemoverCommand
{
    private const string CommandDescription = "%CommentRemover.RemoveAllComments.DisplayName%";

    public RemoveAllComments(
        TraceSource traceSource,
        AsyncServiceProviderInjection<DTE, DTE2> dte,
        MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
        MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
        AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
        : base(traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager)
    {
    }

    public override CommandConfiguration CommandConfiguration => new(CommandDescription)
    {
        Icon = new(ImageMoniker.KnownValues.Uncomment, IconSettings.IconAndText),
        EnabledWhen = CommandEnabledWhen,
        Shortcuts = [new CommandShortcutConfiguration(ModifierKey.Control, Key.K, ModifierKey.Control, Key.Q)],
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        // Confirmation prompt (replaces VS SDK message box).
        if (!await this.Extensibility.Shell().ShowPromptAsync(
                "All comments will be removed from the current document. Are you sure?",
                PromptOptions.OKCancel,
                cancellationToken))
        {
            return;
        }

        // Progress reporting (auto-removed when disposed).
        using var reporter = await this.Extensibility.Shell().StartProgressReportingAsync(
            "Removing comments", options: new(isWorkCancellable: false), cancellationToken);

        // VS SDK calls require the UI thread.
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

        // ... original command logic, using injected services ...
    }
}
```

## Shared Base Command (service injection)

A base class centralizes the VS SDK service injection shared by all commands.

```csharp
internal abstract class CommentRemoverCommand : Microsoft.VisualStudio.Extensibility.Commands.Command
{
    // Activation constraint replaces BeforeQueryStatus: enable only for C#/VB/F# files.
    protected static readonly ActivationConstraint CommandEnabledWhen =
        ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(cs|vb|fs)$");

    public CommentRemoverCommand(
        TraceSource traceSource,
        AsyncServiceProviderInjection<DTE, DTE2> dte,
        MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
        MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
        AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
    {
        this.TraceSource = traceSource;
        this.Dte = dte;
        this.BufferTagAggregatorFactoryService = bufferTagAggregatorFactoryService;
        this.EditorAdaptersFactoryService = editorAdaptersFactoryService;
        this.TextManager = textManager;
    }

    protected AsyncServiceProviderInjection<DTE, DTE2> Dte { get; }
    protected MefInjection<IBufferTagAggregatorFactoryService> BufferTagAggregatorFactoryService { get; }
    protected MefInjection<IVsEditorAdaptersFactoryService> EditorAdaptersFactoryService { get; }
    protected AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> TextManager { get; }
    protected TraceSource TraceSource { get; }
}
```

## Menu / Toolbar Configuration

Re-express `.vsct` `<Menus>`/`<Groups>`/`<CommandPlacements>` as standalone `[VisualStudioContribution]` static properties. Group all of them in one `ExtensionCommandConfiguration` class. **Delete the `.vsct` once ported.**

```csharp
internal static class ExtensionCommandConfiguration
{
    [VisualStudioContribution]
    public static MenuConfiguration CommentRemoverMenu => new("%CommentRemover.CommentRemoverMenu.DisplayName%")
    {
        Placements =
        [
            CommandPlacement.KnownPlacements.ExtensionsMenu.WithPriority(0x01),
        ],
        Children =
        [
            MenuChild.Command<RemoveAllComments>(),
            MenuChild.Command<RemoveXmlDocComments>(),
            MenuChild.Command<RemoveAllExceptXmlDocComments>(),
            MenuChild.Separator,
            MenuChild.Command<RemoveTasks>(),
            MenuChild.Command<RemoveAllExceptTaskComments>(),
            MenuChild.Separator,
            MenuChild.Command<RemoveRegions>(),
        ],
    };
}
```

**Toolbar** (from CommandParentingSample):

```csharp
[VisualStudioContribution]
public static ToolbarConfiguration ToolBar => new("%MyExtension.ToolBar.DisplayName%")
{
    Children = [ ToolbarChild.Command<SampleCommand>() ],
};
```

**Preserving an original VSCT placement** — parent a command into an existing built-in menu using the same GUID/ID the old `.vsct` used:

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyExtension.SampleCommand.DisplayName%")
{
    Placements =
    [
        // Solution Explorer "Project" context menu (guidSHLMainMenu).
        CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 1026, priority: 0),
    ],
};
```

## Dependency Injection of VS SDK Services

VS SDK services are consumed via constructor injection using bridge types in `Microsoft.VisualStudio.Extensibility.VSSdkCompatibility`. Resolve them lazily, and switch to the UI thread before use.

| Service obtained today via | Inject as |
|----------------------------|-----------|
| `AsyncServiceProvider` (`GetServiceAsync<SFoo, IFoo>()`) | `AsyncServiceProviderInjection<SFoo, IFoo>` |
| MEF (`[Import] IFoo`) | `MefInjection<IFoo>` |

```csharp
// In a command/part constructor:
public MyCommand(
    AsyncServiceProviderInjection<DTE, DTE2> dte,
    MefInjection<IBufferTagAggregatorFactoryService> tagAggregatorFactory)
{
    this.dte = dte;
    this.tagAggregatorFactory = tagAggregatorFactory;
}

// At use site:
await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(); // VS SDK calls need the UI thread
DTE2 dte = await this.dte.GetServiceAsync();
IBufferTagAggregatorFactoryService factory = await this.tagAggregatorFactory.GetServiceAsync();
```

## Localizable Strings

Localizable config values use `%Key%` tokens resolved from `string-resources.json` under `.vsextension`. The root file is the default; locale subfolders (`de`, `it`, ...) provide translations. Keys must be globally unique across Visual Studio.

```
.vsextension/
  string-resources.json        (default / fallback)
  de/string-resources.json     (German)
  it/string-resources.json     (Italian)
```

```json
{
  "CommentRemover.CommentRemoverMenu.DisplayName": "Comments",
  "CommentRemover.RemoveAllComments.DisplayName": "Remove All",
  "CommentRemover.RemoveXmlDocComments.DisplayName": "Remove Xml Docs"
}
```

Both `DisplayName` and `ToolTipText` are localizable:

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyExtension.SampleCommand.DisplayName%")
{
    ToolTipText = "%MyExtension.SampleCommand.ToolTipText%",
};
```

## VSIX Manifest (in-process)

In-process extensions keep `source.extension.vsixmanifest` with `ExtensionType="VSSDK+VisualStudio.Extensibility"`.

```xml
<?xml version="1.0" encoding="utf-8"?>
<PackageManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011"
                 xmlns:d="http://schemas.microsoft.com/developer/vsx-schema-design/2011">
  <Metadata>
    <Identity Id="<guid>" Version="1.3" Language="en-US" Publisher="Contoso" />
    <DisplayName>My Extension</DisplayName>
    <Description xml:space="preserve">What it does.</Description>
    <License>Resources\LICENSE</License>
    <Icon>Resources\Icon.png</Icon>
    <PreviewImage>Resources\Preview.png</PreviewImage>
  </Metadata>
  <Installation ExtensionType="VSSDK+VisualStudio.Extensibility">
    <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.14,)">
      <ProductArchitecture>amd64</ProductArchitecture>
    </InstallationTarget>
  </Installation>
  <Prerequisites>
    <Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[17.14,)"
                  DisplayName="Visual Studio core editor" />
  </Prerequisites>
</PackageManifest>
```

If you keep an `AsyncPackage` or MEF component, add the matching assets:

```xml
<Assets>
  <Asset Type="Microsoft.VisualStudio.VsPackage" Path="MyExtension.pkgdef" />
  <Asset Type="Microsoft.VisualStudio.MefComponent" Path="MyExtension.dll" />
</Assets>
```

## Keeping an AsyncPackage / MEF Component

Use only when functionality has no VisualStudio.Extensibility equivalent. The `Extension`, MEF components, and `AsyncPackage` initialize **independently** — trigger the other's initialization (via `GetServiceAsync`) before interacting.

**AsyncPackage exposing a service:**

```csharp
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
            (container, ct, serviceType) => Task.FromResult<object>(new MyService()),
            promote: true);
        return Task.CompletedTask;
    }
}
```

Inject it where needed; the package initializes lazily on first `GetServiceAsync`:

```csharp
[VisualStudioContribution]
internal class InteractWithAsyncPackageCommand : Command
{
    private readonly AsyncServiceProviderInjection<MyService, MyService> myService;

    public InteractWithAsyncPackageCommand(AsyncServiceProviderInjection<MyService, MyService> myService)
        => this.myService = myService;

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        var svc = await this.myService.GetServiceAsync();
        // use svc
    }
}
```

**MEF component:** mark with `[Export(typeof(MyMEFComponent))]`, add the `Microsoft.VisualStudio.MefComponent` asset, and inject with `MefInjection<MyMEFComponent>`.

**Package → VisualStudio.Extensibility callback:** proffer a brokered service from the `Extension` and retrieve a proxy in the package:

```csharp
// In Extension.InitializeServices:
serviceCollection.ProfferBrokeredService(
    MyBrokeredService.BrokeredServiceConfiguration,
    IMyBrokeredService.Configuration.ServiceDescriptor);

// In the AsyncPackage:
var container = await this.GetServiceAsync<SVsBrokeredServiceContainer, IBrokeredServiceContainer>();
var broker = container.GetFullAccessServiceBroker();
var proxy = await broker.GetProxyAsync<IMyBrokeredService>(
    IMyBrokeredService.Configuration.ServiceDescriptor, this.DisposalToken);
```

## API Mapping: VSSDK → VisualStudio.Extensibility

| VSSDK / Community Toolkit | VisualStudio.Extensibility |
|---------------------------|----------------------------|
| `AsyncPackage` subclass, `InitializeAsync` | `Extension` subclass with `[VisualStudioContribution]`, `InitializeServices` |
| `[ProvideAutoLoad]`, command registration in `InitializeAsync` | Declarative discovery via `[VisualStudioContribution]` (deleted) |
| `.vsct` `<Button>` + `OleMenuCommand` | `Command` subclass + `CommandConfiguration` |
| `Execute(object, EventArgs)` handler | `async Task ExecuteCommandAsync(IClientContext, CancellationToken)` |
| `.vsct` `<Menus>` / `<Groups>` / `<CommandPlacements>` | `MenuConfiguration` / `CommandGroupConfiguration` / `ToolbarConfiguration` |
| `.vsct` `<Parent>` GUID/ID | `CommandPlacement.KnownPlacements.*` or `CommandPlacement.VsctParent(guid, id, priority)` |
| `.vsct` `<KeyBindings>` | `CommandConfiguration.Shortcuts` (`CommandShortcutConfiguration`) |
| `BeforeQueryStatus` / `OLECMDF` / UI context GUIDs | `EnabledWhen` / `VisibleWhen` via `ActivationConstraint` |
| `.vsct` `ButtonText` / `.resx` strings | `%Key%` in `.vsextension/string-resources.json` |
| `.vsct` `<Bitmap>` / `ImageMoniker` | `ImageMoniker.KnownValues.*` / `ImageMoniker.Custom("Name")` (+ `Images` folder) |
| `GetServiceAsync<SFoo, IFoo>()` (AsyncServiceProvider) | constructor `AsyncServiceProviderInjection<SFoo, IFoo>` |
| `[Import] IFoo` (MEF) | constructor `MefInjection<IFoo>` |
| `ToolWindowPane` + `[ProvideToolWindow]` | `ToolWindow` contribution (or keep via in-proc host) |
| VS SDK message box / progress | `Extensibility.Shell().ShowPromptAsync(...)` / `StartProgressReportingAsync(...)` |
| `ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync()` | unchanged — still required before VS SDK calls |

## Compile-Time Constant Rules

`CommandConfiguration`, `MenuConfiguration`, `ToolbarConfiguration`, `CommandGroupConfiguration`, and similar configuration properties are marked `[CompileTimeEvaluation]`. Their values are evaluated when the extension is **built** and written into the extension manifest so Visual Studio can read them without loading the extension.

Consequences:
- Configuration properties must be effectively read-only.
- Their initializers **cannot** reference user-defined non-static members.
- Their initializers **cannot** contain multi-statement imperative code.
- Do not read configuration properties at run time.

Put all runtime logic in `ExecuteCommandAsync` (or the relevant handler), never in the configuration property. Violations fail the build with messages like:

> An issue was encountered when evaluating the compile-time constant `SampleCommand.CommandConfiguration`. References to user-defined non-static members are not supported when evaluating compile-time constant values.
