// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;
using Microsoft.VisualStudio.Extensibility.UI;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

internal class SettingsPreviewControl : RemoteUserControl
{
    private readonly IDisposable subscription;

    private SettingsPreviewControl(SettingsPreviewData data, IDisposable subscription)
        : base(data)
    {
        this.subscription = subscription;
    }

    public static async Task<IRemoteUserControl> CreateAsync(
        SettingIdentifier category,
        VisualStudioExtensibility extensibility,
        CancellationToken cancellationToken)
    {
        var data = new SettingsPreviewData();
        var subscription = await extensibility.Settings().SubscribeAsync(
            SettingDefinitions.TextLengthSetting,
            cancellationToken,
            value => data.PreviewText = value.Succeeded
                ? MyToolWindowData.LoremIpsumText[..Math.Clamp(value.Value, 0, MyToolWindowData.LoremIpsumText.Length)]
                : "Unable to read the text length setting.");

        return new SettingsPreviewControl(data, subscription);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.subscription.Dispose();
        }

        base.Dispose(disposing);
    }
}

[DataContract]
internal class SettingsPreviewData : NotifyPropertyChangedObject
{
    private string previewText = string.Empty;

    [DataMember]
    public string PreviewText
    {
        get => this.previewText;
        set => this.SetProperty(ref this.previewText, value);
    }
}
