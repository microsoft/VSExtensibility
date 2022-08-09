// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

using System.Resources;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the OutputWindowSampleExtension.
/// </summary>
public class OutputWindowSampleExtension : Extension
{
	/// <inheritdoc />
	protected override ResourceManager? ResourceManager => Strings.ResourceManager;
}
