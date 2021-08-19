---
title: Creating your first extension reference
description: A reference for creating your first OOP extension
date: 2021-8-16
---

# Creating your first Out-Of-Process Visual Studio extension

## Introduction
This document is a quick walkthrough on how to create your first extension using the new out-of-process extensibility model.

The complete project can be found at [SimpleRemoteCommandSample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample) but these steps will help you understand the requirements and dependencies.

## Prerequisites

* Visual Studio 2022 Preview 3 with managed languages workload.

* Visual Studio Extensibility Project Extension: This extension will allow you to debug extension projects using F5. There is currently no other deployment mechanism supported.

Extension can be downloaded from: TBD

## Create the extension project

* The extensibility APIs are distributed via nuget packages, so you can start with an empty .NET 6.0 C# class library project.

* Once project is created change `TargetFramework` from `net6.0` to `net6.0-windows` by editing project file or changing Target OS to `Windows` in project properties.

![Target Framework Properties](TargetFrameworkProperties.PNG "Target Framework Properties")

* Add references to `Microsoft.VisualStudio.Extensibility.Sdk` and `Microsoft.VisualStudio.Extensibility.Build` nuget package through adding the following section to your project file.

```
<ItemGroup>
	<PackageReference Include="Microsoft.VisualStudio.Extensibility.Sdk" Version="17.0.159-alpha" />
	<PackageReference Include="Microsoft.VisualStudio.Extensibility.Build" Version="17.0.159-alpha" />
</ItemGroup>
```


* Add a [source.extension.vsixmanifest](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample/source.extension.vsixmanifest) file to describe your extension including name, description and unique identifier. This information in the future will be used to list the extension in the gallery.

At this point you are ready to start extending Visual Studio by adding commands and editor components to your extension.

## Add a command handler
In this step we will add a new command to Visual Studio to perform an action when user executes the command. In this case the command will be represented by a new menu item under `Tools` menu as specified by the placement parameter below.

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

For more information on how to add commands, please refer to [Commands](../extension-guides/command/command.md) section.

## Debug your extension

* Making sure that your extension project is selected as startup projet in Visual Studio, press `F5` to start debugging.

* This will build your extension and deploy it to experimental instance of Visual Studio version your are using. The debugger should attach once your extension is loaded.

* You can find the command in `Tools` menu as shown.

![SampleCommand](ExtensionCommand.PNG "Sample command")