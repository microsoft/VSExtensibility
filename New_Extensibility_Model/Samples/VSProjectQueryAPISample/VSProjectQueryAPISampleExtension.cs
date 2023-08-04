// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the DialogSample.
/// </summary>
[VisualStudioContribution]
public class VSProjectQueryAPISampleExtension : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
				id: "VSProjectQueryAPISample.e1fc7832-0ad7-4fc2-bf23-c7c5c6e95047",
				version: this.ExtensionAssemblyVersion,
				publisherName: "Microsoft",
				displayName: "Project Query API Sample Extension"),
	};

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
