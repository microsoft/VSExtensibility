---
title: Packages Reference
description: A reference for NuGet Packages
date: 2021-8-16
---

# Visual Studio Extensibility Nuget Packages
The new extensibilty model for Visual Studio depends on a set of new nuget packages to provide APIs, build tooling, code generation and analyzers. 

## Microsoft.VisualStudio.Extensibility
Link: <TBD>

This package contains the SDK APIs and utility libraries to help develop extensions using the out-of-process extensibility model. Every extension should include a reference to this package as a starting point.

## Microsoft.VisualStudio.Extensibility.Build
Link: <TBD>

This package contains the build tooling, code generators that is necessary for extension metadata to be generated during build. Without this package, a compiled extension may not work correctly as it will not contain the necessary metadata files.

## Microsoft.VisualStudio.Extensibility.Editor
This package contains the editor related SDK APIs and utilities and is included as a dependency from `Microsoft.VisualStudio.Extensibility`. 

In future previews, we may have similar nuget packages that are not included as a required dependency but can be added as needed to provide APIs for certain feature areas such as debugger, source control.