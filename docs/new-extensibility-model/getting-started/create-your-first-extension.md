---
title: Creating your first extension reference
description: A reference for creating your first OOP extension
date: 2021-8-16
---

# Creating your first Visual Studio Out-of-Process extension

## Prerequisites

* Visual Studio 2022 Preview 3 with managed languages workload.

* Visual Studio Extensibility Project Extension: This extension will allow you to debug extension projects using F5. There is currently no other deployment mechanism supported.

## Create the extension project

* The extensibility APIs are distributed via nuget packages, so you can start with an empty .NET 6.0 C# class library project.

* Once project is created change `TargetFramework` from `net6.0` to `net6.0-windows`.

* Add references to `Microsoft.VisualStudio.Extensibility` and `Microsoft.VisualStudio.Extensibility.Build` packages.

At this point you are ready to start extending Visual Studio by adding commands and editor components to your extension.

## Add a command handler

* Create a new `.cs` file and include the following code:

```csharp
namespace SimpleRemoteCommandSample
{
	using System.Diagnostics;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;

	[CommandIcon("Extension", IconSettings.IconAndText)]
	[Command(
        "SimpleRemoteCommandSample.Command", 
        1 /* command id */, 
        "Sample Remote Command", 
        placement: KnownCommandPlacement.ToolsMenu)]
	public class CommandHandler : Command
	{
		private TraceSource traceSource;

		public CommandHandler(VisualStudioExtensibility extensibility, TraceSource traceSource, ushort id)
			: base(extensibility, id)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.traceSource.TraceInformation($"Executing command {CommandName}");
			return Task.CompletedTask;
		}
	}
}
```

For more information on how to add commands, please refer to `TBD`.

## Debug your extension

* Making sure that your extension project is selected as startup projet in Visual Studio, press `F5` to start debugging.

* This will build your extension and deploy it to experimental instance of Visual Studio version your are using. The debugger should attach once your extension is loaded.