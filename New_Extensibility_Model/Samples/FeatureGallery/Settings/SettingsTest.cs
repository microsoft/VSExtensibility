// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;
using Microsoft.VisualStudio.Extensibility.Shell;

[DataContract]
internal class SettingsTest : TestData
{
    public SettingsTest(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    [DataMember]
    public override string ButtonText => "Update a setting value";

    [DataMember]
    public override string Description => "This command updates a setting value and shows a prompt when the value update is complete.";

    [VisualStudioContribution]
#pragma warning disable CEE0027 // String not localized
#if INPROC
    private static SettingCategory Category { get; } = new("inProcFeatureGallery", "In-Proc Feature Gallery");
#else
    private static SettingCategory Category { get; } = new("featureGallery", "Feature Gallery");
#endif

    [VisualStudioContribution]
    private static Setting.Boolean BooleanSetting { get; } = new("booleanSetting", "Boolean Setting", Category, defaultValue: false);
#pragma warning restore CEE0027 // String not localized

    protected override async Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        await this.Extensibility.Settings().WriteAsync(
            batch => batch.WriteSetting(BooleanSetting, false),
            "Setting booleanSetting to false",
            cancellationToken);

        await WaitForSettingValueAsync(expectedValue: false);

        await this.Extensibility.Settings().WriteAsync(
            batch => batch.WriteSetting(BooleanSetting, true),
            "Setting booleanSetting to true",
            cancellationToken);

        await WaitForSettingValueAsync(expectedValue: true);

        async Task WaitForSettingValueAsync(bool expectedValue)
        {
            TaskCompletionSource<bool> settingValueIsAsExpected = new();
            using var settingValueObserver = await this.Extensibility.Settings().SubscribeAsync(BooleanSetting, cancellationToken, value =>
            {
                if (value.Succeeded && value.Value == expectedValue)
                {
                    settingValueIsAsExpected.SetResult(true);
                }
            });

            await settingValueIsAsExpected.Task;
        }

        await this.Extensibility.Shell().ShowPromptAsync("All done.", PromptOptions.OK, cancellationToken);
    }
}
