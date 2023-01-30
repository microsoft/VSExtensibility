---
title: VS Project Query API Extension reference
description: A reference for VS Project Query API Extension reference
date: 2022-1-20
---

# Walkthrough: VS Project Query API Extension

This extension demonstrates the most basic usage of the VS Project Query API into commands that query information and updates the project system.

## Overview

The Project System Query API allows users to retrieve and update information in the Project System such as files, build configurations, dependencies, and much more.

## Setting Up IProjectModelQueryableSpace

Add `Microsoft.VisualStudio.ProjectSystem.Query` NuGet Package to the solution's `references` to get access to the API.

The code snippet below as seen below sets up the Project Query Service for the project:

```csharp
ProjectQueryableSpace querySpace = new ProjectQueryableSpace(serviceBroker: serviceBroker, joinableTaskContext: null);
```

The `querySpace` requires a service broker to gain access to information in the Project System.

## Accessing API Metadata

Once the user establishes a `querySpace`, users may query information about the Project System on the Solution and/or Project level. Using the keyword `With` the query can collect the value of a property/collection.

In our example, we call the `QueryAsync` method to get information from the projects, namely the Project Name, Project Path, Project Files, and File Names.

```csharp
var result = querySpace.Projects
			.With(project => project.Name)
			.With(project => project.Path)
			.With(project => project.Files
			.With(file => file.FileName))
.QueryAsync(CancellationToken.None);
```

## Modifying the Project System

Using the same `queryableSpace`, users may modify data in their project system. `Where` is used to identify the value of a property/collection to be returned from the query and `AsUpdatable` is to update the object from the query result. These actions modifying the Project System may include creating/deleting files, building/cleaning/deploying solutions, setting properties, and more.

In our example, we call the `ExecuteAsync` method to create a new file. The file we want to add is called `CreatedFile.txt`, and we want to add it to our project called `ConsoleApp1`.

```csharp
var result = await queryableSpace.Projects
			.Where(project => project.Name == "ConsoleApp1")
			.AsUpdatable()
			.CreateFile("CreatedFile.txt")
.ExecuteAsync();
```

## Filtering

Users can filter out the desired data they would like to collect.

### Querying ByName

If the users know which metadata they would like to obtain, they may filter that information `ByName` if that metadata contains a ByName method.

In the snippet below, we call `OutputGroupsByName` to get specific Output Groups. The Project System Query API will add valid output group to the results, and invalid groups are skipped over. In this case, results will contain three output groups: `Build`, `XmlSerializer`, and `SourceFiles`.

```csharp
var result = querySpace.Projects
	.With(p => p.Name)
	.With(p => p.ActiveConfigurations
		.With(c => c.Name)
		.With(c => c.OutputGroupsByName("Built", "XmlSerializer", "SourceFiles", "RandomNameShouldntBePickedUp")
		.With(g => g.Name)))
	.QueryAsync(CancellationToken.None);
```

### Querying ById

As usuages for project query becomes more complex, users may realize that the require more information from their query.

In our example, let's say we query information about Output Groups.

```csharp
var result = space.Projects
	.With(p => p.Name)
	.With(p => p.ActiveConfigurations
		.With(c => c.Name)
		.With(c => c.OutputGroups))
	.QueryAsync(CancellationToken.None);
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
