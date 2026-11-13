## Language Configuration Sample

This is a sample project that shows how language configuration works and can be used as an example for creating your own. 

## Running the sample

Open [Samples.slnx](../Samples.slnx) in Visual Studio with the **Visual Studio extension development** workload installed.
Set **LanguageConfigurationSample** as the startup project and press **F5** to launch the experimental instance.
This content-only VSSDK sample uses `Microsoft.VisualStudio.Sdk.Build` and targets Visual Studio 2022 version 17.14 (`vs17_14`). Building it requires Visual Studio 2026 version 18.11 or later with the **Visual Studio extension development** workload.

The VSIX contains the language-configuration JSON file, TextMate grammar, and `Test.pkgdef`
registration file. It does not need a package class, a generated package registration file,
or any DLLs. `GeneratePkgDefFile`, `IncludeAssemblyInVSIXContainer`, and
`IncludeCopyLocalReferencesInVSIXContainer` are disabled in the project.

## Language Configuration json file
When making your own language configuration file, you can choose which aspects to onboard in the JSON file. For example, you can choose to support comment toggling, autoclosing of braces, or any combination of the available functionality described in this section. The name of the file must follow a standard: use hyphens to separate the words in the filename, and make sure it ends with language-configuration.json

Example-language-configuration.json is a sample that you can refrence when creating your own.

## Grammar File
Adding a grammar file is optional.  If you don't provide a language-specific grammar file, a built-in default setting is used. To add a custom TextMate Grammar, create a Grammar folder and inside that folder you add your grammar file. 

## Pkgdef File
A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Your pkgdef file, you should have the path to the language-configuration.json file and the path for the language grammar. Use Test.pkgdef file as an example. 

Include the pkgdef file as a `Content` item in the project. `Microsoft.VisualStudio.Sdk.Build`
includes `Content` items in the VSIX by default; no explicit `IncludeInVSIX` or
`CopyToOutputDirectory` metadata is required.

## VSIX
In order to make the language configuration information accessible for Visual Studio, include the language-configuration file in the VSIX package.  To let Visual Studio know that a Language Configuration is available for use. Edit your vsixmanifest to add your PKGDEF def file. source.extension.vsixmaifest shows how to do that.


All together this provide information that enables the Visual Studio editor to make formatting, colorization, and completion decisions without the delay of making an asynchronous query to the LSP server. 

