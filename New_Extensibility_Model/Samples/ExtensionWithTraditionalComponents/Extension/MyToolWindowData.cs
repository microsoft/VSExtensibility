// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionWithTraditionalComponents;

using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// ViewModel for the MyToolWindowContent remote user control.
/// </summary>
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
    private string name = string.Empty;
    private string text = string.Empty;

    public MyToolWindowData()
    {
        this.HelloCommand = new AsyncCommand((parameter, clientContext, cancellationToken) =>
        {
            this.Text = $"Hello {parameter as string}!";
            return Task.CompletedTask;
        });
    }

    [DataMember]
    public string Name
    {
        get => this.name;
        set => this.SetProperty(ref this.name, value);
    }

    [DataMember]
    public string Text
    {
        get => this.text;
        set => this.SetProperty(ref this.text, value);
    }

    [DataMember]
    public AsyncCommand HelloCommand { get; }
}
