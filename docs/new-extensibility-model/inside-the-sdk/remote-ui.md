---
title: Remote UI
description: A walkthrough exploring the Remote UI features
date: 2022-7-18
---

# Why Remote UI
One of the main goals of the VisualSudio.Extensibility model is to allow extensions to run outside of the Visual Studio process. This introduces an obstacle for adding UI support to extensions since most UI frameworks are in-process.

*Remote UI* is a set of classes allowing to define WPF controls in an *out-of-proc* extension and showing them as part of the Visual Studio UI.

*Remote UI* leans heavily towards the *Model-View-ViewModel* design pattern relying on XAML and data binding, commands (instead of events), and triggers (instead of interacting with the [logical tree](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/advanced/trees-in-wpf) from *code-behind*).

While *Remote UI* was developed to support *out-of-proc* extensions, VisualStudio.Extensibility APIs that rely on *Remote UI*, like `ToolWindow`, will leverage *Remote UI* for *in-proc* extensions as well.

The main differences between *Remote UI* and normal WPF development are:
- most *Remote UI* operations, including binding to the data context and command execution, are asynchronous.
- *Remote UI* doesn't allow referencing your own custom controls.
- A *Remote user control* is fully defined in a single XAML file which references a single (but potentially complex and nested) data context object.
- *Remote UI* doesn't support code behind or event handlers (workarounds are descrived in the [advanced Remote UI concepts](advanced-remote-ui.md) document).
- A *Remote user control* is actually instantiated in the Visual Studio process, not the process hosting the extension: the XAML cannot reference types and assemblies from the extension but can reference types and assemblies from the Visual Studio process. 

# Creating a Remote UI Hello World extension
Let's start creating the most basic Remote UI extension.

Follow the instructions in [Creating your first out-of-process Visual Studio extension](../getting-started/create-your-first-extension.md).

You should now have a working extension with a single command, the next step is to add a `ToolWindow` and a `RemoteUserControl`. The `RemoteUserControl` is the *Remote UI* equivalent of a WPF user control.

You will end up with 4 files: 
1. a `.cs` file for the command which opens the tool window,
1. a `.cs` file for the `ToolWindow` which provides the `RemoteUserControl` to Visual Studio,
1. a `.cs` file for the `RemoteUserControl` which references its XAML definition,
1. a `.xaml` file for the `RemoteUserControl`.

Later on we will add a data context for the `RemoteUserControl` which represents the *ViewModel* in the MVVM pattern.

## Updating the command

Update the code of the command to show the tool window using the `ShowToolWindowAsync`:
```CSharp
public override Task ExecuteCommandAsync(IClientContext context, CancellationToken ancellationToken)
{
    return Extensibility.Shell().ShowToolWindowAsync(nameof(MyToolWindow), activate: true, cancellationToken);
}
```

You can also consider changing the `Command` attribute for a more appropriate display message and placement:
```CSharp
[Command(nameof(ShowMyToolWindowCommand), "Show Hello World Tool Window", placement: KnownCommandPlacement.ViewOtherWindowsMenu)]
internal class ShowMyToolWindowCommand : Command
{
```

## Creating the tool window

Create a new `MyToolWindow.cs` file and define a `MyToolWindow` class extending `ToolWindow`.

The `GetContentAsync` method is supposed to return an `IRemoteUserControl` which we will define in the next step. Since the remote user control is disposable, let's also take care of disposing it by overriding the `Dispose(bool)` method.

```CSharp
namespace MyToolWindowExtension;

using Microsoft.VisualStudio.Extensibility.ToolWindows;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

[ToolWindow(nameof(MyToolWindow))]
internal class MyToolWindow : ToolWindow
{
    private readonly MyToolWindowContent content = new();

    public MyToolWindow(string identifier)
        : base(identifier)
    {
        Title = "My Tool Window";
    }

    public override async Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
        => content;

    public override Task InitializeAsync(CancellationToken cancellationToken)
        => Task.CompletedTask;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            content.Dispose();

        base.Dispose(disposing);
    }
}
```

## Creating the remote user control

This step is performed across three files.

### Remote user control class

The remote user control class, named `MyToolWindowContent`, is straightforward:

```CSharp
namespace MyToolWindowExtension;

using Microsoft.VisualStudio.Extensibility.UI;

internal class MyToolWindowContent : RemoteUserControl
{
    public MyToolWindowContent()
        : base(dataContext: null)
    {
    }
}
```

We don't need a data context yet, so we can leave it to `null` for now.

A class extending `RemoteUserControl`, will automatically use the XAML embedded resource with the same name. If we wanted to change this behavior, we can override the `GetXamlAsync` method.

### XAML definition

Next, let's create a file named `MyToolWindowContent.xaml`:
```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Label>Hello World</Label>
</DataTemplate>
```

As described above, this file must have the same name as the `RemoteUserControl` class.

The XAML definition of the remote user control is normal WPF xaml describing a `DataTemplate`. This XAML will be sent to Visual Studio and used to fill the tool window content.

### Setting the XAML as embedded resource

