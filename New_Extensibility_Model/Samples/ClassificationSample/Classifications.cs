// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ClassificationSample;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

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
                    [Theme.KnownValues.Light] = new(UIColor.KnownColors.MediumBlue),
                    [Theme.KnownValues.Dark] = new(UIColor.KnownColors.Cyan),
                    [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
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
                    [Theme.KnownValues.Light] = new(UIColor.KnownColors.Black),
                    [Theme.KnownValues.Dark] = new(UIColor.KnownColors.White),
                    [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
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
                    [Theme.KnownValues.Light] = new(UIColor.KnownColors.Orange),
                    [Theme.KnownValues.Dark] = new(UIColor.KnownColors.LightYellow),
                    [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
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
                    [Theme.KnownValues.Light] = new(UIColor.KnownColors.DarkGreen),
                    [Theme.KnownValues.Dark] = new(UIColor.KnownColors.LightGreen),
                    [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
                },
            },
    };
}
