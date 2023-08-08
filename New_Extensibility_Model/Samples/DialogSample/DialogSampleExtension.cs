// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DialogSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the DialogSample.
/// </summary>
[VisualStudioContribution]
public class DialogSampleExtension : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
				id: "DialogSampleExtension.8709efb4-fe22-4848-8533-594f444861a1",
				version: this.ExtensionAssemblyVersion,
				publisherName: "Microsoft",
				displayName: "Dialog Sample Extension"),
	};

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
