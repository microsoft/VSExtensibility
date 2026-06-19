# VSSDK SDK-Style Conversion Instructions

These instructions guide Copilot through converting a Visual Studio extension (VSIX / VSSDK) project from the legacy (old-style) `.csproj` format to the modern SDK-style format, while preserving VSIX packaging, F5 debugging, and extension functionality.

Refer Copilot to this document when asked to "convert VSIX to SDK style", "modernize a VS extension project", "migrate a VSSDK project", "produce an SDK-style VSIX", or "update an extension csproj format".

The conversion is **format-only**: it must not change the target framework, the extension's behavior, or its public surface.

## Workflow Stages

```
┌──────────────────────────────────────────────────┐
│ 1. ASSESSMENT                                    │
│    Analyze VSIX project structure and risks      │
│    → Creates: assessment.md                      │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 2. PLANNING                                      │
│    Create conversion plan with VSSDK specifics   │
│    → Creates: plan.md                            │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 3. EXECUTION                                     │
│    Convert project + apply VSSDK overlay         │
│    → Modifies: project file, solution file       │
└───────────────────────┬──────────────────────────┘
                        │
                        ▼
┌──────────────────────────────────────────────────┐
│ 4. VALIDATION                                    │
│    Build, verify VSIX output, deploy markers     │
└──────────────────────────────────────────────────┘
```

## 1. Assessment

Analyze the VSIX project to understand its structure and identify conversion considerations.

### What to Capture

| Aspect | Where to Look | Why It Matters |
|--------|--------------|----------------|
| VSIX manifest | `source.extension.vsixmanifest` | Must preserve generator metadata |
| VSCT command tables | `*.vsct` files (may be multiple) | Need all `VSCTCompile` items preserved |
| Tool windows / MEF exports | `[Export]`, `[ProvideToolWindow]` attributes | May require framework references |
| Current packages | `packages.config` or `PackageReference` items | Must migrate to VSSDK metapackages; VSSDK.BuildTools must be ≥18.5.38461 — **never downgrade** an existing higher version |
| Custom build targets | `<Import>` elements beyond standard VS SDK imports | May need preservation |
| Solution format | `.sln` vs `.slnx` | Determines deploy marker format |
| Existing debug config | `StartAction`/`StartProgram` in csproj; `Deploy.0` in sln | Replaced by deploy markers |
| Target framework | `TargetFrameworkVersion` / `TargetFramework` | Keep `net48` if using Community.VisualStudio.Toolkit.17 |
| Auto-generated files | Files with `<AutoGen>True</AutoGen>` metadata | Must switch to `<Compile Update>` |

### Risk Indicators

- **packages.config present** — must migrate to PackageReference first (the base conversion step handles this)
- **Custom MSBuild logic** — review for compatibility with SDK-style defaults
- **Multiple VSIX projects** — each needs independent conversion and deploy markers
- **ASP.NET-style web components** — SDK-style support is limited for web project types

### Assessment Output

Create `assessment.md`:

```markdown
# Assessment: VSSDK SDK-Style Conversion

## Target Project
| Property | Value |
|----------|-------|
| Project | [name] |
| Path | [path] |
| Current TFM | [e.g., net472, net48] |
| Solution format | [.sln / .slnx] |
| packages.config | [Yes/No] |

## VSIX Components Found
- [ ] VSIX manifest (source.extension.vsixmanifest)
- [ ] VSCT command table ([file])
- [ ] Tool windows
- [ ] MEF exports
- [ ] Custom editors
- [ ] Language services

## Current Package References
[list current VS SDK packages and versions]

## Baseline
- Project builds: [Yes/No]
- Solution builds: [Yes/No]

## Key Findings
[Notable patterns, risks, or decisions needed]
```

## 2. Planning

Create `plan.md` with ordered tasks. VSSDK projects are typically standalone for conversion purposes, but verify no other projects depend on the VSIX output.

### Task Ordering

1. **Pre-conversion** — Unload the project if the IDE has it loaded (prevents file locks and stale caches)
2. **Base conversion** — Apply the base SDK-style format change (see Phase 1)
3. **VSSDK overlay** — Apply extension-specific project changes
4. **Solution update** — Add deploy markers to the solution file
5. **Reload solution** — Reload the solution so the IDE picks up all changes
6. **Validate** — Build and verify VSIX output

### Project Unloading