Finally, let's open the `.csproj` file and make sure that the XAML file is treated as an embedded resource:
```xml
<ItemGroup>
  <EmbeddedResource Include="MyToolWindowContent.xaml" />
</ItemGroup>
```

You can also change the target framework for your extension from `net6.0` to `net6.0-windows` in order to get better autocompletion in the XAML file.

## Testing the extension

You should now be able to press F5 and debug the extension.

![Menu and tool window](hello-world-tool-window.png "Menu and tool window")

# Adding support for themes

It is a good idea to write our UI keeping in mind that Visual Studio can be themed resulting in very different colors being used.

Let's update the XAML to use the [styles](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.shell.vsresourcekeys) and [colors](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.platformui.environmentcolors) used across Visual Studio:
```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vsshell="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
    <Grid>
        <Grid.Resources>
            <Style TargetType="Label" BasedOn="{StaticResource {x:Static vsshell:VsResourceKeys.ThemedDialogLabelStyleKey}}" />
        </Grid.Resources>
        <Label>Hello World</Label>
    </Grid>
</DataTemplate>
```

The label is now themed as the rest of the Visual Studio UI:
![Themed tool window](remote-ui-themed.png "Themed tool window")

The `xmlns`' above reference the [Microsoft.VisualStudio.Shell.15.0](https://www.nuget.org/packages/Microsoft.VisualStudio.Shell.15.0) assembly which is not one of the extension depedencies. This is fine because this XAML will be used by the Visual Studio process, which has a dependencies on *Shell.15*, not by the extension itself.

In order to get a better XAML editing experience, you can **temporarily** add a `PackageReference` to `Microsoft.VisualStudio.Shell.15.0` to the extension project. **Don't forget to remove it** later since an *out-of-proc* VisualStudio.Extensibility extension shouldn't reference this package!

# Adding a data context

Let's now add a data context class for the remote user control:
```CSharp
using System.Runtime.Serialization;

namespace MyToolWindowExtension;

[DataContract]
internal class MyToolWindowData
{
    [DataMember]
    public string? LabelText { get; init; }
}
```

and update `MyToolWindowContent.cs` and `MyToolWindowContent.xaml` to use it:
```CSharp
internal class MyToolWindowContent : RemoteUserControl
{
    public MyToolWindowContent()
        : base(dataContext: new MyToolWindowData { LabelText = "Hello Binding!"})
    {
    }
```
```xml
<Label Content="{Binding LabelText}" />
```

The content of the label is now set through databinding:
![Tool window with data binding](remote-ui-data-binding.png "Tool window with data binding")

The data context type above is marked with `DataContract` and `DataMember` attributes. This is because the `MyToolWindowData` instance exists in the extension host process while the WPF control created from `MyToolWindowContent.xaml` exists in the Visual Studio process. To make data binding work, the Remote UI infrastructure generates a proxy of the `MyToolWindowData` object in the Visual Studio process. The `DataContract` and `DataMember` attributes indicate which types and properties are relevant for data binding and should be replicated in the proxy.

The data context of the remote user control is passed as a constructor parameter of the `RemoteUserControl` class: the `RemoteUserControl.DataContext` property is read-only. This doesn't imply that the whole data context is immutable, but the root data context object of a remote user control cannot be replaced. In the next section we will make `MyToolWindowData` mutable and observable.

# Lifecycle of a Remote User Control

You can override the `ControlLoadedAsync` method to be notified when the control is first loaded in a WPF container. If in your implementation, the state of the data context may change independently from UI events, the `ControlLoadedAsync` method is the right place to initialize the content of the data context and start applying changes to it.

You can also override the `Dispose` method to be notified when the control is destroyed and won't be used anymore.

```CSharp
internal class MyToolWindowContent : RemoteUserControl
{
    public MyToolWindowContent()
        : base(dataContext: new MyToolWindowData())
    {
    }

    public override async Task ControlLoadedAsync(CancellationToken cancellationToken)
    {
        await base.ControlLoadedAsync(cancellationToken);
        // Your code here
    }

    protected override void Dispose(bool disposing)
    {
        // Your code here
        base.Dispose(disposing);
    }
}
```

# Commands, observability and two-way data binding

Next, let's make the data context observable and add a button to the toolbox.

The data context can be made observable by implementing [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged). Alternatively, Remote UI provides a convenient abstract class, `NotifyPropertyChangedObject`, that we can extend to reduce boilerplate code.

A data context usually have a mix of readonly properties and observable properties. The data context can be a complex graph of objects as long as they are marked with the `DataContract` and `DataMember` attributes and implement `INotifyPropertyChanged` as necessary. It is also possible to have [observable collections](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1).

We also need to add a command to the data context. In Remote UI, commands implement `IAsyncCommand` but it is often easier to simply create an instance of the `AsyncCommand` class.

`IAsyncCommand` differs from [ICommand](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.icommand) in two ways:
1. The `Execute` method is replaced with `ExecuteAsync` because everything in Remote UI is async!
1. The `CanExecute(object)` method is replaced by a `CanExecute` property. The `AsyncCommand` class takes care of making `CanExecute` observable.

It's important to note that Remote UI doesn't support event handlers, so all notifications from the UI to the extension must be implemented through databinding and commands.

