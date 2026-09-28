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

The extension contains a [code file](./SettingDefinitions.cs) that defines four settings
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

Setting the `GenerateObserverClass` property to `true`, results in an observer class being
code-generated. The observer can be used to read and monitor the settings in this category.
The observer is made available to dependency injection by calling `serviceCollection.AddSettingsObservers();`
[here](./SettingsSampleExtension.cs) and injected in the tool window constructor
[here](./MyToolWindow.cs);

In `MyToolWindowData`, the observer is used to monitor the values of the settings in the
`SettingSampleCategory`. The `SettingsSampleCategoryObserver` is generated under the `Settings`
child namespace of the extension's namespace.

```csharp
public MyToolWindowData(VisualStudioExtensibility extensibility, SettingsSampleCategoryObserver settingsObserver)
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
`VisualStudioExtensibility.Settings()`, by calling `WriteAsync`, which allows batching multiple
settings updates in a single operation:

```csharp
this.extensibility.Settings().WriteAsync(
    batch =>
    {
        batch.WriteSetting(SettingDefinitions.AutoUpdateSetting, !value);
    },
    description: Resources.AutoUpdateSettingWriteDescription,
    CancellationToken.None);```
```

## Usage

Once deployed, the "Sample Text Tool Window" command can be used to show the "Settings
Sample Tool Window" in the document well.

### A command enabled by a setting

The [Enable Sample Text Auto Update command](./EnableAutoUpdateCommand.cs) uses
`ActivationConstraint.Setting` to be enabled only when `AutoUpdateSetting` is `false`.
Its `CommandConfiguration.Description` provides explanatory text in Feature Search.
The tool-window command remains available regardless of the setting value.

To try both states, open **Tools > Sample Text Tool Window**. By default, auto-update
is on, so **Tools > Enable Sample Text Auto Update** is disabled. Select **Manual
update** in the tool window to turn auto-update off; the command becomes enabled.
Run it to turn auto-update back on, and the command becomes disabled again.

```csharp
EnabledWhen = ActivationConstraint.Setting(SettingDefinitions.AutoUpdateSetting, false),
Description = "%SettingsSample.EnableAutoUpdateCommand.Description%",
```

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

### Editing an array setting

`SampleWordsSetting` is a `Setting.StringArray` with two default words, `Lorem` and
`ipsum`. It allows adding and removing words, but does not permit duplicate entries.
The tool window displays the words as a comma-separated list; its settings observer
updates that list when the setting changes, even when **Manual update** is selected.

To try it, open the extension settings JSON file as above and add:

```json
{
  "settingsSample.sampleWords": ["Lorem", "ipsum", "dolor"]
}
```

Save the file and check that the tool window shows `Lorem, ipsum, dolor`. Edit or
remove `dolor` and save again to see the new value without reopening the window.
