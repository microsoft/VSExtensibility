---
title: Menus and Toolbars reference
description: An overview of extensibility menus and toolbars
date: 2023-2-3
author: rytoth
ms.author: rytoth
ms.technology: vs-ide-sdk
ms.topic: overview
ms.date: 02/03/2023
ms.custom: template-overview
---

# Menus and Toolbars overview

Menus and toolbars are the way users access commands in your extension. They are convenient graphical ways to present your commands to users. Typically, related commands are clustered together on the same menu or toolbar.

## Work with menus and toolbars

This overview covers these top scenarios for working with menus and toolbars:

- [Create a menu](#create-a-menu)
- [Create a toolbar](#create-a-toolbar)
- [Place items on a menu](#place-items-on-a-menu)
- [Place items on a toolbar](#place-items-on-a-toolbar)
- [Create a group](#create-a-group)

## Create a menu

To create a menu with the new Extensibility Model, add a static [`Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#MenuConfiguration-type) property, adorning the class with the `VisualStudioContribution` attribute. This static property can be placed on any class in your Extension project. In the new Extensibility Model samples they exist on the `Extension` class for simplicity. Note that menus without any visible children won't be visible in the UI.

```csharp
[VisualStudioContribution]
public class ExtensionEntrypoint : Extension
{
  [VisualStudioContribution]
  public static MenuConfiguration MyMenu => new("My Menu!");
}
```

### MenuConfiguration class

The [`MenuConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#MenuConfiguration-type) class has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| DisplayName | String | Yes | The default display name of your menu. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize a command](command.md#localize-a-command). |
| TooltipText | String | No | The text to display as the tooltip when the menu is hovered or focused. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize a command](command.md#localize-a-command). |
| Placements | CommandPlacement[] | No | Specifies the existing Groups within Visual Studio that the menu will be parented to. See more on this at [Place a command in the IDE](command.md#place-a-command-in-the-ide). |
| Children | MenuChild[] | No | Describes the set of commands, menus and groups that should be parented to this menu. The order that these items are defined in the array represent the order that they will appear visually in the IDE. See more on this at [Place items on a menu](#place-items-on-a-menu) |
| Priority | uint | No | Describes the display order of the menu relative to other manus/commands parented to the same `CommandPlacement.KnownPlacements`. |

## Create a toolbar

To create a toolbar with the new Extensibility Model, add a static [`Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#ToolbarConfiguration-type) property, adorning the class with the `VisualStudioContribution` attribute. This static property can be placed on any class in your Extension project. In the new Extensibility Model samples they exist on the `Extension` class for simplicity.

```csharp
[VisualStudioContribution]
public class ExtensionEntrypoint : Extension
{
  [VisualStudioContribution]
  public static ToolbarConfiguration MyToolbar => new("My Toolbar!");
}
```

Leaving the `Placement` property of the `ToolbarConfiguration` as `null` will place the toolbar on the Standard Toolbar Bar and can be made visible by selecting the toolbar in the `View -> Toolbars` menu.

### ToolbarConfiguration class

The [`ToolbarConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#ToolbarConfiguration-type) class has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| DisplayName | String | Yes | The default display name of your toolbar. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize a command](command.md#localize-a-command). |
| TooltipText | String | No | The text to display as the tooltip when the toolbar is hovered or focused. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize a command](command.md#localize-a-command). |
| Placements | CommandPlacement[] | No | Specifies the existing Groups within Visual Studio that the toolbar will be parented to. See more on this at [Place a command in the IDE](command.md#place-a-command-in-the-ide). Leaving this property as `null` will place the toolbar on the Standard Toolbar Bar and can be made visible by selecting the toolbar in the `View -> Toolbars` menu |
| Children | ToolbarChild[] | No | Describes the set of commands, menus and groups that should be parented to this toolbar. The order that these items are defined in the array represent the order that they will appear visually in the IDE. See more on this at [Place items on a toolbar](#place-items-on-a-toolbar) |
| Priority | uint | No | Describes the display order of the toolbar relative to other toolbar with the same placement. |

## Place items on a menu

Placing on item on a menu is done by adding items to the `Children` array on the `MenuConfiguration`. The order that items are added to this array dictate how these items will be displayed visually in the IDE.

### Placing commands on a menu

Placing commands on a menu is done using the `MenuChild.Command<T>` method, replacing the template argument with the class name of your `Command`.

```csharp
[VisualStudioContribution]
public static MenuConfiguration MyMenu => new("My Menu!")
{
    Children = new[]
    {
        MenuChild.Command<MyCommand>(),
    },
};
```

### Placing menus on a menu

Placing menus on a menu is done using the `MenuChild.Menu` method, passing in another `MenuConfiguration` as a parameter.

```csharp
[VisualStudioContribution]
public static MenuConfiguration MyChildMenu => new("My Child Menu!");

[VisualStudioContribution]
public static MenuConfiguration MyParentMenu => new("My Parent Menu!")
{
    Children = new[]
    {
        MenuChild.Menu(MyChildMenu),
    },
};
```

### Separating menu items into groups

Items within a menu can be grouped together by having a `MenuChild.Separator` between items. Visually, this will look like a thin line placed between two items.

```csharp
[VisualStudioContribution]
public static MenuConfiguration MyMenu1 => new("My Menu!")
{
    Children = new[]
    {
        MenuChild.Command<MyCommand1>(), // Assuming there is a `Command` defined in the extension called `MyCommand1`
        MenuChild.Menu(MyMenu2), // Assuming there is a `MenuConfiguration` defined in the extension called `MyMenu2`
        MenuChild.Separator,
        MenuChild.Command<MyCommand2>(), // Assuming there is a `Command` defined in the extension called `MyCommand2`
        MenuChild.Menu(MyMenu3), // Assuming there is a `MenuConfiguration` defined in the extension called `MyMenu3`
    },
};
```

This can also be accomplished by using the `MenuChild.Group` method to define a group inline. You would then use the `GroupChild` class to parent items to the group.

```csharp
[VisualStudioContribution]
public static MenuConfiguration MyMenu1 => new("My Menu 1")
{
    Children = new[]
    {
        MenuChild.Group(
            GroupChild.Command<MyCommand1>(), // Assuming there is a `Command` defined in the extension called `MyCommand1`
            GroupChild.Menu(MyMenu2)), // Assuming there is a `MenuConfiguration` defined in the extension called `MyMenu2`
        MenuChild.Group(
            GroupChild.Command<MyCommand2>(), // Assuming there is a `Command` defined in the extension called `MyCommand2`
            GroupChild.Menu(MyMenu3)), // Assuming there is a `MenuConfiguration` defined in the extension called `MyMenu3`
    },
};
```

In the two example above, the resulting menu would identical in the IDE. The menu `MyMenu1` would look like the menu in the screenshot below:

![Menu with separator](menu-with-separator.png "Menu with separator")

## Place items on a toolbar

Placing commands on a toolbar is done using the `ToolbarChild.Command<T>` method, replacing the template argument with the class name of your `Command`.

```csharp
[VisualStudioContribution]
public static ToolbarConfiguration MyToolbar => new("My Toolbar!")
{
    Children = new[]
    {
        ToolbarChild.Command<MyCommand>(),
    },
};
```

### Separating toolbar items into groups

Items within a toolbar can be grouped together by having a `ToolbarChild.Separator` between items. Visually, this will look like a thin line placed between two items.

```csharp
[VisualStudioContribution]
public static ToolbarConfiguration MyToolbar => new("My Toolbar!")
{
    Children = new[]
    {
        ToolbarChild.Command<MyCommand1>(), // Assuming there is a `Command` defined in the extension called `MyCommand1`
        ToolbarChild.Separator,
        ToolbarChild.Command<MyCommand2>(), // Assuming there is a `Command` defined in the extension called `MyCommand2`
    },
};
```

This can also be accomplished by using the `ToolbarChild.Group` method to define a group inline. You would then use the `ToolbarChild` class to parent items to the group.

```csharp
[VisualStudioContribution]
public static ToolbarConfiguration MyToolbar => new("My Toolbar 1")
{
    Children = new[]
    {
        ToolbarChild.Group(
            GroupChild.Command<MyCommand1>(), // Assuming there is a `Command` defined in the extension called `MyCommand1`
        ToolbarChild.Group(
            GroupChild.Command<MyCommand2>(), // Assuming there is a `Command` defined in the extension called `MyCommand2`
    },
};
```

In the two example above, the resulting toolbar would identical in the IDE. The toolbar `MyToolbar` would look like the toolbar in the screenshot below:

![Toolbar with separator](toolbar-with-separator.png "Toolbar with separator")

## Create a group

A group is a visual grouping of items where a separator will placed in between the last and first items of adjacent groups. In the sections above, it describes how to create groups inside of the context of the `Children` property of a `MenuConfiguration` or `ToolbarConfiguration`. It is also possible to define groups inside of their own `GroupConfiguration`. This is useful when you would like to parent a group to an existing menu or toolbar in Visual Studio without defining you're own menu or toolbar. It can also be useful if you would like to format your code in a way that separates your group definitions from your menu and toolbar definitions.
