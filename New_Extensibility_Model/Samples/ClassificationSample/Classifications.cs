// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ClassificationSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

internal static class Classifications
{
    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Header { get; } = new(
    "ClassificationType/ClassificationSample.Header")
    {
        ParentClassifications = [ClassificationType.KnownValues.String],
        Style = new(
            "%ClassificationSample.Classifications.Header.DisplayName%")
            {
                ThemedColors = new()
                {
                    [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.MediumBlue),
                    [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.Cyan),
                    [ColorsTheme.KnownValues.HighContrast] = new(UIThemeColor.SysColors.COLOR_HOTLIGHT),
                },
            },
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Separator { get; } = new(
        "ClassificationType/ClassificationSample.Separator")
    {
        ParentClassifications = [ClassificationType.KnownValues.Operator],
        Style = new(
            "%ClassificationSample.Classifications.Separator.DisplayName%")
            {
                ThemedColors = new()
                {
                    [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.Black),
                    [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.White),
                    [ColorsTheme.KnownValues.HighContrast] = new(UIThemeColor.SysColors.COLOR_HOTLIGHT),
                },
            },
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Quote { get; } = new(
        "ClassificationType/ClassificationSample.Quote")
    {
        ParentClassifications = [ClassificationType.KnownValues.Text],
        Style = new(
            "%ClassificationSample.Classifications.Quote.DisplayName%")
            {
                ThemedColors = new()
                {
                    [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.Orange),
                    [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.LightYellow),
                    [ColorsTheme.KnownValues.HighContrast] = new(UIThemeColor.SysColors.COLOR_HOTLIGHT),
                },
            },
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration EscapedQuote { get; } = new(
        "ClassificationType/ClassificationSample.EscapedQuote")
    {
        ParentClassifications = [ClassificationType.KnownValues.String],
        Style = new(
            "%ClassificationSample.Classifications.EscapedQuote.DisplayName%")
            {
                ThemedColors = new()
                {
                    [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.DarkGreen),
                    [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.LightGreen),
                    [ColorsTheme.KnownValues.HighContrast] = new(UIThemeColor.SysColors.COLOR_HOTLIGHT),
                },
            },
    };
}
