# Rule based activation constraints

One of the common concepts in Visual Studio Extensibility SDK is use of context based activation rules in code attributes. An example of these would `CommandVisibleWhen` attribute declaring when a command is made visible.

Our goal is to provide a common way to create such contexts, the current method is based on existing [Rule-based UI contexts](https://docs.microsoft.com/en-us/visualstudio/extensibility/how-to-use-rule-based-ui-context-for-visual-studio-extensions) with a different set of context terms.

## Constraint attribute arguments

Each constraint attribute will contain at least 3 required arguments that defines the expression:

* Expression string: A boolean expression using `and`, `or`, `not` operations and term names that are defined in later arguments. Each term must be a single word (without spaces) and expression can utilize parantheses for grouping and `&`, `|`, `!` operators for `and`, `or`, `not` operations.

* Term names: An array that contains the name of the terms used in the expression above.

* Term definitions: An array that defines the each term in the order terms are defined in the names array above.

## Example definition

In the example below, the code attributes defines when a command is in enabled state.

* The expression indicates that command is enabled when both `SolutionLoaded` and `IsValidFile` terms are true.

* `SolutionLoaded` term is defined as `SolutionState:Exists` which indicates, the term evaluates to `true` when a solution exists in the IDE.

* `IsValidFile` term is true when selected file in Solution Explorer is a jpeg or text file as defined by the file extension.

```csharp
[CommandEnabledWhen(
    "SolutionLoaded & IsValidFile",
    new string[] { 
        "SolutionLoaded", 
        "IsValidFile" },
    new string[] { 
        "SolutionState:Exists", 
        "ClientContext:Shell.ActiveSelectionFileName=(.jpg|.jpeg|.txt)$" })]
```

## Available terms

Following is the list of terms currently supported by expression engine.

| Term | Description
| -- | -- |
| SolutionHasProjectBuildProperty:\<property>=\<regex> | The term is true when solution has a loaded project with the specified build property and property value matches to regex filter provided. |
| SolutionHasProjectCapability:\<expression> | True whenever solution has a project with  capabilities matching the provided subexpression. An expression can be something like VB | CSharp. |
| SolutionHasProjectFlavor:\<guid> | True whenever a solution has project that is flavored (aggregated) and has a flavor matching the given project type GUID. |
| SolutionState:\<state> | True when solution state matches to provided value, see [solution states](#solution-states) for list of values. |
| ProjectAddedItem:\<pattern> | The term is true when a file matching the "pattern" is added to a project in the soluion that is opened. |
| ClientContext:\<key>=\<pattern> | True when the provided client context key matches to regular expression. See [client contexts](#client-contexts) for more details. |

## Solution states

| State | Description |
| -- | -- |
| NoSolution | No solution loaded. |
| Exists | A solution is opened but may be in loaded or loading state. |
| FullyLoaded | A solution is opened and fully loaded. |
| Empty | Solution contains no projects but may contain solution items. |
| SingleProject | Solution contains a single project. |
| MultipleProject | Solution contains multiple projects. |
| Building | Solution is building. |

## Client contexts
As all extensions in the new SDK runs out of process, we introduce the concept of client context for various extension parts to represent the state of the IDE as when the user took action. This context is represnted by `IClientContext` instance in the SDK and is passed in to various operations such as command execution handlers.

Similarly, activation rules can also use the same client context values to create rules to determine command state decleratively.

Currently, the client context is limited to a small set of values in IDE state:

| Context key | Definition |
| -- | -- |
| Shell.ActiveSelectionUri | Full URI for the selected item in solution explorer. |
| Shell.ActiveSelectionPath | Full path for the selected item in solution explorer. |
| Shell.ActiveSelectionFileName | File name of the selected item in solution explorer. |
| Shell.ActiveEditorContentType | Content type of the active editor view. |
| Shell.ActiveEditorFileName | File name for the document that belongs to active editor view. |
