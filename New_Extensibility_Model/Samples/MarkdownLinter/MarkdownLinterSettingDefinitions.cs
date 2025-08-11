// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MarkdownLinter;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;

#pragma warning disable VSEXTPREVIEW_SETTINGS // The settings API is currently in preview and marked as experimental

internal static class MarkdownLinterSettingDefinitions
{
    [VisualStudioContribution]
    internal static SettingCategory MarkdownLinterCategory { get; } = new("markdownLinter", "%MarkdownLinter.Settings.Category.DisplayName%")
    {
        Description = "%MarkdownLinter.Settings.Category.Description%",
        GenerateObserverClass = true,
    };

    [VisualStudioContribution]
    internal static Setting.String DisabledRules { get; } = new("disabledRules", "%MarkdownLinter.Settings.DisabledRules.DisplayName%", MarkdownLinterCategory, defaultValue: string.Empty)
    {
        Description = "%MarkdownLinter.Settings.DisabledRules.Description%",
    };
}
