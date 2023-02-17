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
	private const int MaxPageSize = 10;

	/// <inheritdoc/>
	public override void TransferData(object target, Stream incomingData, Stream outgoingData)
	{
		var index = (int)DeserializeFromJson(incomingData, typeof(int))!;

		RegexMatch[]? results = null;
		if (target is MatchCollection matchCollection)
		{
			int pageSize = Math.Max(0, Math.Min(MaxPageSize, matchCollection.Count - index));
			results = new RegexMatch[pageSize];
			for (int i = 0; i < results.Length; i++)
			{
				var result = RegexMatchObjectSource.Convert(matchCollection[index + i]);
				result.Name = $"[{index + i}]";
				results[i] = result;
			}
		}

		SerializeAsJson(outgoingData, results);
	}
}
