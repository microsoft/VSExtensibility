// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;

/// <summary>
/// A sample command for showing a tool window.
/// </summary>
[VisualStudioContribution]
public class MyToolbarCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%ToolWindowSample.MyToolbarCommand.DisplayName%")
    {
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconOnly),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Shell().ShowPromptAsync("The toolbar button was clicked", PromptOptions.OK, cancellationToken);
    }
}