This is the resulting code for `MyToolWindowData`.
```CSharp
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
    public MyToolWindowData()
    {
        HelloCommand = new((parameter, cancellationToken) =>
        {
            Text = $"Hello {Name}!";
            return Task.CompletedTask;
        });
    }

    private string _name = string.Empty;
    [DataMember]
    public string Name
    {
        get => _name;
        set => SetProperty(ref this._name, value);
    }

    private string _text = string.Empty;
    [DataMember]
    public string Text
    {
        get => _text;
        set => SetProperty(ref this._text, value);
    }

    [DataMember]
    public AsyncCommand HelloCommand { get; }
}
```

We also need to fix the `MyToolWindowContent` constructor:
```CSharp
public MyToolWindowContent()
    : base(dataContext: new MyToolWindowData())
{
}
```

Let's update `MyToolWindowContent.xaml` to use the new properties in the datacontext. This is all normal WPF XAML. Even the `IAsyncCommand` object is proxied as an `ICommand` in the Visual Studio process so it can be data-bound as usual.
```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vsshell="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
    <Grid>
        <Grid.Resources>
            <Style TargetType="Label" BasedOn="{StaticResource {x:Static vsshell:VsResourceKeys.ThemedDialogLabelStyleKey}}" />
            <Style TargetType="TextBox" BasedOn="{StaticResource {x:Static vsshell:VsResourceKeys.TextBoxStyleKey}}" />
            <Style TargetType="Button" BasedOn="{StaticResource {x:Static vsshell:VsResourceKeys.ButtonStyleKey}}" />
            <Style TargetType="TextBlock">
                <Setter Property="Foreground" Value="{DynamicResource {x:Static vsshell:VsBrushes.WindowTextKey}}" />
            </Style>
        </Grid.Resources>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto" />
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="Auto" />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Label Content="Name:" />
        <TextBox Text="{Binding Name}" Grid.Column="1" />
        <Button Content="Say Hello" Command="{Binding HelloCommand}" Grid.Column="2" />
        <TextBlock Text="{Binding Text}" Grid.ColumnSpan="2" Grid.Row="1" />
    </Grid>
</DataTemplate>
```

![Tool window with two-way binding and a command](remote-ui-commands.gif "Tool window with two-way binding and a command")

## Understanding asynchronicity in Remote UI

The whole Remote UI communication for this tool window follows these steps:
1. The data context is proxied inside the Visual Studio process with its original content,
1. The control created from `MyToolWindowContent.xaml` is data bound to the data context proxy,
1. The user types some text in the text box which is assigned to the `Name` property of the data context proxy through databinding. The new value of `Name` is propagated to the `MyToolWindowData` object.
1. The user clicks the button causing a cascade of effects:
   - the `HelloCommand` in the data context proxy is executed,
   - the async execution of the extender's `AsyncCommand` code is started,
   - the async callback for `HelloCommad` updates the value of the observable property `Text`,
   - the new value of `Text` is propagated to the data context proxy,
   - the text block in the tool window is updated to the new value of `Text` through data binding.

![Tool window two-way binding and commands communication](remote-ui-databinding-commands.png "Tool window two-way binding and commands communication")

## Using command parameters to avoid race conditions

All the operations that involve communication between Visual Studio and the extension (blue arrows in the diagram) are asynchronous. It's important to consider this aspect in the overall design of the extension.

For this reason, if consistency is important, it is better to use command parameters, instead of two-way binding, to retrieve data context state at the time of the execution of a command.

Let's make this change by binding the button's `CommandParameter` to `Name`:
```xml
<Button Content="Say Hello" Command="{Binding HelloCommand}" CommandParameter="{Binding Name}" Grid.Column="2" />
```

Then, let's modify the command's callback to use the parameter.
```CSharp
HelloCommand = new AsyncCommand((parameter, cancellationToken) =>
{
    Text = $"Hello {(string)parameter!}!";
    return Task.CompletedTask;
});
```

With this approach the value of the `Name` property is retrieved synchronously from the data context proxy at the time of the button click and sent over to the extension. This avoids any race condition, especially if the `HelloCommand` callback is changed in the future to yield (have `await` expressions).

## Async commands consuming data from multiple properties

Using a command parameter is not an option if the command needs to consume multiple properties that are settable by the user. For example, if the UI had two textboxes: "First Name" and "Last Name".

The solution in this case is to retrieve the value of all the properties that are needed before yielding.

Below you can see a sample where the `FirstName` and `LastName` property values are retrieved before yielding to make sure that the value at the time of the command invocation is used:
```CSharp
HelloCommand = new(async (parameter, cancellationToken) =>
{
    string firstName = FirstName;
    string lastName = LastName;
    await Task.Delay(TimeSpan.FromSeconds(1));
    Text = $"Hello {firstName} {lastName}!";
});
```

It's also important to avoid the extension asynchronously updating the value of properties that can also be updated by the user. In other words, avoid [TwoWay](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.bindingmode) data binding.

# Advanced Remote UI concepts

The information above should be enough to build simple Remote UI components. For more advanced scenarios see [advanced Remote UI concepts](advanced-remote-ui.md).