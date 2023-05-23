---
title: VS Project Query API Extension reference
description: A reference for VS Project Query API Extension reference
date: 2022-1-20
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

As usuages for project query becomes more complex, you may realize that the require more information from their query.

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
