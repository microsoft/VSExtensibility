﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer;

using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

/// <summary>
/// Debugger visualizer provider class for <see cref="MatchCollection"/>.
/// </summary>
[VisualStudioContribution]
internal class RegexMatchCollectionDebuggerVisualizerProvider : DebuggerVisualizerProvider
{
    /// <inheritdoc/>
    public override DebuggerVisualizerProviderConfiguration DebuggerVisualizerProviderConfiguration => new("%RegexMatchVisualizer.RegexMatchCollectionDebuggerVisualizerProvider.DisplayName%", typeof(MatchCollection))
    {
        VisualizerObjectSourceType = new("RegexMatchVisualizer.ObjectSource.RegexMatchCollectionObjectSource, RegexMatchObjectSource"),
    };

    /// <inheritdoc/>
    public override Task<IRemoteUserControl> CreateVisualizerAsync(VisualizerTarget visualizerTarget, CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new RegexMatchCollectionVisualizerUserControl(visualizerTarget));
    }
}
