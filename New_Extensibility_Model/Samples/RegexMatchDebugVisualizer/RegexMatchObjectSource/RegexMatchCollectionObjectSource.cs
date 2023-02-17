// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

using System;
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

		if (target is MatchCollection matchCollection)
		{
			var results = new RegexMatch[Math.Max(0, Math.Min(10, matchCollection.Count - index))];
			for (int i = 0; i < results.Length; i++)
			{
				var result = RegexMatchObjectSource.Convert(matchCollection[index + i]);
				result.Name = $"[{index + i}]";
				results[i] = result;
			}

			SerializeAsJson(outgoingData, results);
		}
		else
		{
			SerializeAsJson(outgoingData, null);
		}
	}
}
