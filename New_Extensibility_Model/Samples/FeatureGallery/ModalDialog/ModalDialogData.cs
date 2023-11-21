// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.ModalDialog;
#else
namespace FeatureGallery.ModalDialog;
#endif

using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility.UI;

[DataContract]
internal class ModalDialogData
{
    private Random random = new();

    public ModalDialogData()
    {
        this.AddColorCommand = new AsyncCommand((parameter, cancellationToken) =>
        {
            var color = new byte[3];
            this.random.NextBytes(color);
            this.Colors.Add(new MyColor(color[0], color[1], color[2]));
            return Task.CompletedTask;
        });

        this.RemoveColorCommand = new AsyncCommand((parameter, cancellationToken) =>
        {
            this.Colors.Remove((MyColor)parameter!);
            return Task.CompletedTask;
        });
    }

    [DataMember]
    public ObservableList<MyColor> Colors { get; } = new();

    [DataMember]
    public AsyncCommand AddColorCommand { get; }

    [DataMember]
    public AsyncCommand RemoveColorCommand { get; }

    [DataContract]
    public class MyColor
    {
        public MyColor(byte r, byte g, byte b)
        {
            this.ColorText = $"#{r:X2}{g:X2}{b:X2}";
            this.Color = new($"""
                <LinearGradientBrush xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" StartPoint="0,0" EndPoint="1,1">
                    <GradientStop Color="Black" Offset="0.0" />
                    <GradientStop Color="{this.ColorText}" Offset="0.7" />
                </LinearGradientBrush>
                """);
        }

        [DataMember]
        public string ColorText { get; }

        [DataMember]
        public XamlFragment Color { get; }
    }
}
