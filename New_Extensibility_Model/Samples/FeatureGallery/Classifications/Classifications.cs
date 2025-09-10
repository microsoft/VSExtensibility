// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

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
            FontSize = 16,
            FontFamily = "Times New Roman",
            ThemedColors = new()
            {
                [Theme.KnownValues.Light] = new(UIColor.KnownColors.MediumBlue, UIColor.KnownColors.LightGreen),
                [Theme.KnownValues.Dark] = new(UIColor.KnownColors.Cyan, UIColor.KnownColors.DarkGreen),
                [Theme.KnownValues.HighContrast] = new(BackgroundColor: UIColor.SysColors.COLOR_HIGHLIGHT),
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
                [Theme.KnownValues.Light] = new(UIColor.KnownColors.Black),
                [Theme.KnownValues.Dark] = new(UIColor.KnownColors.White),
                [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
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
                [Theme.KnownValues.Light] = new(UIColor.KnownColors.Orange),
                [Theme.KnownValues.Dark] = new(UIColor.KnownColors.LightYellow),
                [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
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
                [Theme.KnownValues.Light] = new(UIColor.KnownColors.DarkGreen, UIColor.KnownColors.LightYellow),
                [Theme.KnownValues.Dark] = new(UIColor.KnownColors.LightGreen, UIColor.KnownColors.DarkRed),
                [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
            },
        },
    };
}
