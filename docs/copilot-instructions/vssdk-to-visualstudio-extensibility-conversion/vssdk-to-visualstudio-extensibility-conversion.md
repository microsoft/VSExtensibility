# Converting a VSSDK Extension to a VisualStudio.Extensibility Extension

These instructions guide Copilot through converting an existing Visual Studio extension built on the classic **VSSDK** (Managed Package Framework — `AsyncPackage`, `.vsct` command tables, MEF, `Microsoft.VisualStudio.SDK`) into a **VisualStudio.Extensibility** extension.

Refer Copilot to this document when asked to "convert a VSSDK extension to VisualStudio.Extensibility", "migrate an extension to the new extensibility model", "modernize a VS extension to VisualStudio.Extensibility", or "make my extension use the new extensibility SDK".

> **Terminology:** Always write "VisualStudio.Extensibility extension" — never "Extensibility extension" or "Visual Studio Extensibility extension".

This conversion changes the **programming model** (commands, menus, tool windows, configuration), unlike the format-only SDK-style csproj conversion. It is a behavior-preserving rewrite of the extension's contribution surface.

## Reference material

The canonical end-to-end example is the **CommentRemover** sample — a real VSSDK extension converted to an in-process VisualStudio.Extensibility extension:
<https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommentRemover>

Load [references/extensibility-conversion-reference.md](references/extensibility-conversion-reference.md) for concrete templates (project file, extension entry point, command, menu configuration, DI bridges, manifest) and the VSSDK→VisualStudio.Extensibility API mapping table.

A second sample, **AsyncPackageAndMEF**, shows how an in-process extension can keep an `AsyncPackage` and/or MEF components when it depends on APIs that have no VisualStudio.Extensibility equivalent:
<https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/AsyncPackageAndMEF/README.md>

Official docs:
- Choose the right extensibility model (VSSDK vs Community Toolkit vs VisualStudio.Extensibility): <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/extensibility-models>
- VSSDK-compatible (in-process) extensions: <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions>
- Components of an extension (anatomy): <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/extension-anatomy>
- Contributions and configurations: <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/inside-the-sdk/contributions-and-configurations>
- Metadata localization: <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/command/localize-metadata>
- Create your first extension: <https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/create-your-first-extension>

## The single most important decision: in-process vs out-of-process

VisualStudio.Extensibility supports two hosting models. **Choose this first — it drives the entire conversion.**

| Hosting model | When to use | Trade-offs |
|---------------|-------------|------------|
| **In-process (VSSDK-compatible)** | The extension uses Visual Studio SDK services that have **no** VisualStudio.Extensibility equivalent yet — `DTE`/`DTE2`, `IVsTextManager`, editor classification, MEF editor services, `IWpfTextView`, custom tool windows backed by VS SDK, etc. | Runs inside `devenv.exe` (.NET Framework). Can inject VS SDK + MEF services via DI. Set `RequiresInProcessHosting = true` and `VssdkCompatibleExtension = true`. This is the migration path for most existing extensions. |
| **Out-of-process** | The extension's functionality is fully covered by VisualStudio.Extensibility APIs (commands, editor text edits, prompts, settings, document events, etc.) and needs no VS SDK service. | Runs in a separate process; more resilient, no UI-thread constraints by default, can target modern .NET. Cannot consume in-proc-only VS SDK services. |

**Default recommendation for converting an _existing_ VSSDK extension: in-process (VSSDK-compatible).** Existing extensions almost always depend on VS SDK services that are not yet available out-of-process. The in-process model lets you adopt the new command/menu/tool-window programming model while keeping access to those services through dependency injection. The CommentRemover sample takes exactly this path.

Only choose out-of-process if assessment proves the extension uses **no** VS-SDK-only services. If in doubt, start in-process.

## Workflow Stages

