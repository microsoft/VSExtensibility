// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamVisualizer;

using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MemoryStreamObjectSource;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

/// <summary>
/// Debugger visualizer provider for <see cref="MemoryStream"/>.
/// </summary>
[VisualStudioContribution]
internal class MemoryStreamDebuggerVisualizerProvider : DebuggerVisualizerProvider
{
    /// <inheritdoc/>
    public override DebuggerVisualizerProviderConfiguration DebuggerVisualizerProviderConfiguration => new(
        visualizerDisplayName: "%MemoryStreamVisualizer.MemoryStreamDebuggerVisualizerProvider.Name%",
        targetType: typeof(MemoryStream))
    {
        VisualizerObjectSourceType = new VisualizerObjectSourceType(typeof(MemoryStreamVisualizerObjectSource)),
        Style = VisualizerStyle.ToolWindow,
    };

    /// <inheritdoc/>
    public override Task<IRemoteUserControl> CreateVisualizerAsync(VisualizerTarget visualizerTarget, CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MemoryStreamVisualizerUserControl(visualizerTarget));
    }
}
