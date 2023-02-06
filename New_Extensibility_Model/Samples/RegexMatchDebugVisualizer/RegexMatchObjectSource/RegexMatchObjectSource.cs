// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

public class RegexMatchObjectSource : VisualizerObjectSource
{
	/// <inheritdoc/>
	public override void GetData(object target, Stream outgoingData)
	{
		if (target is Match match)
		{
			var result = new RegexMatch
			{
				Success = match.Success,
				Index = match.Index,
				Length = match.Length,
				Value = match.Value,
				Captures = Convert(match.Captures),
				Groups = Convert(match.Groups),
			};

			SerializeAsJson(outgoingData, result);
		}
	}

	private static RegexCapture[] Convert(CaptureCollection captures) =>
		captures.OfType<Capture>()
			.Select(c => new RegexCapture
			{
				Index = c.Index,
				Length = c.Length,
				Value = c.Value,
			}).ToArray();

	private static RegexGroup[] Convert(GroupCollection groups) =>
		groups.OfType<Group>()
			.Select(g => new RegexGroup
			{
				Success = g.Success,
				Index = g.Index,
				Length = g.Length,
				Value = g.Value,
				Captures = Convert(g.Captures),
			}).ToArray();
}
