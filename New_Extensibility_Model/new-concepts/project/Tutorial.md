# Working with the Project Query API

The new project query API allows for querying information from the project system. Project systems are a part of VS components to help users work with and maintain projects, run builds to produce results, and to test output.

The goal of the Project Query API is to:
1. Work with Project Systems 
1. Retrieve data from projects
1. Make changes to projects 

Some examples include understanding files included in a project, NuGet packages referenced by a project, adding new files to a project, or changing project properties.

Find further information on project systems [here](https://github.com/microsoft/VSProjectSystem).
Find conceptual documentation about what the project system is, usages, and its various terms [here](https://github.com/microsoft/VSProjectSystem).

## Common User Scenarios

This overview covers top scenarios for working with the Project Query API:

- [Set up: Querying for a single project from your workspace using project guid](#set-up)
- [Getting the project query space in Gladstone](#project-query-space)
- [Selecting specific properties from Extensions](#selecting-specific-properties)
- [Conditional filtering for Extensions](#conditional-filtering)
- [Using an Extension to recursively access a collection of children in one query](#recursive-collection)
- [Using the Get method](#the-get-method)
- [Querying information from a previous item](#querying-from-previous)
- [Modifying a project](#modify-a-project)
- [Getting information from the Solution File](#get-info-from-solution-file)
- [Getting projects and project properties](#get-projects-properties)
- [Getting solution folders](#get-solution-folders)
- [Enumerating source files with additional information in a project](#source-files-additional-information)
- [Finding all projects owning a specific source file](#find-all-projects)
- [Accessing project configurations and their properties](#access-project-configurations)
- [Enumerating project to project references](#project-to-project-references)
- [Enumerating package references of projects](#package-references)
- [Getting project output groups](#get-project-output-groups)

## Getting the project query space in Gladstone

Before running queries on the project system, it is neccesary to obtain an instance of the project query space object.
The following shows an example of getting the project query space in Gladstone:

```csharp
var workSpace = this.Extensibility.Workspaces();
```
Gladstone will wrap QueryableSpace functions through its top level workspace object.
Note that the entry point for in-proc usage is slightly different:
```csharp
var queryService = await package.GetServiceAsync<IProjectSystemQueryService, IProjectSystemQueryService>();
var workSpace = queryService.QueryableSpace;
```

## Set up: Querying for a single project from your workspace using project guid

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projectList =
workSpace.ProjectsByProjectGuid(knownGuid) 
    .QueryAsync(cancellationToken);

IProjectSnapshot myProject = null;

await foreach (IQueryResultItem<IProjectSnapshot> project in projectList)
{
    myProject = project.Value;
}
```

## Selecting specific properties from Extensions

Extensions can retrieve necessary information from projects by selecting specific properties needed.
Here is an example enumerating all projects, so the caller can divide them into various catalogs:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
    .Projects
    .With(p => p.Path)
    .With(p => p.Guid)
    .With(p => p.Kind)      // DTE.Project.Kind
    .With(p => p.Type)      // VSHPROPID_ProjectType
    .With(p => p.TypeGuid)  // VSHPROPID_TypeGuid
    .With(p => p.Capabilities)
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in allProjects)
    {
        var projectGuid = project.Value.Guid;
        // Checking whether 'Capabilities' property has been retrieved.
        // Otherwise, it can throw for projects which do not support it. (Like SQL projects)
        bool capabilities = project.Value.PropertiesAvailableStatus.Capabilities;
    }
```

Or multiple properties can be requested in a single line:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
    .Projects
    .With(p => new { p.Path, p.Guid, p.Capabilities })
    .QueryAsync(cancellationToken);
```

Using WithRequired, only projects supporting specific properties will be returned:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projectWithFiles = workSpace
    .Projects
    .With(p => new { p.Path, p.Guid })
    .WithRequired(p => p.Files.Where(f => f.FileName == "information.txt"))
    .QueryAsync(cancellationToken);
```

When no properties are selected, the default set of properties will be returned. 

```csharp
IAsyncEnumerable<IQueryResultItem<IPropertySnapshot>> properties =
    myProject
    .PropertiesByName("RootNamespace", "AssemblyVersion")
    .QueryAsync(cancellationToken);
```

## Conditional filtering for Extensions

Extensions can get information from a smaller set of projects using conditional filtering.
Here is an example of finding all Net Core web projects. Not all projects support Capabilities, and this query will filter them out, instead of causing the query to fail.

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> webProjects =
    workSpace.Projects
    .Where(p => p.Capabilities.Contains("DotNetCoreWeb"))
    .With(p => new { p.Path, p.Guid })
    .QueryAsync(cancellationToken);

// Or use built-in filtering
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> webProjects =
        workSpace.ProjectsByCapabilities("DotNetCoreWeb | DotNetCoreRazor")
        .With(p => new { p.Path, p.Guid })
        .QueryAsync(cancellationToken);
```

## Using an Extension to recursively access a collection of children in one query

Extensions can access a collection of children recursively in one query.
Here is an example getting project information along with source files and properties:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects =
workSpace.ProjectsByCapabilities("CPS")
    .With(p => new { p.Path, p.IsProjectFileSearchable })
    .With(p => p.PropertiesByName("ApplicationIcon"))        // We only retrieve a single property, if it exists
    .With(p => p.Files                          // without any condition, we retrieve all files in the project, but we can filter them
        .Where(f => f.Extension == ".ico")
        .With(f => new { f.Path, f.IsHidden }))
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in projects)
    {
        IPropertySnapshot property = project.Value.Properties.FirstOrDefault();
        string? applicationIcon = (string?)property?.Value;

        foreach (var iconFile in project.Value.Files)
        {
            string filePath = iconFile.Path;
            bool isHidden = iconFile.IsHidden;
        }
    }
```

## Retrieve a child collection using the Get method

Extensions can only retrieve a child collection through using the 'Get' method in the query.
Here is an example getting a set of files included in a project as well as extra information about those files:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
workSpace.Projects
    .Where(p => p.Guid == knownGuid)
    .Get(p => p.Files
        .With(f => new { f.Path, f.IsHidden, f.IsSearchable }))
    .QueryAsync(cancellationToken);

    await foreach (var file in files)
    {
        string filePath = file.Value.Path;
    }
```

## Querying information from a previous item

Extensions may query further information from an item returned earlier in the session.
Here is an example of how to do so:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> allProjects = workSpace
        .Projects
        .With(p => p.Path)
        .With(p => p.Guid)
        .QueryAsync(cancellationToken);

await foreach (IQueryResultItem<IProjectSnapshot> project in allProjects)
{
    // Gets child collections
    IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
            project.Value.Files
            .With(f => new { f.Path, f.ItemType })
            .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IFileSnapshot> file in files)
    {
        string path = file.Value.Path;
        ...
    }
}
```

## Modifying a project

Here is an example of extensions making changes through the query API:

```csharp
IQueryResult<IProjectSnapshot> updatedProjects =
    workSpace.ProjectsByProjectGuid(knownGuid)
        .AsUpdatable()
        .CreateFile("AdditionalInformation.txt", textContent)
        .ExecuteAsync(cancellationToken);
```

And to make a change based on an item returned previously:

```csharp
IQueryResult<IProjectSnapshot> updatedProjects =
    myProject
        .AsUpdatable()
        .CreateFile("AdditionalInformation2.txt", textContent)
        .ExecuteAsync(cancellationToken);
```

## Getting information from the Solution File

Example:

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionSnapshot>> solutions =
workSpace.Solutions
    .With(s => new { s.Path, s.Guid, s.ActiveConfiguration, s.ActivePlatform })
    .QueryAsync(cancellationToken);
```

## Getting projects and project properties

Example:

```csharp
// We assume that we can find "RootNamespace" in the result.
// However it is not true from query API point of view.
// The query tries to retrieve items based on the condition, and if there is no such item, it will run successfully only without returning items.
IAsyncEnumerable<IQueryResultItem<IPropertySnapshot>> properties = 
    myProject.AsQueryable()  
    .Get(p => p.PropertiesByName("RootNamespace", "AssemblyVersion"))
    .QueryAsync(cancellationToken);
```

## Getting solution folders

Here is an example of getting all solution folders, regardless of whether they are nested or not:

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> solutionFolders =
workSpace.Solutions
    .Get(s => s.SolutionFolders)
    .With(folder => folder.Name)
    .With(folder => folder.IsNested)        // if we only want top level folders, we can filter on this property.
    .With(folder => folder.VisualPath)      // it is a relative (virtual) path to represent how the folder is nested.
    .QueryAsync(cancellationToken);
```

Here we are getting all nested solution folders, projects, files inside a solution folder (not recursively nested):

```csharp
IAsyncEnumerable<IQueryResultItem<ISolutionSnapshot>> solutionFoldWithExtraInformation = mySolutionFolder
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
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> recursivelyNestedFolders =
    await workSpace.Solutions
        .Get(s => s.SolutionFolders)
        .Where(f => f.VisualPath.StartsWith(visualPath) && f.VisualPath != visualPath)
        .With(f => f.Name)
        .QueryAsync(cancellationToken);
```

## Enumerating source files with additional information in a project

Here is an example enumerating all .xaml files in a project and its code generator:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
workSpace.ProjectsByProjectGuid(knownGuid)
    .Get(p => p.Files)
    .Where(file => file.Extension == ".xaml")
    .With(file => file.Path)
    .With(file => file.PropertiesByName("Generator"))
    .QueryAsync(cancellationToken);
```

Another example is to start with a project returned from previous query:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
    myProject.FilesEndingWith(".xaml")     // use built-in filter instead of 'Where' condition
        .With(file => file.Path)
        .With(file => file.PropertiesByName("Generator"))
        .QueryAsync(cancellationToken);
```

Or to get all content files:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> files =
    myProject.FilesWithItemTypes("Content")
        .With(file => file.Path)
        .QueryAsync(cancellationToken);
```

Or to enumerate all Xml Schema files in all projects:

```csharp
IAsyncEnumerable<IQueryResultItem<IFileSnapshot>> schemaFiles =
workSpace.Projects
    .Get(proj => proj.FilesEndingWith(".xsd"))
    .With(file => file.Path)
    .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IFileSnapshot> fileResult in schemaFiles)
    {
        DoSomething(fileResult.Value.Path);
    }
```

## Finding all projects owning a specific source file

Example:

```csharp
string myFilePath = [Location of the file I want];
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects =
    workSpace.Projects
        .WithRequired(proj => proj.FilesByPath(myFilePath))
        .With(proj => proj.Guid)
        .QueryAsync(cancellationToken);
```

Note: this doesn't include SolutionFolders, which must be queried separately:

```csharp
string myFilePath = [Location of the file I want];
IAsyncEnumerable<IQueryResultItem<ISolutionFolderSnapshot>> solutionFolders =
    workSpace.Solutions
        .Get(s => s.SolutionFolders)
        .WithRequired(folder => folder.FilesByPath(myFilePath))
        .With(folder => folder.Name)
        .With(folder => folder.Guid)
        .QueryAsync(cancellationToken);
```

## Accessing project configurations and their properties

Here is an example enumerating configurations of all known projects:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects =
    workSpace.Projects
        .With(p => new { p.Guid, p.Name })
        .With(p => p.Configurations
            .With(c => c.Name)
            .With(c => c.PropertiesByName("OutputPath"))
            .With(c => c.ConfigurationDimensions)) // ConfigurationDimension is essentially Name, Value pairs, both are default properties.
        .QueryAsync(cancellationToken);

    await foreach (IQueryResultItem<IProjectSnapshot> project in projects)
    {
        foreach (var configuration in project.Value.Configuration)
        {
            // ...
        }
    }
```

## Enumerating project to project references

Here is an example enumerating all projects referenced by the current project:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectReferenceSnapshot>> projectReferences =
    myProject.ProjectReferences
        .With(r => r.ProjectGuid)
        .With(r => r.ReferencedProjectId)
        .QueryAsync(cancellationToken);
```

Here is an example of finding all projects referencing the current project:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects =
    workSpace.Projects
        .With(p => p.Guid)
        .WithRequired(p => p.ProjectReferences
            .Where(r => r.ProjectGuid == knownGuid))
        .QueryAsync(cancellationToken);
```

## Enumerating package references of projects

Here is an example enumerating all package references by the current project:

```csharp
IAsyncEnumerable<IQueryResultItem<IProjectConfigurationSnapshot>> configurationsWithPackageReferences =
    myProject.ActiveConfigurations
        .With(c => c.Name)
        .With(c => c.PackageReferences
            .With(p => new { p.Name, p.Version }))
        .QueryAsync(cancellationToken);
```

This example finds all projects referencing a specific NuGet package:

```csharp
string packageName = "Newtonsoft.Json";
IAsyncEnumerable<IQueryResultItem<IProjectSnapshot>> projects =
    workSpace.Projects
        .With(p => p.Guid)
        .WithRequired(p => p.ActiveConfigurations
            .WithRequired(c => c.PackageReferences
                .Where(package => package.Name == packageName)))
    .QueryAsync(cancellationToken);
```

## Getting project output groups

Example:

```csharp

// From our list of active configurations, we need to get the first one in the list
IAsyncEnumerable<IQueryResultItem<IProjectConfigurationSnapshot>> configurations =
    myProject.ActiveConfigurations
        .QueryAsync(cancellationToken);

        IProjectConfigurationSnapshot myConfiguration = null;

        await foreach (IQueryResultItem<IProjectConfigurationSnapshot> config in configurations)
        {
            myConfiguration = config.Value;
            break;
        }

        // A multi-target project may have multiple active configurations
        IAsyncEnumerable<IQueryResultItem<IOutputGroupSnapshot>> outputGroups =
                    myConfiguration
                        .OutputGroupsByName("Built", "Symbols")
                        .With(g => g.Name)
                        .With(g => g.Outputs)
                        .QueryAsync(cancellationToken);
```