```
┌──────────────────────────────────────────────────┐
│ 1. ASSESSMENT                                    │
│    Inventory contributions + VS SDK dependencies │
│    → Creates: assessment.md                      │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 2. PLANNING                                      │
│    Pick hosting model + map each contribution    │
│    → Creates: plan.md                            │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 3. EXECUTION                                     │
│    Project file → entry point → commands/menus   │
│    → tool windows → DI for VS SDK services       │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 4. VALIDATION                                    │
│    Build, F5 to experimental instance, verify    │
│    every contribution behaves as before          │
└──────────────────────────────────────────────────┘
```

## 1. Assessment

Inventory everything the VSSDK extension contributes and every Visual Studio service it consumes. The goal is to know exactly what must be re-expressed in the new model and which VS SDK services must be injected.

First, identify the **source model**. Extensions are built on one of three models (see the *extensibility-models* doc): raw **VSSDK**, the **Community Toolkit** (a thin wrapper over VSSDK — still uses `.vsct`, `AsyncPackage`, MEF), or already **VisualStudio.Extensibility**. VSSDK and Community Toolkit convert the same way; this guide covers both.

VisualStudio.Extensibility currently supports a **limited set** of contribution types: command handlers, tool windows, editor text-view listeners, text-view margin providers, and debugger visualizers. If the extension contributes something outside this set (e.g., MEF classifiers/taggers, language services, certain editor features), that piece has **no** new-model equivalent yet — keep it as a MEF component or `AsyncPackage` behind the in-process host (see Phase 7a and the AsyncPackageAndMEF sample). This is another strong reason to choose in-process hosting.

### What to Capture

| Aspect | Where to Look | Why It Matters |
|--------|--------------|----------------|
| Package class | `AsyncPackage`/`Package` subclass, `[ProvideAutoLoad]`, `InitializeAsync` | Replaced by an `Extension` subclass; auto-load/init logic mostly disappears |
| Commands | `.vsct` files, `OleMenuCommand`, `[ProvideMenuResource]`, command IDs | Each becomes a `Command` class with a `CommandConfiguration`; the `.vsct` is deleted |
| Menus / toolbars / groups | `.vsct` `<Menus>`, `<Groups>`, `<CommandPlacements>` | Re-expressed as `MenuConfiguration` / `ToolbarConfiguration` properties |
| Command enable/visibility rules | `BeforeQueryStatus`, `OLECMDF` flags, UI context GUIDs | Become `EnabledWhen`/`VisibleWhen` `ActivationConstraint`s |
| Keyboard shortcuts | `.vsct` `<KeyBindings>` | Become `Shortcuts` in `CommandConfiguration` |
| Tool windows | `[ProvideToolWindow]`, `ToolWindowPane` | Become `ToolWindow` + remote UI (or kept via in-proc hosting) |
| MEF exports | `[Export]`, `[Import]` (taggers, adornments, editor services) | Editor extensibility points may stay MEF; injected services use `MefInjection<T>` |
| VS SDK services consumed | `GetServiceAsync`, `DTE`/`DTE2`, `IVsTextManager`, `IVsEditorAdaptersFactoryService`, etc. | Each becomes a constructor-injected `AsyncServiceProviderInjection<,>` or `MefInjection<>` — **this is the strongest signal for in-process hosting** |
| Settings / options pages | `DialogPage`, `[ProvideOptionPage]` | Map to VisualStudio.Extensibility settings where available |
| Resources / icons | `.vsct` bitmaps, `ImageMoniker` usage | Become `ImageMoniker.KnownValues.*` or custom images in an `Images` folder |
| Localizable strings | `.vsct` `ButtonText`, `.resx`, VSCT string tables | Move to `.vsextension/string-resources.json` with `%Key%` references |
| Manifest | `source.extension.vsixmanifest` | Kept; `ExtensionType` becomes `VSSDK+VisualStudio.Extensibility` for in-proc |
| Target framework | `TargetFramework(s)` | In-process VS2022 extensions target `net472` |

### VS SDK Service Inventory (critical)

List every Visual Studio service the extension consumes and classify how it is obtained today:

