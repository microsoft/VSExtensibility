// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.UI;
using SettingsSample.Settings;

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
    private readonly SettingsSampleCategoryObserver settingsObserver;
    private string sampleText = LoremIpsumText;
    private bool manualUpdate = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyToolWindowData" /> class.
    /// </summary>
    /// <param name="extensibility">
    /// Extensibility object instance.
    /// </param>
    /// <param name="settingsObserver">
    /// The injected observer for <see cref="SettingDefinitions.SettingsSampleCategory"/>.
    /// </param>
    public MyToolWindowData(VisualStudioExtensibility extensibility, SettingsSampleCategoryObserver settingsObserver)
    {
        this.extensibility = Requires.NotNull(extensibility);
        this.UpdateCommand = new AsyncCommand(this.UpdateAsync);
        this.settingsObserver = Requires.NotNull(settingsObserver);
        settingsObserver.Changed += this.SettingsObserver_ChangedAsync;
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
        set
        {
            if (this.SetProperty(ref this.manualUpdate, value))
            {
                _ = this.extensibility.Settings().WriteAsync(
                        batch =>
                        {
                            batch.WriteSetting(SettingDefinitions.AutoUpdateSetting, !value);
                        },
                        description: Resources.AutoUpdateSettingWriteDescription,
                        CancellationToken.None);
            }
        }
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

    private Task SettingsObserver_ChangedAsync(SettingsSampleCategorySnapshot settingsSnapshot)
    {
        this.ManualUpdate = !settingsSnapshot.AutoUpdateSetting.ValueOrDefault(SettingDefinitions.AutoUpdateSetting.DefaultValue);

        if (!this.ManualUpdate)
        {
            this.UpdateSampleTextFromSettings(settingsSnapshot);
        }

        return Task.CompletedTask;
    }

    private async Task UpdateAsync(object? commandParameter, CancellationToken cancellationToken)
    {
        var settingsSnapshot = await this.settingsObserver.GetSnapshotAsync(cancellationToken);
        this.UpdateSampleTextFromSettings(settingsSnapshot);
    }

    private void UpdateSampleTextFromSettings(SettingsSampleCategorySnapshot settingsSnapshot)
    {
        int length = settingsSnapshot.TextLengthSetting.ValueOrDefault(SettingDefinitions.TextLengthSetting.DefaultValue);
        string text = LoremIpsumText[..Math.Min(length, LoremIpsumText.Length)];

        string quoteStyle = settingsSnapshot.QuoteStyleSetting.ValueOrDefault(SettingDefinitions.QuoteStyleSetting.DefaultValue);
        this.SampleText = quoteStyle switch
        {
            "single" => $"'{text}'",
            "double" => $"\"{text}\"",
            _ => text,
        };
    }
}
