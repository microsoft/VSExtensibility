---
title: Extension Settings Sample reference
description: A reference sample for extensions settings
date: 2024-08-20
---

# Walkthrough: Extension Settings Sample

This is a simple extension that shows how settings can be added to Visual Studio and read
to configure the behavior of a tool window.

## Tool window definition

See the [ToolWindowSample](../ToolWindowSample/README.md) for more information on defining
the tool window.

## Setting definitions

The extension contains a [code file](./SettingDefinitions.cs) that defines three settings
and a parent category to contain them. Each setting and the category starts with the
`VisualStudioContribution` class attribute which makes it available to Visual Studio:

```csharp
[VisualStudioContribution]
internal static SettingCategory SettingsSampleCategory { get; } = new("settingsSample", "%SettingsSample.Settings.Category.DisplayName%")
{
    Description = "%SettingsSample.Settings.Category.Description%",
    GenerateObserverClass = true,
};

[VisualStudioContribution]
internal static Setting.Boolean AutoUpdateSetting { get; } = new("autoUpdate", "%SettingsSample.Settings.AutoUpdate.DisplayName%", SettingsSampleCategory, defaultValue: true)
{
    Description = "%SettingsSample.Settings.AutoUpdate.Description%",
};
```

The `SettingCategory` and `Setting.Boolean` properties define information about the settings
that is available to Visual Studio even before the extension is loaded.

Settings the `GenerateObserverClass` property to `true`, results in an observer class being
code-generated. The observer can be used to read and monitor the settings in this category.
The observer is made available to dependency injection by calling `serviceCollection.AddSettingsObservers();`
[here](./SettingsSampleExtension.cs) and injected in the tool window constructor
[here](./MyToolWindow.cs);

In `MyToolWindowData`, the observer is used to monitor the values of the settings in the
`SettingSampleCategory`:

```csharp
public MyToolWindowData(VisualStudioExtensibility extensibility, Settings.SettingsSampleCategoryObserver settingsObserver)
{
    ...
    this.settingsObserver = Requires.NotNull(settingsObserver);
    settingsObserver.Changed += this.SettingsObserver_ChangedAsync;
}

private Task SettingsObserver_ChangedAsync(Settings.SettingsSampleCategorySnapshot settingsSnapshot)
{
    this.ManualUpdate = !settingsSnapshot.AutoUpdateSetting.ValueOrDefault(defaultValue: true);
    ...
}
```

Note that, because the `Changed` event handler is always invoked at least once, with the current
value of the settings, we don't need special code to handle the first read of the settings.

If relying on events is not desirable, the observer can also be used to read the current values
of the settings:

```csharp
var settingsSnapshot = await this.settingsObserver.GetSnapshotAsync(cancellationToken);
```

If the extension needs to update settings' values, this can be done through
`VisualStudioExtensibility.Settings()`, by calling `WriteAsync`, which takes allows to batch
multiple settings updates in a single operation:

```csharp
this.extensibility.Settings().WriteAsync(
    batch =>
    {
        batch.WriteSetting(SettingDefinitions.AutoUpdateSetting, !value);
    },
    description: Resources.AutoUpdateSettingWriteDescription,
    CancellationToken.None);```

## Usage

Once deployed, the "Sample Text Tool Window" command can be used to show the "Settings
Sample Tool Window" in the document well.

### Changing the TextLengthSetting

Setting values are stored in json files in well-known locations. After deploying the
extension:

* Open the "Sample Text Tool Window": Tools -> Sample Text Tool Window
* Open the extension settings json file: Extensions -> Extension Settings (experimental) -> User Scope (current install)

The `extensibility.settings.json` file will open in an editor. To change the textLength
setting, add a value to the file to override
the default:

```json
/* Visual Studio Settings File */
{
  "settingsSample.textLength": 150
}
```

The string key is the `FullId` property of the `TextLengthSetting` property defined in
[SettingDefinitions](./SettingDefinitions.cs). It is formed by the id of the category and
the id of the setting.

Each time you change the value and save the file, the sample text in the tool window will
update.

## Current Limitations

The settings API is currently experimental, and has several limitations:

* An extension can only read or write settings from itself or other extensions. Core Visual Studio settings are not available.
* There is no UI for extension settings. They can only be changed by using the json files available in the Extensions -> Extension Settings (experimental) menu.