// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer;

using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;
using RegexMatchVisualizer.ObjectSource;

/// <summary>
/// Debugger visualizer provider class for <see cref="Match"/>.
/// </summary>
[VisualStudioContribution]
internal class RegexMatchDebuggerVisualizerProvider : DebuggerVisualizerProvider
{
    /// <inheritdoc/>
    public override DebuggerVisualizerProviderConfiguration DebuggerVisualizerProviderConfiguration => new("%RegexMatchVisualizer.RegexMatchDebuggerVisualizerProvider.DisplayName%", typeof(Match))
    {
        VisualizerObjectSourceType = new("RegexMatchVisualizer.ObjectSource.RegexMatchObjectSource, RegexMatchObjectSource"),
    };

    /// <inheritdoc/>
    public override async Task<IRemoteUserControl> CreateVisualizerAsync(VisualizerTarget visualizerTarget, CancellationToken cancellationToken)
    {
        var regexMatch = await visualizerTarget.ObjectSource.RequestDataAsync<RegexMatch>(jsonSerializer: null, cancellationToken);

        return new RegexMatchVisualizerUserControl(regexMatch);
    }
}