If the project is loaded in Visual Studio during conversion, unload it first. The IDE locks project files and caches project state — modifying the file while loaded risks corruption or stale evaluation. After conversion completes, reload the project so VS picks up the new SDK-style format cleanly.

If running outside VS (CLI or VS Code), skip this step.

## 3. Execution

### Tooling: Project File Modifications

All project file (`.csproj`) edits **must** use the edit file tool — never write, overwrite, or reconstruct the project file through PowerShell (e.g., `Set-Content`, output redirection, `[xml]` manipulation, or `Add-Content`). The project is unloaded specifically so the edit file tool can make surgical, targeted replacements that preserve formatting and minimize diff noise. PowerShell is only for build commands (`msbuild`, `dotnet build`), NuGet restore, and other non-file-editing operations.

This applies to all phases below: base conversion changes, VSSDK overlay changes, and any fix-up edits during validation.

### Phase 1: Base Conversion

Perform the structural conversion to SDK-style first. This is the standard SDK-style format change applied to any project:

- Change the project root element to `<Project Sdk="Microsoft.NET.Sdk">`
- Remove explicit `<Compile>` includes (SDK globbing takes over)
- Migrate from `packages.config` to `PackageReference` (if present)
- Remove legacy `<Import>` elements (e.g., `Microsoft.Common.props`, `Microsoft.CSharp.targets`)
- Drop the legacy XML namespace and `ToolsVersion` attribute from the `<Project>` element

After base conversion, the project is SDK-style but missing VSSDK-specific configuration.

### Phase 2: VSSDK Overlay

Load [references/vssdk-project-format.md](references/vssdk-project-format.md) for detailed property values, package versions, and the complete template.

Apply these changes in order:

1. **Core properties** — Add VSIX-specific properties to the main `PropertyGroup`: `VSSDKBuildToolsAutoSetup`, `VsixDeployOnDebug`, `UseCodebase`. Add `GeneratePkgDefFile` only if not already present — if the project already sets it, preserve the existing value.

2. **Project capability** — Add `<ProjectCapability Include="CreateVsixContainer" />`

3. **Auto-generated files** — Switch from `<Compile Include>` to `<Compile Update>` for files like `source.extension.cs` and `VSCommandTable.cs`. Using `Include` on auto-globbed files causes duplicate errors.

4. **VSCT items** — Preserve all `<VSCTCompile>` items as-is (there may be more than one; they work identically in SDK-style)

5. **VSIX manifest** — Keep `<None Include="source.extension.vsixmanifest">` with generator metadata

6. **Content items** — Preserve `<Content>` items with `<IncludeInVSIX>true</IncludeInVSIX>`

7. **Framework references** — Add based on assessment findings:
   - WPF usage → `PresentationCore`, `PresentationFramework`
   - MEF usage → `System.ComponentModel.Composition`
   - UITypeEditor → `System.Design` (rare)

8. **Package references** — Ensure VSSDK packages are present (see reference file for asset configuration):
   - `Microsoft.VSSDK.BuildTools` — **minimum version 18.5.38461 required; NEVER downgrade an existing higher version**. SDK-style VSIX projects do not work with older build tools — 18.5.38461 is a hard floor, not a target. If the project already references a version above 18.5.38461, **keep the existing version as-is** — downgrading causes obscure build failures and is never correct. Only raise the version if it is below the minimum. If the package cannot be added or restored at the minimum version (e.g., due to version constraints, feed issues, or central package management conflicts), **stop and report the blocker** — the conversion cannot proceed. After updating, perform a full clean (`msbuild /t:Clean` or delete `bin`/`obj` folders) before building, because stale build tool artifacts from older versions cause misleading errors. Never clear NuGet caches — only clean project output directories.
   - `Microsoft.VisualStudio.SDK` — keep existing version if already referenced; add if missing (replaces individual VS interop packages)
   - `Community.VisualStudio.Toolkit.17` (if used — keep existing version)
   - `Community.VisualStudio.VSCT` (if VSCT files present — keep existing version)

9. **Remove legacy artifacts**:
   - Delete `Properties/AssemblyInfo.cs` (SDK auto-generates assembly attributes). Move polyfills like `IsExternalInit` to standalone files. Keep custom attributes like `InternalsVisibleTo` in any `.cs` file.
   - Remove `StartAction`/`StartProgram`/`StartArguments` properties
   - Remove legacy `<Import>` elements for `Microsoft.Common.props`, `Microsoft.CSharp.targets`, `Microsoft.VsSDK.targets`
   - Remove properties listed in the reference file's "Properties to Remove" section

