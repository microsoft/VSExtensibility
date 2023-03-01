# Comment Remover

This is a conversion of Mads Kristensen's [Comment Remover](https://github.com/madskristensen/CommentRemover) extension to in-proc VisualStudio.Extensibility. This sample shows how to consume [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services through .NET dependency injection and use VisualStudio.Extensibility APIs for commands, prompts and progress report.

## Converting the Comment Remover to VisualStudio.Extensibility

Mads Kristensen's [Comment Remover](https://github.com/madskristensen/CommentRemover) is a [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) extension that creates a few commands in the Visual Studio menu to remove code comments from the current document.

The extension leverages multiple Visual Studio functionalities that are currenly not available in the VisualStudio.Extensibility model, so it is a good application for an in-proc VisualStudio.Extensibility extension which allows to also consume Visual Studio SDK APIs.

### Creating the extension structure

I started creating an empty VisualStudio.Extensibility in-proc extension project as described in the [Creating your first in-process VisualStudio.Extensibility extension](../../../docs/new-extensibility-model/getting-started/in-proc-extensions.md) guide.

I did a quick fix to the `CommentRemoverContainer` project: added the correct information in the [.vsixmanifest](CommentRemoverContainer/source.extension.vsixmanifest) file and added the license file and two image resources that are referenced in the manifest.

As described in the getting started guide, I don't need to make any other change to the container project: all the remaining work will be done in the `CommentRemover` project. In future versions of VisualStudio.Extensibility, the packaging of extensions will be improved and it is likely that the `CommentRemoverContainer` project won't be necessary anymore. Minimizing the amount of customization to the container will help updating the extension to newer versions of VisualStudio.Extensibility.

### Creating the new commands

Commands are the main VisualStudio.Extensibility feature that I will leverage in this conversion.

VisualStudio.Extensibility commands are quite different, so we can either start from scratch with new empty commands and move the code or we can start with the old commands classes and convert them. Whatever path we choose, we will end up with the same 6 command classes (for example, [RemoveAllComments.cs](CommentRemover/RemoveAllComments.cs)). I also decided to keep the original structure of using a common [base command class](CommentRemover/BaseCommand.cs) to provide some shared implementation.

The two most glaring differences between the old and new commands are:

- VisualStudio.Extensibility command execution is `async`,
- VisualStudio.Extensibility commands are defined in one place, we can delete the `.vsct` file.

We also don't need to initialize the commands anymore, so I don't need to port the code from the `AsyncPackage` class.

Finally, I will set up shortcuts, icons and a rule about when the commands are enabled. All of this is achieved through the `CommandConfiguration` property.

```CSharp
[VisualStudioContribution]
internal class RemoveAllComments : CommentRemoverCommand
{
    private const string CommandDescription = "%RemoveAllComments.DisplayName%";

    public RemoveAllComments(
        VisualStudioExtensibility extensibility,
        TraceSource traceSource,
        AsyncServiceProviderInjection<DTE, DTE2> dte,
        MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
        MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
        AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
        : base(extensibility, traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager)
    {
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new(CommandDescription)
    {
        Icon = new(ImageMoniker.KnownValues.Uncomment, IconSettings.IconAndText),
        EnabledWhen = CommandEnabledWhen,
        Shortcuts = new[] { new CommandShortcutConfiguration(ModifierKey.Control, Key.K, ModifierKey.Control, Key.Q) },
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
```

### Command placing

This extension contributes six new commands to Visual Studio and I want them to be placed together in a sub-menu of the *Extensions* menu. This can be achieved by creating a static property of type `MenuConfiguration` and marking it with the `VisualStudioContribution` attribute. The property can be placed in any class, for organization purposes we recommend placing all manus and toolbar configurations in a single `ExtensionCommandConfiguration` static class.

```CSharp
internal static class ExtensionCommandConfiguration
{
    public static MenuConfiguration CommentRemoverMenu => new("%CommentRemoverMenu.DisplayName%")
    {
        Priority = 1,
        Placements = new[]
        {
            CommandPlacement.KnownPlacements.ExtensionsMenu,
        },
        Children = new[]
        {
            MenuChild.Command<RemoveAllComments>(),
            MenuChild.Command<RemoveXmlDocComments>(),
            MenuChild.Command<RemoveAllExceptXmlDocComments>(),
            MenuChild.Separator,
            MenuChild.Command<RemoveTasks>(),
            MenuChild.Command<RemoveAllExceptTaskComments>(),
            MenuChild.Separator,
            MenuChild.Command<RemoveRegions>(),
        },
    };
}
```

