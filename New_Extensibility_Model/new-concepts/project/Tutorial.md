---
title: Tutorial: Working with the Project Query API
description: An overview of top scenarios for working with the Project Query API
date: 2023-01-13
author: hwelliver
ms.author: hwelliver
ms.technology: vs-ide-sdk
ms.topic: tutorial
ms.date: 01/13/2023
ms.custom: template-overview
---
# Working with the Project Query API

## Common User Scenarios

This overview covers top scenarios for working with the Project Query API:

- [Getting the project query space in Gladstone](#project-query-space)
- [Selecting specific properties from Extensions](#selecting-specific-properties)
- [Conditional filtering for Extensions](#conditional-filtering)
- [Using an Extension to recursively access a collection of children in one query](#recursive-collection)
- [Using the Get method](#the-get-method)
- [Using the IAsyncEnumerable method](#the-iasyncenumerable-method)
- [Querying information from a previous item](#querying-from-previous)
- [Extensions make changes through the query API](#extensions-make-changes)
- [Getting information from the Solution File](#get-info-from-solution-file)
- [Getting projects and project properties](#get-projects-properties)
- [Getting solution filters](#get-solution-filters)
- [Enumerating source files with additional information in a project/solution folder](#source-files-additional-information)
- [Finding all projects owning a specific source file](#find-all-projects)
- [Accessing project configurations and their properties](#access-project-configurations)
- [Enumerating project to project references](#project-to-project-references)
- [Enumerating package references of projects](#package-references)
- [Getting project output groups](#get-project-output-groups)

## Getting the project query space in Gladstone

Here is an example of getting the project query space in Gladstone:

```csharp
var workSpace = this.Extensibility.Workspace();
```
Gladstone will wrap QueryableSpace functions through its top level workspace object.
Note that the entry point for in-proc usage is slightly different:
```csharp
var queryService = await package.GetServiceAsync<IProjectSystemQueryService, IProjectSystemQueryService>();
var workSpace = queryService.QueryableSpace;
```

## Selecting specific properties from Extensions

Extensions can retrieve necessary information from projects by selecting specific properties needed.
Here is a sample to enumerate all projects, so the caller can divide them into various catalogs:

```csharp
var allProjects =               // IQueryResult<IProjectSnapshot> : IEnumerable<IProjectSnapshot>
    await workSpace.Projects
        .With(p => p.Path)
        .With(p => p.Guid)
        .With(p => p.Kind)      // DTE.Project.Kind
        .With(p => p.Type)      // VSHPROPID_ProjectType
        .With(p => p.TypeGuid)  // VSHPROPID_TypeGuid
        .With(p => p.Capabilities)
        .QueryAsync(cancellationToken);
foreach (var project in allProjects)
{
    var projectGuid = project.Guid;
    // Check whether 'Capabilities' property is retrieved.
    // Otherwise, it can throw for projects which do not support it. (Like SQL projects)
    if (project.PropertiesAvaliableStatus.Capabilities)
    {
        string capabilities = project.Capabilities;
    }
}
```

Or multiple properties can be requested in a single line:

```csharp
var allProjects = // IQueryResult<IProjectSnapshot> : IEnumerable<IProjectSnapshot>
    await workSpace.Projects
        .With(p => new { p.Path, p.Guid, p.Capabilities} )
        .QueryAsync(cancellationToken);
```

Using WithRequired, only projects supporting specific properties will be returned:

```csharp
var projectWithCapabilities =  // IQueryResult<IProjectSnapshot> : IEnumerable<IProjectSnapshot>
    await workSpace.Projects
        .With(p => new { p.Path, p.Guid })
        .WithRequired(p => p.Capabilities)
        .QueryAsync(cancellationToken);
```

When no properties are selected, the default set of properties will be returned. 
For example, both Name and Value properties will be retrieved in the following query:

```csharp
var properties =   // IQueryResult<IPropertySnapshot> : IEnumerable<IPropertySnapshot>
    await myProject.PropertiesByName("RootNamespace", "AssemblyVersion")
        .QueryAsync(cancellationToken);
```

## Conditional filtering for Extensions

Extensions can get information from a smaller set of projects through using conditional filtering.
Here is an example of finding all Net Core web projects. Not all projects support Capabilities, and this query will filter them out, instead of causing the query to fail.

```csharp
var webProjects =
    await workSpace.Projects
        .Where(p => p.Capabilities.Contains("DotNetCoreWeb"))
        .With(p => new { p.Path, p.Guid })
        .QueryAsync(cancellationToken);
// Or use built-in filtering
var webProjects =
    await workSpace.ProjectsByCapabilities("DotNetCoreWeb | DotNetCoreRazor")
        .With(p => new { p.Path, p.Guid })
        .QueryAsync(cancellationToken);
```

## Using an Extension to recursively access a collection of children in one query

Extensions can access a collection of children recursively in one query.
Here is an example getting project information along with source files and properties:

```csharp
var projects =
    await workSpace.ProjectsByCapabilities("CPS")
        .With(p => new { p.Path, p.IsProjectFileSearchable })
        .With(p => p.PropertiesByName("ApplicationIcon"))        // We only retrieve a single property, if it exists
        .With(p => p.Files                          // without any condition, we retrieve all files in the project, but we can filter them
            .Where(f => f.Extension == ".ico")
            .With(f => new { f.Path, f.IsHidden }))
        .QueryAsync(cancellationToken);
foreach (var project in projects)
{
    var property = project.Properties.FirstOrDefault();
    string? applicationIcon = (string?)property?.Value;
    // Here we can only files with the matched file extension.
    foreach (var iconFile in project.Files)
    {
        string filePath = iconFile.Path;
        bool isHidden = iconFile.IsHidden;
        ...
    }
}
```

## Using the Get method

Extensions can only retrieve a child collection through using the 'Get' method in the query
Here is an example getting a set of files included in a project as well as extra information about those files:

```csharp
var files =     // IQueryResult<IFileSnapshot> : IEnumerable<IFileSnapshot>
    await workSpace.Projects
        .Where(p => p.Guid == knownGuid)
        .Get(p => p.Files
            .With(f => new { f.Path, f.IsHidden, f.IsSearchable }))
        .QueryAsync(cancellationToken);
foreach (var file in files)
{
    string filePath = file.Path;
    ...
}
```

## Using the IAsyncEnumerable method

This example is similar to the last example, but using the IAsyncEnumerable instead:

```csharp
var fileResults =     // IAsyncEnumerable<IQueryResultItem<IFileSnapshot>>
    workSpace.ProjectsByGuid(knownGuid)
        .Get(p => p.Files
            .With(f => new { f.Path, f.IsHidden, f.IsSearchable }))
        .QueryAsync(cancellationToken);
await foreach (var fileResult in fileResults)
{
    IFileSnapshot file = fileResult.Value;
    string filePath = file.Path;
    ...
}
```

## Querying information from a previous item

Extensions may query further information from an item returned earlier in the session.
Here is an example of how to do so:

```csharp
var allProjects = // IQueryResult<IProjectSnapshot>
    await workSpace.Projects
        .With(p => p.Path)
        .With(p => p.Guid)
        .QueryAsync(cancellationToken);
foreach (var project in allProjects)
{
    // Gets child collections
    var files =  // IQueryResult<IFileSnapshot>
         await project.Files
            .With(f => new { f.Path, f.ItemType })
            .QueryAsync();
    foreach (var file in files)
    {
        string path = file.Path;
        ...
    }
    // Gets its own properties
    var projectsWithExtra =
        await project
            .AsQueryable()
            .With(p => p.Capabilities)
            .QueryAsync();
    
    var projectWithCapabilities = projectsWithExtra.First();    // the result always returns as a collection.
}
// query multiple of them
// this pattern allows a client doing filtering
var interestedProjects = allProjects
        .Where(p => /* client side filtering */)
        .ToList();
var projectsWithOutputGroupData =       // IQueryResult<IProjectSnapshot>
    workSpace.QueryFrom(interestedProjects)
        .With (p => p.ActiveConfigurations
            .With(c => c.OutputGroupsByName("Built")
                .With(g => g.Outputs
                    .With(item => item.FinalOutputPath))))
        .QueryAsync();
```

## Extensions make changes through the query API

Here is an example of extensions making changes through the query API:

```csharp
var updatedProjects =  // IQueryResult<IProjectSnapshot>
    await workSpace.ProjectsByGuid(knownGuid)
        .AsUpdatable()
        .CreateFile("AdditionalInformation.txt", textContent)
        .ExecuteAsync(cancellationToken);
```

And to make a change based on an item returned previously:

```csharp
var updatedProjects = // IQueryResult<IProjectSnapshot>
    await myProject.AsUpdatable()
        .CreateFile("AdditionalInformation.txt", textContent)
        .ExecuteAsync(cancellationToken);
```

## Getting information from the Solution File

Example:

```csharp
var solutions = // IQueryResult<ISolutionSnapshot>
    await workSpace.Solutions
        .With(s => new { s.Path, s.Guid, s.ActiveConfiguration, s.ActivePlatform })
        .QueryAsync(cancellationToken);
// We assume to have a single solution opened here.
var solution = results.Single();
```

## Getting projects and project properties

Example:


```csharp
var properties = await myProject.AsQueryable()      // IQueryResult<IPropertySnapshot>

    .Get(p => p.PropertiesByName("RootNamespace", "AssemblyVersion"))
    .QueryAsync(cancellationToken);
// We assume that we can find "RootNamespace" in the result.
// However it is not true from query API point of view.
// The query tries to retrieve items based on the condition, and if there is no such item, it will run successfully only without returning items.
string rootNamespace = (string)properties.Single(prop => prop.Name == "RootNamespace").Value;
```

## Getting solution filters

Here is an example of getting all solution folders, regardless of whether they are nested or not:

```csharp
var solutionFolders =   // IQueryResult<ISolutionFolderSnapshot>
    await workSpace.Solutions
        .Get(s => s.SolutionFolders)
        .With(folder => folder.Name)
        .With(folder => folder.IsNested)        // if we only want top level folders, we can filter on this property.
        .With(folder => folder.VisualPath)      // it is a relative (virtual) path to represent how the folder is nested.
        .QueryAsync(cancellationToken);
```

Here we are getting all nested solution folders, projects, files inside a solution folder (not recursively nested):

```csharp
var solutionFoldWithExtraInformation =  // IQueryResult<ISolutionSnapshot>
    await mySolutionFolder
        .AsQueryable()
        .With(folder => folder.Files
            .With(f => f.Path))
        .With(folder => folder.Projects
            .With(p => new { p.Name, p.Guid }))
        .With(folder => folder.SolutionFolders
            .With(nested => nested.Name))
        .QueryAsync(cancellationToken);
```

Here we are getting all recursively nested solution folders:

```csharp
string visualPath = mySolutionFolder.VisualPath;
var recursivelyNestedFolders = // IQueryResult<ISolutionFolderSnapshot>
    await workSpace.Solutions
        .Get(s => s.SolutionFolders)
        .Where(f => f.VisualPath.StartsWith(visualPath) && f.VisualPath != visualPath)
        .With(f => f.Name)
        .QueryAsync(cancellationToken);
```

## Enumerating source files with additional information in a project/solution folder

Here is an example enumerating all .xaml files in a project and its code generator:

```csharp
var files =  // IQueryResult<IFileSnapshot>
    await workSpace.ProjectsByGuid(knownGuid)
        .Get(p => p.Files)
        .Where(file => file.Extension == ".xaml")
        .With(file => file.Path)
        .With(file.PropertiesByName("Generator"))
        .QueryAsync(cancellationToken);
```

Another example is to start with a project returned from previous query:

```csharp
var files =
    await myProject.FilesEndingWith(".xaml")     // use built-in filter instead of 'Where' condition
        .With(file => file.Path)
        .With(file.PropertiesByName("Generator"))
        .QueryAsync(cancellationToken);
```

Or to get all content files:

```csharp
var files =
    await myProject.FilesWithItemTypes("Content")
        .With(file => file.Path)
        .QueryAsync(cancellationToken);
```

Or to enumerate all Xml Schema files in all projects through async enumerable:

```csharp
var schemaFiles =
    workSpace.Projects
        .Get(proj => proj.FilesEndingWith(".xsd"))
        .With(file => file.Path)
        .QueryAsync(cancellationToken);
await foreach (var fileResult in schemaFiles)
{
    DoSomething(fileResult.Value.Path);
}
```

## Finding all projects owning a specific source file

Example:

```csharp
string myFilePath = ...;
var projects =  // IQueryResult<IProjectSnapshot>
    await workSpace.Projects
        .WithRequired(proj => proj.FilesByPath(myFilePath))
        .With(proj => proj.Guid)
        .QueryAsync(cancellationToken);
```

Note: this doesn't include SolutionFolders, which must be queried separately:

```csharp
string myFilePath = ...;
var solutionFolders =  // IQueryResult<ISolutionFolderSnapshot>
    await workSpace.Solutions
        .Get(s => s.SolutionFolders)
        .WithRequired(folder => folder.FilesByPath(myFilePath))
        .With(folder => folder.Name)
        .With(folder => folder.Guid)
        .QueryAsync(cancellationToken);
```

## Accessing project configurations and their properties

Here is an example enumerating configurations of all known projects:

```csharp
var projects =
    await workSpace.Projects
        .With(p => new { p.Guid, p.Name })
        .With(p => p.Configurations
            .With(c => c.Name)
            .With(c => c.PropertiesByName("OutputPath"))
            .With(c => c.ConfigurationDimensions)) // ConfigurationDimension is essentially Name, Value pairs, both are default properties.
        .QueryAsync(cancellationToken);
foreach (var project in projects)
{
    foreach (var configuration in project.Configurations)
    {
        // ...
    }
}
```

## Enumerating project to project references

Here is an example enumerating all projects referenced by the current project:

```csharp
var projectReferences =     // IQueryResult<IProjectReferenceSnapshot>
    await myProject.ProjectReferences
        .With(r => r.ProjectGuid)
        .With(r => r.ReferencedProjectId)
    .QueryAsync(cancellationToken);
```

Here is an example of finding all projects referencing the current project:

```csharp
var projects =
    await workSpace.Projects
        .With(p => p.Guid)
        .WithRequired(p => p.ProjectReferences
            .Where(r => r.ProjectGuid == myProjectGuid))
    .QueryAsync(cancellationToken);
```

## Enumerating package references of projects

Here is an example enumerating all package references by the current project:

```csharp
var configurationsWithPackageReferences =  // IQueryResult<IProjectConfigurationSnapshot>
    await myProject.ActiveProjectConfigurations
        .With(c => c.Name)
        .With(c => c.PackageReferences
            .With(p => new { p.Name, p.Version }))
    .QueryAsync(cancellationToken);
```

This example finds all projects referencing a specific NuGet package:

```csharp
string packageName = "Newtonsoft.Json";
var projects =
    await workSpace.Projects
        .With(p => p.Guid)
        .WithRequired(p => p.ActiveProjectConfigurations
            .WithRequired(c => c.PackageReferences
                .Where(package => package.Name == packageName)))
    .QueryAsync(cancellationToken);
```

## Getting project output groups

Example:

```csharp
var configurations =
    await myProject.ActiveProjectConfigurations
        .QueryAsync(cancellationToken);
// a multi-target project may have multiple active configurations
var outputGroups =
    await configurations.First()
        .OutputGroupsByName("Built", "Symbols")
        .With(g => g.Name)
        .With(g => g.Outputs)
```