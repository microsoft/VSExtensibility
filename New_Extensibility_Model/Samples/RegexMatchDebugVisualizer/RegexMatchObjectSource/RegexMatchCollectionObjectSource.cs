// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer.ObjectSource;

using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.DebuggerVisualizers;

/// <summary>
/// Debugger visualizer object source for <see cref="MatchCollection"/>.
/// </summary>
public class RegexMatchCollectionObjectSource : VisualizerObjectSource
{
    /// <inheritdoc/>
    public override void TransferData(object target, Stream incomingData, Stream outgoingData)
    {
        var index = (int)DeserializeFromJson(incomingData, typeof(int))!;

        if (target is MatchCollection matchCollection && index < matchCollection.Count)
        {
            var result = RegexMatchObjectSource.Convert(matchCollection[index]);
            result.Name = $"[{index}]";
            SerializeAsJson(outgoingData, result);
        }
        else
        {
            SerializeAsJson(outgoingData, null);
        }
    }
}