### Preparing for localization

You may have noticed that some strings enclosed by `%` characters in the code above: these are identifiers of localizable strings from the `.vsextension/string-resources.json` file:

```json
{
    "CommentRemoverMenu.DisplayName": "Comments",
    "RemoveAllComments.DisplayName": "Remove All",
    "RemoveAllExceptTaskComments.DisplayName": "Remove All Except Tasks",
    "RemoveAllExceptXmlDocComments.DisplayName": "Remove All Except Xml Docs",
    "RemoveRegions.DisplayName": "Remove Regions",
    "RemoveTasks.DisplayName": "Remove Tasks",
    "RemoveXmlDocComments.DisplayName": "Remove Xml Docs"
}
```

If we want the extension to be localized for different languages, we can later add `string-resources.json` files for those languages as described [here](../../../docs/new-extensibility-model/extension-guides/command/command.md#string-resourcesjson);

### Dependency injection of Visual Studio SDK services

The Comment Remover extension is leveraging four of Visual Studio services:

- `DTE2`, available as `DTE` through  [AsyncServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.shell.asyncserviceprovider);
- `IVsTextManager`, available as `SVsTextManager` through `AsyncServiceProvider`;
- `IBufferTagAggregatorFactoryService`, available through [MEF](https://docs.microsoft.com/en-us/visualstudio/extensibility/managed-extensibility-framework-in-the-editor);
- `IVsEditorAdaptersFactoryService`, available through `MEF`.

In a VisualStudio.Extensibility command, we can consume such services using .NET dependency injection by simply adding them to the command's constructor:

```CSharp
public RemoveAllComments(
    VisualStudioExtensibility extensibility,
    TraceSource traceSource,
    AsyncServiceProviderInjection<DTE, DTE2> dte,
    MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService,
    MefInjection<IVsEditorAdaptersFactoryService> editorAdaptersFactoryService,
    AsyncServiceProviderInjection<SVsTextManager, IVsTextManager> textManager)
    : base(extensibility, traceSource, dte, bufferTagAggregatorFactoryService, editorAdaptersFactoryService, textManager)
{
}
```

The `AsyncServiceProviderInjection` and `MefInjection` classes take care of making retrieval of these services async-friendly.

It's important to remember that, while VisualStudio.Extensibility APIs are fully async, interacting with [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services is sometimes restricted to the UI thread. We can switch to the UI thread as usual with

```CSharp
await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
```

### Adding custom command icons

I also decided to add a custom icon for the [RemoveRegions](CommentRemover/RemoveRegions.cs) command. I was able to do it by simply adding `DeleteRegions.16.16.png` and `DeleteRegions.xaml` to the `Images` folder and referencing the custom image with the `"DeleteRegions"` string in the `CommandConfiguration` property:

```CSharp
public override CommandConfiguration CommandConfiguration => new(CommandDescription)
{
    Icon = new(ImageMoniker.Custom("DeleteRegions"), IconSettings.IconAndText),
    EnabledWhen = CommandEnabledWhen,
};
```

The VisualStudio.Extensibility build tools will take care of packaging the content of the `Images` folder with the extension. Visual Studio will choose to load either the `DeleteRegions.16.16.png` or the `DeleteRegions.xaml` to achieve the best visual results.

### Confirmation prompts and progress reporting

VisualStudio.Extensibility features are designed to be used with minimal boilerplate code. With a couple of lines of code I can add a confirmation promtp and progress report to the extension:

```CSharp
public override async Task ExecuteCommandAsync(IClientContext context, ancellationToken cancellationToken)
{
    if (!await context.ShowPromptAsync("All regions will be removed from the current document. Are you sure?", PromptOptions.OKCancel, cancellationToken))
        return;
    using var reporter = await Extensibility.Shell().StartProgressReportingAsync("Removing comments", options: new(isWorkCancellable: false), cancellationToken);
```

Calling `ShowPromptAsync` causes a modal popup to appear, returning `true` or `false` depending whether they cliked Ok or Cancel. The prompt can be configured with different messages and button configurations. It's important to remember that prompts can always be dismissed by pressing the "X" button in the popup dialog title bar: the docs for `PromptOptions.OKCancel` let us know that `ShowPromptAsync` returns `false` in case of dismissal.

Calling `StartProgressReportingAsync` instruct Visual Studio to notify the user that a potentially long-running work is running in the background. `StartProgressReportingAsync` creates a disposable object that tracks the background work and automatically removes the notification from the UI when the object is disposed.
