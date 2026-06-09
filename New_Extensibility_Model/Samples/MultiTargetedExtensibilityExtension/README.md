# MultiTargetedExtensibilityExtension

This sample demonstrates an out-of-process **VisualStudio.Extensibility** extension built with the new
SDK-style project format. The extension runs out of process and is described entirely through the
VisualStudio.Extensibility programming model.

## What it shows

- An SDK-style `.csproj` with `<ExtensionType>VisualStudio.Extensibility</ExtensionType>`.
- An out-of-process extension defined by `ExtensionEntrypoint`, including its metadata
  (id, version, publisher, display name, and description).
- A `VisualStudio.Extensibility` command (`Command1`) contributed declaratively with
  `[VisualStudioContribution]` and placed on the **Extensions** menu.
- Dependency injection through `InitializeServices` and constructor-injected services such as
  `TraceSource`.
- Conditional compilation (`VS_185_OR_GREATER`) to light up version-specific behavior.

## Project layout

| File | Purpose |
| --- | --- |
| `MultiTargetedExtensibilityExtension.csproj` | SDK-style out-of-process Extensibility project. |
| `ExtensionEntrypoint.cs` | Extension metadata and service registration. |
| `Command1.cs` | VisualStudio.Extensibility command handler. |

## Running the sample

1. Open `Samples.slnx` in Visual Studio.
2. Set this project as the startup project.
3. Press <kbd>F5</kbd> to launch the experimental instance.
4. Choose **Extensions > Command1** to see the prompt.
