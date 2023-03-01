// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WordCountMarginSample;

using Microsoft.VisualStudio.Extensibility.UI;

/// <summary>
/// A sample remote user control to use as the margin content.
/// </summary>
internal class MyMarginContent : RemoteUserControl
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MyMarginContent" /> class.
	/// </summary>
	/// <param name="dataContext">
	/// Data context of the remote control which can be referenced from xaml through data binding.
	/// </param>
	public MyMarginContent(object? dataContext)
		: base(dataContext)
	{
	}
}
