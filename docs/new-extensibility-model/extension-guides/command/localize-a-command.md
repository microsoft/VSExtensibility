---
title: Command localization reference
description: An overview of extensibility command localization
date: 2023-2-3
author: rytoth
ms.author: rytoth
ms.technology: vs-ide-sdk
ms.topic: overview
ms.date: 02/03/2023
ms.custom: template-overview
---

# Command localization overview

The text displayed on a command can be localized by including *string-resources.json* files with your extension and surrounding the `displayName` parameter with `%` characters in your configuration constructor. The `ToolTipText` property also supports localization. This applies to `CommandConfiguration`, `MenuConfiguration`, and `ToolbarConfiguration`.

A `Command` with a localized `DisplayName` and `ToolTipText` looks like the following:

```csharp
public override CommandConfiguration CommandConfiguration => new("%Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName%")
{
    ToolTipText = "%Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.ToolTipText%"
}
```

## string-resources.json

Your extension should provide a `string-resources.json` file for every language that your extension supports. This JSON file is a dictionary of key/value pairs where the key is a globally (all of Visual Studio) unique identifier for a string resource and the value is the localized string resource. These JSON files should be deployed with your extension under the ".vsextension" directory, with each language you support being shipped in a folder matching the name of the locale, that is, "de" for German, "it" for Italian, etc. The `string-resources.json` deployed at the root of the ".vsextension" directory is used as the default if your extension does not support the language that Visual Studio is currently set to. An example of what this directory structure would look like can be seen here:

![Localization directory structure](localizing-a-command.png "Localization directory structure")

string-resources.json sample:

```json
{
    "Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName": "Sample Remote Command Display Name",
    "Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.ToolTipText": "Sample Remote Command ToolTip"
}
```
