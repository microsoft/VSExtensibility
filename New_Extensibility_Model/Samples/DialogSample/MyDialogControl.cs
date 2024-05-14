// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DialogSample;

using System.Threading;
using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as dialog UI content.
/// </summary>
internal class MyDialogControl : RemoteUserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MyDialogControl" /> class.
    /// </summary>
    /// <param name="dataContext">
    /// Data context of the remote control which can be referenced from xaml through data binding.
    /// </param>
    /// <param name="synchronizationContext">
    /// Optional synchronizationContext that the extender can provide to ensure that <see cref="IAsyncCommand"/>
    /// are executed and properties are read and updated from the extension main thread.
    /// </param>
    public MyDialogControl(object? dataContext, SynchronizationContext? synchronizationContext = null)
        : base(dataContext, synchronizationContext)
    {
        this.ResourceDictionaries.AddEmbeddedResource("DialogSample.Resources.MyResources.xaml");
    }
}