- **AsyncServiceProvider services** (e.g., `DTE`/`DTE2`, `SVsTextManager`/`IVsTextManager`) → will be injected as `AsyncServiceProviderInjection<TService, TInterface>`
- **MEF services** (e.g., `IBufferTagAggregatorFactoryService`, `IVsEditorAdaptersFactoryService`) → will be injected as `MefInjection<TService>`

If this list is non-empty, the conversion **must** use the in-process (VSSDK-compatible) hosting model.

### Assessment Output

Create `assessment.md`:

```markdown
# Assessment: VSSDK → VisualStudio.Extensibility Conversion

## Target Extension
| Property | Value |
|----------|-------|
| Project | [name] |
| Path | [path] |
| Current TFM | [e.g., net472] |
| Package class | [name / file] |

## Contributions
- Commands: [count] — [list with current command IDs]
- Menus / toolbars / groups: [list]
- Tool windows: [list]
- MEF editor components (taggers, adornments): [list]
- Options pages: [list]

## VS SDK Services Consumed
| Service | Obtained via | New injection type |
|---------|-------------|--------------------|
| DTE2 | AsyncServiceProvider | AsyncServiceProviderInjection<DTE, DTE2> |
| ... | MEF | MefInjection<...> |

## Hosting Model Decision
- [ ] In-process (VSSDK-compatible)  ← default for existing extensions
- [ ] Out-of-process
Rationale: [why]

## Baseline
- Project builds: [Yes/No]
- Each command/feature works (manual check in experimental instance): [notes]
```

## 2. Planning

Create `plan.md` mapping every assessed contribution to its new-model equivalent, then order the work.

### Task Ordering

1. **Pre-conversion** — Unload the project if the IDE has it loaded (prevents file locks and stale caches). Capture a behavioral baseline of every command/feature.
2. **Project file** — Add VisualStudio.Extensibility SDK/Build packages, `VssdkCompatibleExtension`, target framework (see reference file).
3. **Entry point** — Add an `Extension` subclass with `[VisualStudioContribution]`; set `RequiresInProcessHosting = true` for in-process.
4. **Commands** — Convert each command to a `Command` subclass with a `CommandConfiguration`; port `Execute` bodies into `async ExecuteCommandAsync`.
5. **Menus / toolbars** — Re-express `.vsct` placements as `MenuConfiguration` / `ToolbarConfiguration` properties (recommended: a single `ExtensionCommandConfiguration` static class). Delete the `.vsct` file(s).
6. **Activation constraints** — Convert `BeforeQueryStatus`/UI-context logic to `EnabledWhen`/`VisibleWhen`.
7. **VS SDK services** — Replace `GetServiceAsync` calls with constructor-injected `AsyncServiceProviderInjection<,>` / `MefInjection<>`.
8. **Tool windows / options / other contributions** — Convert per the API mapping table.
9. **Strings & icons** — Move localizable text to `.vsextension/string-resources.json`; map icons to `ImageMoniker` or custom images.
10. **Remove dead VSSDK scaffolding** — Delete the `AsyncPackage` class, `.vsct`, command-ID constant files, and registration attributes that no longer apply.
11. **Reload & validate** — Reload, build, F5, and verify every contribution.

### Project Unloading

If the project is loaded in Visual Studio, unload it before editing the project file. The IDE locks project files and caches project state. Reload after conversion so VS evaluates the new model cleanly. If running outside VS (CLI / VS Code), skip this step.

## 3. Execution

### Tooling: File Modifications

All project file (`.csproj`) and source edits **must** use the edit/create file tools — never reconstruct files through PowerShell (`Set-Content`, redirection, `[xml]`, `Add-Content`). PowerShell is only for build commands (`msbuild`, `dotnet build`), NuGet restore, and process management. Surgical edits preserve formatting and minimize diff noise.

### Phase 1: Project File

Convert (or confirm) the project is SDK-style, then add the VisualStudio.Extensibility packages and properties. See the reference file for the complete project template.

