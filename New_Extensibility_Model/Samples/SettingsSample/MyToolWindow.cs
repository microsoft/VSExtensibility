// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SettingsSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.ToolWindows;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

#pragma warning disable VSEXTPREVIEW_SETTINGS // Type is for evaluation purposes only and is subject to change or removal in future updates.

/// <summary>
/// A sample tool window.
/// </summary>
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    private MyToolWindowData? dataContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyToolWindow" /> class.
    /// </summary>
    /// <param name="settingsObserver">
    /// The injected observer for <see cref="SettingDefinitions.SettingsSampleCategory"/>.
    /// </param>
    public MyToolWindow(Settings.SettingsSampleCategoryObserver settingsObserver)
    {
        Requires.NotNull(settingsObserver);

        this.Title = "Settings Sample Tool Window";
        this.dataContext = new MyToolWindowData(this.Extensibility, settingsObserver);
    }

    /// <inheritdoc />
    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.DocumentWell,
        AllowAutoCreation = false,
    };

    /// <inheritdoc />
    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl(this.dataContext));
    }
}
