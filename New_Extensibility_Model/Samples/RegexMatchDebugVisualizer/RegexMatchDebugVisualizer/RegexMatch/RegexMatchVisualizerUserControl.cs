// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer;

using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.UI;
using Microsoft.VisualStudio.Gladstone.RegexMatchVisualizer.ObjectSource;
using Newtonsoft.Json.Linq;

/// <summary>
/// Remote user control to visualize the <see cref="Match"/> value.
/// </summary>
internal class RegexMatchVisualizerUserControl : RemoteUserControl
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RegexMatchVisualizerUserControl"/> class.
	/// </summary>
	/// <param name="dataContext">Data context of the remote control.</param>
	public RegexMatchVisualizerUserControl(RegexMatch dataContext)
		: base(dataContext)
	{
	}
}
