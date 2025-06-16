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
        ParentClassifications = [ClassificationType.KnownValues.Text],
        Style = new(
        "%FeatureGallery.ClassificationSample.Header.DisplayName%")
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
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Quote { get; } = new(
        "ClassificationType/ClassificationSample.Quote")
    {
        ParentClassifications = [ClassificationType.KnownValues.BracePairLevelOne],
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration EscapedQuote { get; } = new(
        "ClassificationType/ClassificationSample.EscapedQuote")
    {
        ParentClassifications = [ClassificationType.KnownValues.BracePairLevelTwo],
    };
}
