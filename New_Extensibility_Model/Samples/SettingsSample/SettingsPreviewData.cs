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
