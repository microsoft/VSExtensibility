# MultitargetedVssdkExtension

This sample demonstrates a classic **VSSDK** (Managed Package Framework) extension built with the new
SDK-style project format and multi-targeting. A single project produces a VSIX that targets multiple
Visual Studio versions from one codebase.

## What it shows

- An SDK-style `.csproj` using `Microsoft.VisualStudio.Sdk.Build` with `<ExtensionType>VSSDK</ExtensionType>`.
- Multi-targeting across Visual Studio versions via `<TargetFrameworks>vs2022;vs2026_5</TargetFrameworks>`.
- A traditional `AsyncPackage` (`MultitargetedVssdkExtensionPackage`) registered with the shell.
- A `.vsct` command table that adds an **Invoke Command1** entry under the **Tools** menu.
- Conditional compilation (`VS_185_OR_GREATER`) to light up version-specific behavior.

## Project layout

| File | Purpose |
| --- | --- |
| `MultitargetedVssdkExtension.csproj` | SDK-style, multi-targeted VSSDK project. |
| `MultitargetedVssdkExtensionPackage.cs` | The `AsyncPackage` entry point. |
| `MultitargetedVssdkExtensionPackage.vsct` | Command, menu group, and bitmap definitions. |
| `Command1.cs` | Command handler that shows a message box. |
| `source.extension.vsixmanifest` | VSIX metadata and installation targets. |

## Running the sample

1. Open `Samples.slnx` in Visual Studio.
2. Set this project as the startup project.
3. Press <kbd>F5</kbd> to launch the experimental instance.
4. Choose **Tools > Invoke Command1** to see the message box.
