# Visual Studio extensions to the Language Server Protocol

This document describes the Visual Studio specific extensions to the [Language Server Protocol](https://microsoft.github.io/language-server-protocol/specifications/specification-current/). These extensions can be used by servers to provide additional functionalities when communicating with a Visual Studio instance.

These extensions are composed of:
1. Classes which extend base classes from the LSP specification allowing to provide additional information to Visual Studio. For example [`VSDiagnostic`](#vsdiagnostic) extends [`Diagnostic`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/#diagnostic) adding support for tooltips, sorting, etc.
1. Additional methods like [GetProjectContexts](#getprojectcontexts). These are listed in [`VSMethods`](#vsmethods).
1. Additional capabilities that a language server can provide to the Visual Studio client. These are defined in [`VSServerCapabilities`](#vsservercapabilities) and can be communicated to the client in the [`InitializeResult.capabilities`](https://microsoft.github.io/language-server-protocol/specifications/specification-3-17/#initializeResult) field of the [`initialize`](https://microsoft.github.io/language-server-protocol/specifications/specification-3-17/#initialize) request.
1. Additional values for enumerations described in the LSP protocol. For example [`VSDiagnosticTag`](#vsdiagnostictag) extends [`DiagnosticTag`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/#diagnosticTag).

A .NET implementation of these extensions can be found on [NuGet](https://www.nuget.org/packages/Microsoft.VisualStudio.LanguageServer.Protocol.Extensions).

When using this package in a language server, configure the `JsonSerializer` using `VSExtensionUtilities.AddVSExtensionConverters` in order to allow extensions classes to be correctly deserialized. For example, this allows the `JsonSerializer` to correctly deserialize the [`CodeAction.Diagnostics`](https://microsoft.github.io/language-server-protocol/specifications/specification-3-17/#codeAction) entries of a [`codeAction/resolve`](https://microsoft.github.io/language-server-protocol/specifications/specification-3-17/#codeAction_resolve) request into [`VSDiagnostic`](#vsdiagnostic) objects even if [`CodeAction.Diagnostics`](https://microsoft.github.io/language-server-protocol/specifications/specification-3-17/#codeAction) is defined as an array of [`Diagnostic`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/#diagnostic) objects.

# New methods

## GetProjectContexts

_GetProjectContexts_ requests are sent from the client to the server to retrieve a list of the project contexts associated with a text document. An example of project contexts are [multiple target frameworks](https://docs.microsoft.com/en-us/dotnet/standard/frameworks#how-to-specify-a-target-framework) in SDK style .NET projects.

The labels of all project contexts are presented to the user in the navigation bar at the top of the document. When the user changes the project context in the navigation bar, the active project context is changed.

The client includes the active project context in requests to the server by filling in the [`VSTextDocumentIdentifier._vs_projectContext`](#vstextdocumentidentifier) property.

_Server Capability_

- property path (optional): [`_vs_projectContextProvider`](#vsservercapabilities)
- property type: `boolean`

_Request_

- method: `textDocument/_vs_getProjectContexts`
- params: [`VSGetProjectContextsParams`](#vsgetprojectcontextsparams)

_Response_

- result: [`VSProjectContextList`](#vsprojectcontextlist)

# Extensions specification

## VSDiagnostic

[`VSDiagnostic`](#vsdiagnostic) extends [`Diagnostic`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) providing additional properties used by Visual Studio. 
```typescript
export interface VSDiagnostic extends Diagnostic {

    /**
     * Gets or sets the project and context (e.g. Win32, MacOS, etc.) in which the diagnostic was generated.
    **/
    _vs_projects? : VSDiagnosticProjectInformation[],

    /**
     * Gets or sets an expanded description of the diagnostic.
    **/
    _vs_expandedMessage? : string,

    /**
     * Gets or sets a message shown when the user hovers over an error. If null, then Diagnostic.message
     * is used (use VSDiagnosticTags.SuppressEditorToolTip to prevent a tool tip from being shown).
    **/
    _vs_toolTip? : string,

    /**
     * Gets or sets a non-human-readable identier allowing consolidation of multiple equivalent diagnostics
     * (e.g. the same syntax error from builds targeting different platforms).
    **/
    _vs_identifier? : string,

    /**
     * Gets or sets a string describing the diagnostic types (e.g. Security, Performance, Style, etc.).
    **/
    _vs_diagnosticType? : string,

    /**
     * Gets or sets a rank associated with this diagnostic, used for the default sort.
     * VSDiagnosticRank.Default will be used if no rank is specified.
    **/
    _vs_diagnosticRank? : VSDiagnosticRank,

    /**
     * Gets or sets an ID used to associate this diagnostic with a corresponding line in the output window.
    **/
    _vs_outputId? : integer,
}
```

## VSDiagnosticProjectInformation

[`VSDiagnosticProjectInformation`](#vsdiagnosticprojectinformation) represents the project and context in which the [`VSDiagnostic`](#vsdiagnostic) is generated. 
```typescript
export interface VSDiagnosticProjectInformation {

    /**
     * Gets or sets a human-readable identifier for the project in which the diagnostic was generated.
    **/
    _vs_projectName? : string,

    /**
     * Gets or sets a human-readable identifier for the build context (e.g. Win32 or MacOS)
     * in which the diagnostic was generated.
    **/
    _vs_context? : string,

    /**
     * Gets or sets the unique identifier for the project in which the diagnostic was generated.
    **/
    _vs_projectIdentifier? : string,
}
```

## VSDiagnosticRank

[`VSDiagnosticRank`](#vsdiagnosticrank) represents the rank of a [`VSDiagnostic`](#vsdiagnostic) object. 
```typescript
export enum VSDiagnosticRank {

    /**
     * Highest priority.
    **/
    Highest = 100,

    /**
     * High priority.
    **/
    High = 200,

    /**
     * Default priority.
    **/
    Default = 300,

    /**
     * Low priority.
    **/
    Low = 400,

    /**
     * Lowest priority.
    **/
    Lowest = 500,
}
```

## VSDiagnosticTags

 Additional [`DiagnosticTag`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) values that are specific to Visual Studio. 
```typescript
export namespace VSDiagnosticTags {

    /**
     * A Diagnostic entry generated by the build.
    **/
    export const BuildError : DiagnosticTag = -1;

    /**
     * A Diagnostic entry generated by Intellisense.
    **/
    export const IntellisenseError : DiagnosticTag = -2;

    /**
     * A Diagnostic entry that could be generated from both builds
     * and Intellisense.
     * 
     * Diagnostic entries tagged with VSDiagnosticTags.PotentialDuplicate will be hidden
     * in the error list if the error list is displaying build and intellisense
     * errors.
    **/
    export const PotentialDuplicate : DiagnosticTag = -3;

    /**
     * A Diagnostic entry is never displayed in the error list.
    **/
    export const HiddenInErrorList : DiagnosticTag = -4;

    /**
     * The Diagnostic entry is always displayed in the error list.
    **/
    export const VisibleInErrorList : DiagnosticTag = -5;

    /**
     * The Diagnostic entry is never displayed in the editor.
    **/
    export const HiddenInEditor : DiagnosticTag = -6;

    /**
     * No tooltip is shown for the Diagnostic entry in the editor.
    **/
    export const SuppressEditorToolTip : DiagnosticTag = -7;

    /**
     * The Diagnostic entry is represented in the Editor as an Edit
     * and Continue error.
    **/
    export const EditAndContinueError : DiagnosticTag = -8;
}
```

## VSGetProjectContextsParams

[`VSGetProjectContextsParams`](#vsgetprojectcontextsparams) represents the parameter that is sent with the 'textDocument/_vs_getProjectContexts' request. 
```typescript
export interface VSGetProjectContextsParams {

    /**
     * Gets or sets the document for which project contexts are queried.
    **/
    _vs_textDocument : TextDocumentItem,
}
```

## VSImageId

[`VSImageId`](#vsimageid) represents the unique identifier for a Visual Studio image asset. The identified is composed by a [`VSImageId._vs_guid`](#vsimageid) and an integer. A list of valid image ids can be retrieved from the [KnownMonikers class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.imaging.knownmonikers) from the Visual Studio SDK. 
```typescript
export interface VSImageId {

    /**
     * Gets or sets the VSImageId._vs_guid component of the unique identifier.
    **/
    _vs_guid : Guid,

    /**
     * Gets or sets the integer component of the unique identifier.
    **/
    _vs_id : integer,
}
```

## VSLocation

[`VSLocation`](#vslocation) extends [`Location`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) providing additional properties used by Visual Studio. 
```typescript
export interface VSLocation extends Location {

    /**
     * Gets or sets the project name to be displayed to user.
    **/
    _vs_projectName? : string,

    /**
     * Gets or sets the text value for the display path.
     * In case the actual path on disk would be confusing for users, this should be a friendly display name.
     * This doesn't have to correspond to a real file path, but must be parsable by the System.IO.Path.GetFileName(System.String) method.
    **/
    _vs_displayPath? : string,
}
```

## VSMethods

[`VSMethods`](#vsmethods) contains the string values for all Language Server Protocol Visual Studio specific methods. 
```typescript
export namespace VSMethods {

    /**
     * Method name for 'textDocument/_vs_getProjectContexts'.
     * The 'textDocument/_vs_getProjectContexts' request is sent from the client to the server to query
     * the list of project context associated with a document.
     * This method has a parameter of type VSGetProjectContextsParams and a return value of type
     * VSProjectContextList.
     * In order to enable the client to send the 'textDocument/_vs_getProjectContexts' requests, the server must
     * set the VSServerCapabilities._vs_projectContextProvider property.
    **/
    export const GetProjectContextsName : string = 'textDocument/_vs_getProjectContexts';
}
```

## VSProjectContext

[`VSProjectContext`](#vsprojectcontext) represents a project context. 
```typescript
export interface VSProjectContext {

    /**
     * Gets or sets the label for the project context.
    **/
    _vs_label : string,

    /**
     * Gets or sets the unique identifier of the project context.
    **/
    _vs_id : string,

    /**
     * Gets or sets the context kind of the project context which is used to determine its associated icon.
    **/
    _vs_kind : VSProjectKind,
}
```

## VSProjectContextList

[`VSProjectContextList`](#vsprojectcontextlist) represents the response to the 'textDocument/_vs_getProjectContexts' request. 
```typescript
export interface VSProjectContextList {

    /**
     * Gets or sets the document contexts associated with a text document.
    **/
    _vs_projectContexts : VSProjectContext[],

    /**
     * Gets or sets the index of the default entry of the VSProjectContext array.
    **/
    _vs_defaultIndex : integer,
}
```

## VSProjectKind

[`VSProjectKind`](#vsprojectkind) represents the various kinds of contexts. 
```typescript
export enum VSProjectKind {

    /**
     * C++ project.
    **/
    CPlusPlus = 1,

    /**
     * C# project.
    **/
    CSharp = 2,

    /**
     * Visual Basic project.
    **/
    VisualBasic = 3,
}
```

## VSServerCapabilities

[`VSServerCapabilities`](#vsservercapabilities) extends [`ServerCapabilities`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) allowing to provide additional capabilities supported by Visual Studio. 
```typescript
export interface VSServerCapabilities extends ServerCapabilities {

    /**
     * Gets or sets a value indicating whether the server supports the
     * 'textDocument/_vs_getProjectContexts' request.
    **/
    _vs_projectContextProvider? : boolean,
}
```

## VSSymbolInformation

[`VSSymbolInformation`](#vssymbolinformation) extends [`SymbolInformation`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) providing additional properties used by Visual Studio. 
```typescript
export interface VSSymbolInformation extends SymbolInformation {

    /**
     * Gets or sets the icon associated with the symbol. If specified, this icon is used instead of SymbolKind.
    **/
    _vs_icon? : VSImageId,

    /**
     * Gets or sets the description of the symbol.
    **/
    _vs_description? : string,

    /**
     * Gets or sets the hint text for the symbol.
    **/
    _vs_hintText? : string,
}
```

## VSTextDocumentIdentifier

[`VSTextDocumentIdentifier`](#vstextdocumentidentifier) extends [`TextDocumentIdentifier`](https://microsoft.github.io/language-server-protocol/specifications/specification-current/) providing additional properties used by Visual Studio.
```typescript
export interface VSTextDocumentIdentifier extends TextDocumentIdentifier {

    /**
     * Gets or sets the project context of the text document.
    **/
    _vs_projectContext? : VSProjectContext,
}
```