### Phase 3: Solution Update

Mark the project as deployable in the solution file. This replaces the old `StartAction`/`StartProgram` pattern for F5 debugging — `VsixDeployOnDebug=true` in the project file does the rest once deploy markers are set.

**For `.slnx` files:**
```xml
<Project Path="src/YourExtension.csproj">
    <Deploy />
</Project>
```

**For classic `.sln` files**, add `Deploy.0` entries in `GlobalSection(ProjectConfigurationPlatforms)`:
```
{PROJECT-GUID}.Debug|Any CPU.Deploy.0 = Debug|Any CPU
{PROJECT-GUID}.Release|Any CPU.Deploy.0 = Release|Any CPU
```

### Phase 4: Reload Solution

After all file edits and solution updates are complete, reload the solution so the IDE picks up the new SDK-style format and deploy markers. This must happen **before** building or verifying — building against stale cached project state produces misleading results.

If running outside VS (CLI or VS Code), skip this step.

## 4. Validation

After reloading, verify:

- [ ] Project builds successfully (`msbuild`)
- [ ] `.vsix` file is produced in the output directory
- [ ] No duplicate `Compile` item warnings
- [ ] `packages.config` removed (if it existed)
- [ ] `Properties/AssemblyInfo.cs` removed
- [ ] Solution file contains deploy markers for the project
- [ ] No legacy `<Import>` elements remain
- [ ] No `StartAction`/`StartProgram` properties remain
- [ ] Target framework unchanged from pre-conversion value

## Error Handling

| Problem | Likely Cause | Fix |
|---------|-------------|-----|
| Build tools version blocked | Central package management or feed constraint prevents VSSDK.BuildTools ≥18.5.38461 | Resolve version conflict in Directory.Packages.props or NuGet config — **conversion cannot proceed** without this minimum |
| **Build tools downgraded** | **Replaced a higher VSSDK.BuildTools version with 18.5.38461** | **NEVER downgrade — 18.5.38461 is a floor, not a target. Restore the original higher version immediately.** |
| Stale build artifacts after conversion | Old build tools artifacts in `bin`/`obj` | Full clean: `msbuild /t:Clean` or delete `bin`/`obj` directories. Never clear NuGet caches. |
| Build or restore fails with file-lock errors | `dotnet` or `msbuild` processes holding locks on project outputs, NuGet cache, or build artifacts | Kill all `dotnet` and `msbuild` processes (`Stop-Process -Name dotnet -Force; Stop-Process -Name msbuild -Force`), then retry the build. If insufficient permissions prevent killing processes, ask the user to close Visual Studio and/or run `taskkill /F /IM dotnet.exe & taskkill /F /IM msbuild.exe` from an elevated prompt. |
| CreatePkgDef task fails or hangs | Stale `msbuild`/`dotnet` processes caching old build tool assemblies | Kill all `dotnet` and `msbuild` processes, clean `bin`/`obj`, then rebuild. Same escalation to user if permissions are insufficient. |
| `CS0234: 'Composition' does not exist` | Missing framework reference | Add `<Reference Include="System.ComponentModel.Composition" />` |
| `CS0234: 'Controls' does not exist` | Missing WPF reference | Add `<Reference Include="PresentationFramework" />` |
| Duplicate `Compile` items | Using `Include` instead of `Update` | Change to `<Compile Update="file.cs">` |
| Assembly info conflicts | SDK generates attributes conflicting with `AssemblyInfo.cs` | Delete `AssemblyInfo.cs` or set `<GenerateAssemblyInfo>false</GenerateAssemblyInfo>` |
| F5 doesn't launch experimental instance | Missing deploy markers in solution | Add deploy entries to `.sln`/`.slnx` |
| `CS0246: 'Community' could not be found` | Toolkit targets `net48` but project targets `net472` | Change `<TargetFramework>` to `net48` |

## Success Criteria

- Project format is SDK-style with VSSDK configuration
- Project builds and produces a `.vsix`
- Solution deploy markers enable F5 debugging to the experimental instance
- No target framework changes (format-only conversion)
- All VSIX components (manifest, VSCT, content) preserved