Key points (in-process / VSSDK-compatible):
- Target framework `net472` (the .NET version VS 2022 runs on).
- Add `<VssdkCompatibleExtension>true</VssdkCompatibleExtension>`.
- Add `Microsoft.VisualStudio.Extensibility.Sdk` and `Microsoft.VisualStudio.Extensibility.Build` package references (`PrivateAssets="all"`).
- Keep `Microsoft.VisualStudio.SDK` with `ExcludeAssets="runtime"` so VS SDK services remain available for injection.
- Keep content/resources (`Icon.png`, `Preview.png`, `LICENSE`) referenced by the manifest.

### Phase 2: Extension Entry Point

Replace the `AsyncPackage` subclass with an `Extension` subclass marked `[VisualStudioContribution]`. For in-process, set `RequiresInProcessHosting = true`. Most `InitializeAsync` boilerplate (registering commands, proffering menus) is **deleted** — the new model discovers contributions declaratively. Genuine startup logic and shared local services move into the `InitializeServices(IServiceCollection)` override.

The `Extension` class is the analog of `AsyncPackage`. Its `ExtensionConfiguration.Metadata` (id, version, publisher, display name, description) **generates the `.vsixmanifest`** for out-of-process extensions. For in-process (VSSDK-compatible) extensions, the existing `source.extension.vsixmanifest` is kept instead (see Phase 8). Contribution classes are lazily-instantiated singletons — only created when Visual Studio first needs them (e.g., when a command is first invoked).

### Phase 3: Commands

For each VSSDK command:
- Create a `Command` subclass (`Microsoft.VisualStudio.Extensibility.Commands.Command`) marked `[VisualStudioContribution]`.
- Express its title, icon, shortcuts, and activation rules in `CommandConfiguration`.
- Move the old command handler body into `public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)`.
- Command execution is **async** in the new model. Any code that must run on the UI thread (most VS SDK calls) must explicitly switch: `await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();`.
- A shared base command class is a good place for common service injection (CommentRemover uses this pattern).
- Use `this.Extensibility.Shell().ShowPromptAsync(...)` for confirmations and `StartProgressReportingAsync(...)` for progress, replacing VS SDK dialog/progress code.
- Use the `IClientContext` parameter to read IDE state at invocation time (e.g., the active text view or the URI of selected items) instead of querying VS SDK globals.

> **Pitfall — `CommandConfiguration` is a compile-time constant.** Configuration properties (`CommandConfiguration`, `MenuConfiguration`, `ToolbarConfiguration`, etc.) are evaluated at **build** time and baked into the extension manifest (`[CompileTimeEvaluation]`). They must be effectively read-only and **cannot** reference non-static members or contain multi-statement imperative code. Put all runtime logic in `ExecuteCommandAsync`, not in the configuration property. Violations produce build errors like *"References to user-defined non-static members are not supported when evaluating compile-time constant values."*

### Phase 4: Menus, Toolbars, Placements

Re-express `.vsct` `<Menus>`/`<Groups>`/`<CommandPlacements>` as `MenuConfiguration`/`ToolbarConfiguration`/`CommandGroupConfiguration` static properties marked `[VisualStudioContribution]`. Use `CommandPlacement.KnownPlacements.*` (e.g., `ExtensionsMenu`) and `MenuChild.Command<TCommand>()` / `MenuChild.Separator` (and `ToolbarChild.*` / `GroupChild.*`). Recommended: collect all menus/toolbars in one `ExtensionCommandConfiguration` static class.

To preserve a command's **original** location in a built-in VS menu, use `CommandPlacement.VsctParent(parentGuid, id, priority)` with the same GUID/ID the old `.vsct` parented to. **Delete the `.vsct` file(s)** once placements are ported — commands are now defined in one place.

### Phase 5: Activation Constraints

