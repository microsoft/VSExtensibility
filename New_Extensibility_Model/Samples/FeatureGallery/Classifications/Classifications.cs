// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_TAGGERS // Type is for evaluation purposes only and is subject to change or removal in future updates.

internal static class Classifications
{
    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Header { get; } = new(
#if INPROC
        "ClassificationType/InProcFeatureGallery.Header")
#else
        "ClassificationType/FeatureGallery.Header")
#endif
    {
        ParentClassifications = [ClassificationType.KnownValues.Text],
        Style = new(
#if INPROC
            "%InProcFeatureGallery.Classifications.Header.DisplayName%")
#else
            "%FeatureGallery.Classifications.Header.DisplayName%")
#endif
        {
            TextStyle = TextStyle.Bold | TextStyle.Underline,
            FontRenderingSize = 16,
            FontFamily = "Times New Roman",
            ThemedColors = new()
            {
                [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.MediumBlue, UIThemeColor.KnownColors.LightGreen),
                [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.Cyan, UIThemeColor.KnownColors.DarkGreen),
                [ColorsTheme.KnownValues.HighContrast] = new(BackgroundColor: UIThemeColor.SysColors.COLOR_HIGHLIGHT),
            },
        },
    };

    [VisualStudioContribution]
    public static ClassificationTypeConfiguration Separator { get; } = new(
#if INPROC
        "ClassificationType/InProcFeatureGallery.Separator")
#else
        "ClassificationType/FeatureGallery.Separator")
#endif
    {
        ParentClassifications = [ClassificationType.KnownValues.Operator],
        Style = new(
#if INPROC
            "%InProcFeatureGallery.Classifications.Separator.DisplayName%")
#else
            "%FeatureGallery.Classifications.Separator.DisplayName%")
#endif
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
#if INPROC
        "ClassificationType/InProcFeatureGallery.Quote")
#else
        "ClassificationType/FeatureGallery.Quote")
#endif
    {
        ParentClassifications = [ClassificationType.KnownValues.Text],
        Style = new(
#if INPROC
            "%InProcFeatureGallery.Classifications.Quote.DisplayName%")
#else
            "%FeatureGallery.Classifications.Quote.DisplayName%")
#endif
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
#if INPROC
        "ClassificationType/InProcFeatureGallery.EscapedQuote")
#else
        "ClassificationType/FeatureGallery.EscapedQuote")
#endif
    {
        ParentClassifications = [ClassificationType.KnownValues.String],
        Style = new(
#if INPROC
            "%InProcFeatureGallery.Classifications.EscapedQuote.DisplayName%")
#else
            "%FeatureGallery.Classifications.EscapedQuote.DisplayName%")
#endif
        {
            TextStyle = TextStyle.Italic,
            ThemedColors = new()
            {
                [ColorsTheme.KnownValues.Light] = new(UIThemeColor.KnownColors.DarkGreen, UIThemeColor.KnownColors.LightYellow),
                [ColorsTheme.KnownValues.Dark] = new(UIThemeColor.KnownColors.LightGreen, UIThemeColor.KnownColors.DarkRed),
                [ColorsTheme.KnownValues.HighContrast] = new(UIThemeColor.SysColors.COLOR_HOTLIGHT),
            },
        },
    };
}
