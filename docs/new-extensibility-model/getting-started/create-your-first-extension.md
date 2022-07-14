---
title: Creating your first extension reference
description: A reference for creating your first OOP extension
date: 2021-8-16
---

# Creating your first out-of-process Visual Studio extension

## Introduction
This document is a quick walkthrough on how to create your first extension using the new out-of-process extensibility model.

The complete project can be found at [SimpleRemoteCommandSample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample) but these steps will help you understand the requirements and dependencies.

## Prerequisites

* Visual Studio 2022 Preview 3 or higher with managed languages workload.

* Install [VisualStudio.Extensibility Project System](https://marketplace.visualstudio.com/items?itemName=vsext.gladstone): This extension will allow you to debug extension projects using F5. There is currently no other deployment mechanism supported.

## Create the extension project

* The extensibility APIs are distributed via [nuget packages](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility.Sdk), so you can start with an empty .NET 6.0 C# class library project.

* Once project is created change `TargetFramework` from `net6.0` to `net6.0-windows` by editing project file or changing Target OS to `Windows` in project properties.

![Target Framework Properties](target-framework-properties.png "Target Framework Properties")

* Add references to `Microsoft.VisualStudio.Extensibility.Sdk` and `Microsoft.VisualStudio.Extensibility.Build` nuget package through adding the following section to your project file.

```
<ItemGroup>
	<PackageReference Include="Microsoft.VisualStudio.Extensibility.Sdk" Version="17.xxxxx" />
	<PackageReference Include="Microsoft.VisualStudio.Extensibility.Build" Version="17.xxxxx" />
</ItemGroup>
```

* To ensure extension dependencies are copied locally, set the `CopyLocalLockFileAssemblies` property in the project file:
```
<PropertyGroup>
	<CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
</PropertyGroup>
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
        "Sample Remote Command", 
        placement: KnownCommandPlacement.ToolsMenu)]
	public class CommandHandler : Command
	{
		private TraceSource traceSource;
		
		public CommandHandler(VisualStudioExtensibility extensibility, TraceSource traceSource, string name)
			: base(extensibility, name)
		{
			this.traceSource = Requires.NotNull(traceSource, nameof(traceSource));
		}

		public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			this.traceSource.TraceInformation($"Hello from another process!");
			return Task.CompletedTask;
		}
	}
}
```

For more information on how to add commands, please refer to [Commands](../extension-guides/command/command.md) section.

## Debug your extension

* Making sure that your extension project is selected as startup project in Visual Studio, press `F5` to start debugging.

* This will build your extension and deploy it to the experimental instance of Visual Studio version you are using. The debugger should attach once your extension is loaded.

* You can find the command in `Tools` menu as shown.

![SampleCommand](extension-command.png "Sample command")