Convert `BeforeQueryStatus` logic and UI-context checks to `ActivationConstraint`s on `EnabledWhen`/`VisibleWhen`. Example from CommentRemover (enable only for C#/VB/F# files):

```csharp
protected static readonly ActivationConstraint CommandEnabledWhen =
    ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(cs|vb|fs)$");
```

### Phase 6: Dependency Injection of VS SDK Services

Replace `GetServiceAsync<>`/MEF imports with constructor injection using the VSSdkCompatibility bridges (namespace `Microsoft.VisualStudio.Extensibility.VSSdkCompatibility`):

- `AsyncServiceProviderInjection<TService, TInterface>` for AsyncServiceProvider services (e.g., `<DTE, DTE2>`, `<SVsTextManager, IVsTextManager>`).
- `MefInjection<TService>` for MEF services (e.g., `IBufferTagAggregatorFactoryService`, `IVsEditorAdaptersFactoryService`).

Add these to the command (or part) constructor; resolve them lazily with `await injected.GetServiceAsync()`. Remember the UI-thread rule above for VS SDK calls.

### Phase 7: Strings, Icons, Tool Windows, Other Contributions

- **Strings:** Move display names and other localizable text (including `ToolTipText`) to `.vsextension/string-resources.json`, referenced as `%Key%` in configuration. Keys must be globally unique across all of Visual Studio. The file at the **root** of `.vsextension` is the default; add localized variants in locale subfolders (`.vsextension/de/string-resources.json`, `.vsextension/it/...`, etc.). Localizable config properties carry `LocalizableStringAttribute`; the compiler warns if you set them to a non-localizable literal.
- **Icons:** Prefer `ImageMoniker.KnownValues.*`. For custom icons, add `<Name>.16.16.png` and/or `<Name>.xaml` to an `Images` folder and reference with `ImageMoniker.Custom("<Name>")`; the build tools package them automatically.
- **Tool windows / options pages / other contributions:** Convert per the API mapping table in the reference file. Anything with no new-model equivalent stays on VS SDK behind the in-process host (see Phase 7a).

### Phase 7a: Keeping an AsyncPackage or MEF Component (in-process only)

When the extension depends on functionality with no VisualStudio.Extensibility equivalent (classifiers, taggers, language services, or a service exposed by your own `AsyncPackage`), keep that piece and bridge to it. See the **AsyncPackageAndMEF** sample. Key rules:

- The `Extension`, MEF components, and `AsyncPackage` are each initialized **independently**. Before one interacts with another, the initiator must ensure the other is initialized (typically by requesting a service via `GetServiceAsync`, which triggers lazy init).
- **Keep an `AsyncPackage`:** derive from `AsyncPackage`, expose state via `[ProvideService(typeof(MyService), IsAsyncQueryable = true)]` + `AddService(..., promote: true)`, set `<GeneratePkgDefFile>true</GeneratePkgDefFile>` and `<UseCodebase>true</UseCodebase>`, and add `<Asset Type="Microsoft.VisualStudio.VsPackage" Path="<Name>.pkgdef" />` to the manifest. Inject the service into a command with `AsyncServiceProviderInjection<MyService, MyService>`.
- **Keep MEF components:** mark with `[Export(typeof(MyMEFComponent))]`, add `<Asset Type="Microsoft.VisualStudio.MefComponent" Path="<Name>.dll" />` to the manifest, and inject with `MefInjection<MyMEFComponent>`.
- **Call from the package back into VisualStudio.Extensibility:** proffer a brokered service from the `Extension` (`serviceCollection.ProfferBrokeredService(...)` in `InitializeServices`) and retrieve a proxy from the package via `IBrokeredServiceContainer.GetFullAccessServiceBroker().GetProxyAsync<T>(...)`.

### Phase 8: Manifest & Remove Dead Scaffolding

- Update `source.extension.vsixmanifest`: for in-process set `<Installation ExtensionType="VSSDK+VisualStudio.Extensibility">` and keep the install targets/prerequisites. If you kept an `AsyncPackage` or MEF component (Phase 7a), add the corresponding `<Asset>` entries (`Microsoft.VisualStudio.VsPackage` for the pkgdef, `Microsoft.VisualStudio.MefComponent` for the DLL).
- Delete the `AsyncPackage` subclass, `.vsct` file(s), generated command-table `.cs`, command-ID constant files, and `[Provide*]` registration attributes that the new model replaces. (See the dead-code rule: remove all newly-unreachable code, not just the obvious file.)

### Phase 9: Reload Solution

Reload the solution so the IDE picks up the new model before building or F5. Skip if running outside VS.

## 4. Validation

After reloading, verify:

- [ ] Project builds successfully (`msbuild`)
- [ ] A `.vsix` is produced
- [ ] F5 deploys to the experimental instance and the debugger attaches
- [ ] **Every** command from the assessment appears in the correct menu/toolbar location
- [ ] Command enable/visibility rules behave as before (right file types, contexts)
- [ ] Keyboard shortcuts work
- [ ] Each command's behavior matches the pre-conversion baseline
- [ ] Tool windows / options pages function
- [ ] No leftover `.vsct`, `AsyncPackage`, or command-ID scaffolding remains
- [ ] Localizable strings resolve from `string-resources.json` (no raw `%Key%` shown in UI)

## Error Handling

| Problem | Likely Cause | Fix |
|---------|-------------|-----|
| Extension loads but commands missing | Contribution not discovered | Ensure each `Command`/`MenuConfiguration` is marked `[VisualStudioContribution]` and the menu placement references the command via `MenuChild.Command<T>()` |
| `%CommentRemover.X.DisplayName%` shown literally in UI | Missing/mismatched string key | Add the key to `.vsextension/string-resources.json`; the `%...%` token must match exactly |
| `COMException`/`InvalidOperationException` calling a VS SDK service | Call made off the UI thread | `await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();` before the VS SDK call |
| VS SDK service is null / not found | Service not injected, or extension is out-of-process | Inject via `AsyncServiceProviderInjection<,>` / `MefInjection<>`; for VS-SDK-only services the extension must be in-process (`RequiresInProcessHosting = true`, `VssdkCompatibleExtension = true`) |
| Extension never loads / no in-proc host | Missing in-proc configuration | Set `RequiresInProcessHosting = true` on the `Extension` and `<VssdkCompatibleExtension>true</VssdkCompatibleExtension>` in the project; manifest `ExtensionType` = `VSSDK+VisualStudio.Extensibility` |
| Build error: `Microsoft.VisualStudio.Extensibility` types not found | Missing SDK/Build packages | Add `Microsoft.VisualStudio.Extensibility.Sdk` and `Microsoft.VisualStudio.Extensibility.Build` package references |
| Duplicate command / placement | Old `.vsct` still compiled | Remove `VSCTCompile` items and delete the `.vsct`; placements now live in `MenuConfiguration` |
| Build error evaluating compile-time constant configuration | `CommandConfiguration`/`MenuConfiguration` references non-static members or uses imperative code | Make the config property a pure compile-time constant; move runtime logic into `ExecuteCommandAsync` |
| Kept `AsyncPackage`/MEF service never initializes | Components initialize independently; no one triggered init | Trigger lazy init by requesting the service (`GetServiceAsync`); ensure pkgdef/MEF `<Asset>` entries and `GeneratePkgDefFile`/`UseCodebase` are set |
| Wrong target framework error | Targeting net6.0+/net8.0 for in-proc | In-process VS2022 extensions must target `net472` |

## Success Criteria

- Extension uses the VisualStudio.Extensibility programming model for its contributions (commands, menus, tool windows, configuration).
- In-process extensions consume required VS SDK services via dependency injection (`AsyncServiceProviderInjection<,>` / `MefInjection<>`).
- The `.vsct` file and `AsyncPackage` scaffolding are gone; commands are defined in one place.
- Every contribution behaves identically to the original VSSDK extension (behavior-preserving conversion).
- The extension builds, deploys with F5, and the debugger attaches in the experimental instance.
