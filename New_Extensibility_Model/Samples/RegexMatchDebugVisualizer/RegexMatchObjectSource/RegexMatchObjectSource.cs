// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.DebuggerVisualizers;

/// <summary>
/// Debugger visualizer object source for <see cref="Match"/>.
/// </summary>
public class RegexMatchObjectSource : VisualizerObjectSource
{
	private static readonly Func<Group, string?>? GetGroupName =
		(Func<Group, string?>?)typeof(Group).GetProperty("Name")?.GetGetMethod().CreateDelegate(typeof(Func<Group, string?>));

	/// <inheritdoc/>
	public override void GetData(object target, Stream outgoingData)
	{
		if (target is Match match)
		{
			var result = Convert(match);
			SerializeAsJson(outgoingData, result);
		}
	}

	internal static RegexMatch Convert(Match match) =>
		new RegexMatch
		{
			Success = match.Success,
			Index = match.Index,
			Length = match.Length,
			Value = match.Value,
			Captures = Convert(match.Captures),
			Groups = Convert(match.Groups),
		};

	private static RegexCapture[] Convert(CaptureCollection captures) =>
		captures.OfType<Capture>()
			.Select((c, i) => new RegexCapture
			{
				Index = c.Index,
				Length = c.Length,
				Value = c.Value,
				Name = $"[{i}]",
			}).ToArray();

	private static RegexGroup[] Convert(GroupCollection groups) =>
		groups.OfType<Group>()
			.Select((g, i) => new RegexGroup
			{
				Success = g.Success,
				Index = g.Index,
				Length = g.Length,
				Value = g.Value,
				Name = $"[{GetGroupName?.Invoke(g) ?? i.ToString()}]",
				Captures = Convert(g.Captures),
			}).ToArray();
}
