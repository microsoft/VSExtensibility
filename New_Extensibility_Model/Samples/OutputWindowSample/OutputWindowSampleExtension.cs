// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutputWindowSample;

using System.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the OutputWindowSampleExtension.
/// </summary>
[VisualStudioContribution]
public class OutputWindowSampleExtension : Extension
{
	/// <inheritdoc />
	protected override ResourceManager? ResourceManager => Strings.ResourceManager;

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
