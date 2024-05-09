---
title: VS Project Query API Extension reference
description: A reference for VS Project Query API Extension reference
date: 2024-1-11
---

# Walkthrough: VS Project Query API Extension

This extension demonstrates the most basic usage of the [VS Project Query API](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/project/project) into commands that query information and updates to the project system.

## Overview

The Project System Query API allows you to retrieve and update information in the Project System such as files, build configurations, dependencies, and much more.

## Setting Up IProjectModelQueryableSpace

Add `Microsoft.VisualStudio.ProjectSystem.Query` NuGet Package to the solution's `references` to get access to the API.

The code snippet as seen below sets up the Project Query Service for the project:

```csharp
WorkspacesExtensibility querySpace = this.Extensibility.Workspaces();
```

## Accessing API Metadata

Once a `querySpace` is established, you may query information about the Project System on the Solution and/or Project level. Using the keyword `With`, you can specify the property and/or the collection they want to receive.

In our example, we call the `QueryProjectsAsync` method to get information from the projects, namely the Project Name, Project Path, Project Files, and File Names.

```csharp
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
	project => project.With(project => project.Name)
		.With(project => project.Path)
		.With(project => project.Files.With(file => file.FileName)),
	cancellationToken);
```

## Modifying the Project System

Using the same `querySpace`, you may modify data in your project system. `Where` is used to filter the query result based on a predicate. `UpdateProjectsAsync` is to update the object from the query result. These actions modifying the Project System may include creating/deleting files, building/cleaning/deploying solutions, setting properties, and more.

In our example, we call the `UpdateProjectsAsync` method to create a new file. The file we want to add is called `CreatedFile.txt`, and we want to add it to our project called `ConsoleApp1`.

```csharp
await this.Extensibility.Workspaces().UpdateProjectsAsync(
	project => project.Where(project => project.Name == "ConsoleApp1"),
	project => project.AddFile("CreatedFile.txt"),
	cancellationToken);
```

## Different Query Patterns

There are various patterns to query information about the project system, such as querying by project, name, and id.

For the following examples, we will be querying information about [Output Groups](https://learn.microsoft.com/dotnet/api/envdte.outputgroups?view=visualstudiosdk-2022), a group of built files for the project or the outputs for a project.


### Querying By Project

You may filter out metadata By Project in your solution.

In the snippet below, the result will contain information about Output Groups' names about all projects in our Solution.

```csharp
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
	project => project.With(p => p.Name)
		.With(p => p.ActiveConfigurations
		.With(c => c.Name)
		.With(c => c.OutputGroups.With(g => g.Name))),
	cancellationToken);
```

### Querying By Name

If you know which metadata you would like to obtain, you may filter that information `ByName` if that metadata contains a ByName method.

In the snippet below, we call `OutputGroupsByName` to get specific Output Groups. The Project System Query API will add valid output group to the results, and invalid groups are skipped over. In this case, results will contain three output groups: `Built`, `XmlSerializer`, and `SourceFiles`.

```csharp
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
	project => project.With(p => p.Name)
		.With(p => p.ActiveConfigurations
		.With(c => c.Name)
		.With(c => c.OutputGroupsByName("Built", "XmlSerializer", "SourceFiles", "RandomNameShouldntBePickedUp")
		.With(g => g.Name))),
	cancellationToken);
```

### Querying By Id

As usages for project query becomes more complex, you may realize that the require more information from their query.

In our example, let's say we already queried information about Output Groups.

```csharp
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
	project => project.With(p => p.Name)
						.With(p => p.ActiveConfigurations.With(c => c.Name)),
	cancellationToken);
```

However, in addition to the output groups, we would want to collect the name of each group output group.  Notice `await group.AsQueryable()` is waiting to perform another query.

```csharp
await foreach (var project in result) 
{
	message.Append($"{project.Value.Name}\n");

	foreach (var config in project.Value.ActiveConfigurations) 
	{
		message.Append($" \t {config.Name}\n");

		foreach (var group in config.OutputGroups) 
		{
			// This is needed for byId:
			var newResult = await group.AsQueryable()
				.With(g => g.Name)
				.ExecuteQueryAsync();
		}
	}
}
```

Now `newResult` will contain information about OutputGroups' names.

## Sample Queries

Below is a showcase of queries that are available in the Project Query API

### Solution Level Queries

### Solution Build Actions

In project query, you also have the ability to invoke build actions on the solution level. These build actions include: `BuildAsync`, `RebuildAsync`,  `CleanAsync`, `DebugLaunchAsync`, and `LaunchAsync`.

```csharp
var result = await querySpace.Solutions
            .BuildAsync(cancellationToken);
```

### Loading/Unloading a Project

In the snippet below, we specify the solution we would like to unload the project from and pass in the project path when we make our `UnloadProject` call. 

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.UnloadProject(projectPath),
    cancellationToken);
```

Similarly, we can load the project by calling the `ReloadProject` API.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.ReloadProject(projectPath),
    cancellationToken);
```


### Saving a Solution

`SaveAsync` is an API call that can be used on the solution level.

```csharp
var result = await querySpace.Solutions.SaveAsync(cancellationToken);
```


### Actions for Startup Projects

Using the Project Query API, you also can select which projects get executed. In the sample below, we added two project paths to be set as the startup project.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.SetStartupProjects(projectPath1, projectPath2),
    cancellationToken);
```

### Actions for Solution Configurations

`AddSolutionConfiguration` is an API call that takes in three parameters. The first parameter is the new name we want to give our new solution configuration. In this scenario, we will call our new solution configuration `Foo`. The next parameter is the configuration to base our new configuration. Below, we based our new solution configuration on the existing solution configuration, `Debug`. Lastly, the boolean represents if the solution configuration should be propagated.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.AddSolutionConfiguration("Foo", "Debug", false),
    cancellationToken);
```

`DeleteSolutionConfiguration` is an API call that removes the solution configuration. In the example below, we removed the solution configuration called `Foo`.

```csharp
await this.Extensibility.Workspaces().UpdateSolutionAsync(
    solution => solution.Where(solution => solution.BaseName == solutionName),
    solution => solution.DeleteSolutionConfiguration("Foo"),
    cancellationToken);
```


### Project Level Queries

### Project Build Actions

On the project level, you many invoke these build actions: `BuildAsync`, `RebuildAsync`,  `CleanAsync`, `DebugLaunchAsync`, and `LaunchAsync`.
While building on the project level, determine the selected project you want to build. In the example below, `result.First()` is an `IProjectSnapshot` that will be built.

```csharp
await result.First().BuildAsync(cancellationToken);
```

### Rename Project

In the example below, we specify the name of the project we would like to update. We then call `Rename` while passing in the new name of the project.

```csharp
var result = await querySpace.Projects
    .Where(p => p.Name == "ConsoleApp1")
    .AsUpdatable()
    .Rename("NewProjectName")
    .ExecuteAsync(cancellationToken);
```

### Skip 1 Project

In the code sample, will query the projects in a solution and skip the first one. Let's say there are 3 projects in the solution: project1, project2, and project3. The return should be project2, and project3.

```csharp
var result = await this.Extensibility.Workspaces().QueryProjectsAsync(
            project => project.With(p => p.Name
            .Skip(1)),
            cancellationToken);
```

### Tracking Queries 

In the example, `TrackUpdatesAsync` is called on the Files property of a project, with a file name filter applied. This means it will track changes to the file names in the project. The TrackerObserver instance is passed to receive notifications of changes.

```csharp
var unsubscriber = await singleProject
    .Files
    .With(f => f.FileName)
    .TrackUpdatesAsync(new TrackerObserver(), CancellationToken.None);
```