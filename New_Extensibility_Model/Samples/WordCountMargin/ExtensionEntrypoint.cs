// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WordCountMarginSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// <summary>
/// Extension entry point for the WordCountMarginSample.
/// </summary>
[VisualStudioContribution]
internal class WordCountMarginSampleExtension : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
				id: "WordCountMarginSample.9d845a9e-a3a9-4efe-97f9-002a3945f9f5",
				version: this.ExtensionAssemblyVersion,
				publisherName: "Microsoft",
				displayName: "Word Count Margin Sample Extension",
				description: "Sample extension demonstrating custom margins"),
	};

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
