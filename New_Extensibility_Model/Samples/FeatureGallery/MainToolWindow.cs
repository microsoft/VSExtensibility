// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.ToolWindows;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

/// <summary>
/// A sample tool window.
/// </summary>
[VisualStudioContribution]
public class MainToolWindow : ToolWindow
{
    private readonly IReadOnlyList<TestData> tests;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainToolWindow" /> class.
    /// </summary>
    public MainToolWindow()
    {
        this.Title = "VisualStudio.Extensibility Feature Gallery";
        this.tests = new TestData[]
        {
            new DocumentEditingTest(this.Extensibility),
            new ModalDialogTest(this.Extensibility),
            new EditorMarginTest(this.Extensibility),
        };
    }

    /// <inheritdoc />
    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.Floating,
        AllowAutoCreation = true,
    };

    /// <inheritdoc />
    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MainToolWindowControl(this.tests));
    }
}
