// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample data context object to use with tool window UI content.
/// </summary>
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
    internal static readonly string LoremIpsumText = """
        Lorem ipsum dolor sit amet consectetur adipiscing elit dignissim lacinia donec,
        praesent diam ac mattis morbi nisi dictum dapibus. Convallis natoque interdum
        curabitur malesuada tellus aliquam dignissim hendrerit tempor, primis sem nulla
        neque cubilia rutrum mollis nisl, eleifend imperdiet lacinia fames gravida sed mus
        magnis. Pretium aliquet consequat curabitur eros eleifend praesent, nostra malesuada
        hendrerit ornare volutpat, cubilia aptent at mollis convallis.
        """;

    private readonly VisualStudioExtensibility extensibility;
    private string sampleText = LoremIpsumText;
    private bool manualUpdate = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyToolWindowData" /> class.
    /// </summary>
    /// <param name="extensibility">
    /// Extensibility object instance.
    /// </param>
    public MyToolWindowData(VisualStudioExtensibility extensibility)
    {
        this.extensibility = Requires.NotNull(extensibility, nameof(extensibility));

        this.UpdateCommand = new AsyncCommand(this.UpdateAsync);
    }

    /// <summary>
    /// Gets the async command used to show a message prompt.
    /// </summary>
    [DataMember]
    public IAsyncCommand UpdateCommand
    {
        get;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the user must
    /// click the "Update" button to refresh the sample text.
    /// </summary>
    [DataMember]
    public bool ManualUpdate
    {
        get => this.manualUpdate;
        set => this.SetProperty(ref this.manualUpdate, value);
    }

    /// <summary>
    /// Gets or sets the message to display in the message prompt.
    /// </summary>
    [DataMember]
    public string SampleText
    {
        get => this.sampleText;
        set => this.SetProperty(ref this.sampleText, value);
    }

    /// <summary>
    /// Initializes the current instance of <see cref="MyToolWindowData"/>.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to monitor.</param>
    /// <returns>Task indicating completion of initialization.</returns>
    public Task InitializeAsync(CancellationToken cancellationToken)
    {
        return this.InitializeSettingsAsync(cancellationToken);
    }

#pragma warning disable VSEXTPREVIEW_SETTINGS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

    private async Task InitializeSettingsAsync(CancellationToken cancellationToken)
    {
        await this.extensibility.Settings().SubscribeAsync(
            [SettingDefinitions.SettingsSampleCategory],
            cancellationToken,
            values =>
            {
                if (values.TryGetValue(SettingDefinitions.AutoUpdateSetting.FullId, out ISettingValue? autoUpdateValue))
                {
                    this.ManualUpdate = !autoUpdateValue.Value<bool>();
                }

                if (!this.ManualUpdate)
                {
                    this.UpdateSampleTextFromSettings(values);
                }
            });
    }

    private async Task UpdateAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        SettingValues values = await this.extensibility.Settings().ReadEffectiveValuesAsync(
            [SettingDefinitions.SettingsSampleCategory],
            cancellationToken);

        this.UpdateSampleTextFromSettings(values);
    }

    private void UpdateSampleTextFromSettings(SettingValues values)
    {
        string text = LoremIpsumText;

        if (values.TryGetValue(SettingDefinitions.TextLengthSetting.FullId, out ISettingValue? textLengthValue))
        {
            int length = textLengthValue.Value<int>();
            text = LoremIpsumText[..Math.Min(length, LoremIpsumText.Length)];
        }

        if (values.TryGetValue(SettingDefinitions.QuoteStyleSetting.FullId, out ISettingValue? quoteStyleValue))
        {
            this.SampleText = quoteStyleValue.Value<string>() switch
            {
                "single" => $"'{text}'",
                "double" => $"\"{text}\"",
                _ => text,
            };
        }
    }

#pragma warning restore VSEXTPREVIEW_SETTINGS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
}
