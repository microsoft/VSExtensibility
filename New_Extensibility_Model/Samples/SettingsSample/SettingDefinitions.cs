// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;

internal static class SettingDefinitions
{
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

    [VisualStudioContribution]
    internal static Setting.Integer TextLengthSetting { get; } = new("textLength", "%SettingsSample.Settings.TextLength.DisplayName%", SettingsSampleCategory, defaultValue: 10)
    {
        Description = "%SettingsSample.Settings.TextLength.Description%",
        Minimum = 1,
        Maximum = MyToolWindowData.LoremIpsumText.Length,
    };

    [VisualStudioContribution]
    internal static Setting.Enum QuoteStyleSetting { get; } = new(
        "quoteStyle",
        "%SettingsSample.Settings.QuoteStyle.DisplayName%",
        SettingsSampleCategory,
        [new EnumSettingEntry("none", "%SettingsSample.Settings.QuoteStyle.None%"), new EnumSettingEntry("single", "%SettingsSample.Settings.QuoteStyle.Single%"), new EnumSettingEntry("double", "%SettingsSample.Settings.QuoteStyle.Double%")],
        defaultValue: "double")
    {
        Description = "%SettingsSample.Settings.QuoteStyle.Description%",
    };
}
