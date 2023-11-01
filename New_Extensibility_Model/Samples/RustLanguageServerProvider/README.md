---
title: Rust Language Server Provider Sample Reference
description: Language server provider that runs the rust analyzer when a matching document is opened. 
date: 2023-10-31
---

# Walkthrough: Rust Language Server Provider Sample

This sample creates a Rust Language Server Provider extension that serves intellisense and tooltips when a rust file is opened in Visual Studio.

## Prerequisites
This sample requires installing [Rust](https://www.rust-lang.org/tools/install)  and copying [rust-analyzer.exe](https://github.com/rust-lang/rust-analyzer) found under releases named "rust-analyzer-x86_64-pc-windows-msvc.zip" into the project folder.

## Language Server Provider definition

The extension contains a code file that defines a language server provider and its properties starting with the `VisualStudioContribution` class attribute which makes the server available to Visual Studio:

```csharp
[VisualStudioContribution]
internal class RustLanguageServerProvider : LanguageServerProvider
{
```

The `LanguageServerProviderConfiguration` property defines information about the server that is available to Visual Studio even before the extension is loaded:

```csharp
public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration => new(
    "%RustLspExtension.RustLanguageServerProvider.DisplayName%",
    new[] 
    { 
        DocumentFilter.FromDocumentType(RustDocumentType) 
    });
```

This configuration object allows setting the display name for the server and specifying one or more document filters. You can also specify a localized string as a display name from [string-resoures.json](./.vsextension/string-resources.json):

```json
{
    "RustLspExtension.RustLanguageServerProvider.DisplayName": "Rust Analyzer LSP server"
}
```

## Activating the Language Server

Once a document that has a matching document type is opened, Visual Studio calls into `CreateServerConnectionAsync` and requests an `IDuplexPipe` that will be used to communicate with the language server. 

In our sample, the rust-analyzer executable is launched and a duplex pipe is used to communicate with the process.

```csharp
public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
{
    ProcessStartInfo info = new ProcessStartInfo();
    info.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, @"rust-analyzer.exe");
    info.RedirectStandardInput = true;
    info.RedirectStandardOutput = true;
    info.UseShellExecute = false;
    info.CreateNoWindow = true;

    Process process = new Process();
    process.StartInfo = info;

    if (process.Start())
    {
        return Task.FromResult<IDuplexPipe?>(new DuplexPipe(
            PipeReader.Create(process.StandardOutput.BaseStream),
            PipeWriter.Create(process.StandardInput.BaseStream)));
    }

    return Task.FromResult<IDuplexPipe?>(null);
}
```

## Disabling the server

`LanguageServerProvider` contains a public Boolean property `Enabled`, which is set to `true` by default. This property defines if Visual Studio should activate your server when a matching document type is opened. When `Enabled` is set to `False`, all currently running servers will be stopped and no new instances will be activated until re-enabled.

## Capturing and handling activation failures

After `CreateServerConnectionAsync` completes, Visual Studio will attempt to initialize the server via the provided duplex pipe following standard LSP protocol. Once this step is done, `OnServerInitializationResultAsync` is called where `ServerInitializationResult` denotes if the server succeeded or failed to initialize, and if it failed `LanguageServerInitializationFailureInfo` will contain the exception and message provided by the language server.

```csharp
public override Task OnServerInitializationResultAsync(ServerInitializationResult serverInitializationResult, LanguageServerInitializationFailureInfo? initializationFailureInfo, CancellationToken cancellationToken)
{
    if (serverInitializationResult == ServerInitializationResult.Failed)
    {
        // Log telemetry for failure and disable the server from being activated again.
        this.Enabled = false;
    }

    return base.OnServerInitializationResultAsync(serverInitializationResult, initializationFailureInfo, cancellationToken);
}
```

## Usage

Once deployed, the language server will automatically start once an applicable document type is opened.