# Project Query API Documentation
Conceptual documentation about what the project system is, usages, and its various terms.

## What is a project system?
A project system sits between a project file on disk (for example, .csproj and .vbproj) and various Visual Studio features including, but not limited to, Solution Explorer, designers, the debugger, language services, build and deployment. Almost all interaction that occurs with files contained in a project file, happens through the project system.

Project systems are a part of VS components to help users work with and maintain projects, run builds to produce results, and to test output.

There are three reasons to extend a project system in Visual Studio:
1. Support a new project file format.
1. Integrate existing file format with a new language service.
1. Customize behavior of an existing project system.
Find further information on project systems [here](https://github.com/microsoft/VSProjectSystem).

## Project Query Specific Nouns
|Term|Description
|---|---
|WorkSpace| The top level workspace of the API to provide the entry point.
|PropertiesAvailableStatus| The entry point to check whether a property value is available in the result.
|QueryableSpace.Projects| All projects in the workspace.
|QueryableSpace.Solutions| All solutions in the workspace.
|Solution| Represents a solution in Visual Studio.
|Project| Represents most projects in Visual Studio, but solution folders are represented differently in the new API.
|SolutionFolder| Represents a solution folder, which is a virtual folder to group projects and files inside a Visual Studio solution.
|File| Represents a file contained by a project or a solution folder.
|ExternalFile| Represents external files referenced by a project, which is only supported by VC projects.
|Property| Represents dynamic set (weak name/type) of properties of a project, a configuration, or a file.
|ProjectReference| Represents project to project references, including shared project references.
|PackageReference| Represents a package reference in a project configuration, typically a NuGet package reference.
|AssemblyReference| Represents a referenced assembly in a project configuration.
|ConfigurationDimensionDefinition| Represents values to declare project configurations.
|ProjectConfiguration| Represents a project configuration.
|ConfigurationDimension| Represents values of each dimension of a single project configuration.
|OutputGroup| Represents one collection of project output.
|Output| Represents one item inside a single output group.
|LaunchProfile| Represents launch profiles defined in a project.
|PropertyPage| Represents property pages shown for the project.

## Project Query Specific Verbs
|Term|Description
|---|---
|With| Requests value of a property/collection to be returned from the query.
|WithRequired| Requests value of a property/collection must be returned from the query.
|Where| Requests value of a property/collection to be returned from the query. 
|Get| Gets child items instead in the query result.
|ExecuteQueryAsync| Executes a query and retrieves the result. 
|StartQueryAsync| Executes a query and retrieves the result as IAsyncEnumerable.
|AsQueryable| Starts a query from a previous retrieved object.
|QueryFrom| Starts a query from a collection of previous retrieved objects.
|AsUpdatable| Starts to update object from a query result.
|ExecuteAsync| Executes an update query.

## MEF: Managed Extensibility Framework
MEF introduced to CPS to provide a way for CPS partners to inject themselves.