# MultiTargetedHybridExtension

This sample demonstrates a **hybrid** extension that combines the classic **VSSDK** with the new
**VisualStudio.Extensibility** model in a single, SDK-style, multi-targeted project.

## What it shows

- An SDK-style `.csproj` with `<ExtensionType>VSSDK+VisualStudio.Extensibility</ExtensionType>`.
- In-process hosting via `RequiresInProcessHosting = true`, allowing VisualStudio.Extensibility
  contributions to run alongside VSSDK components.
- A `VisualStudio.Extensibility` command (`Command1`) contributed declaratively with
  `[VisualStudioContribution]` and placed on the **Extensions** menu.
- The `ExtensionEntrypoint` that configures the extension and its services.
- Conditional compilation (`VS_185_OR_GREATER`) to light up version-specific behavior.

## Project layout

| File | Purpose |
| --- | --- |
| `MultiTargetedHybridExtension.csproj` | SDK-style hybrid (VSSDK + Extensibility) project. |
| `ExtensionEntrypoint.cs` | Extension configuration and service registration. |
| `Command1.cs` | VisualStudio.Extensibility command handler. |
| `source.extension.vsixmanifest` | VSIX metadata and installation targets. |

## Running the sample

1. Open `Samples.slnx` in Visual Studio.
2. Set this project as the startup project.
3. Press <kbd>F5</kbd> to launch the experimental instance.
4. Choose **Extensions > Command1** to see the prompt.
