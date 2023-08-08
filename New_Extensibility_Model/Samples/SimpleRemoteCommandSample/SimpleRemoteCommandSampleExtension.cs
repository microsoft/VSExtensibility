// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SimpleRemoteCommandSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the SimpleRemoteCommandSample.
/// </summary>
[VisualStudioContribution]
public class SimpleRemoteCommandSampleExtension : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
				id: "SimpleRemoteCommandSample.585f62b4-1416-4ed4-a7e8-2d9b2f37f01e",
				version: this.ExtensionAssemblyVersion,
				publisherName: "Microsoft",
				displayName: "Simple Remote Command Sample Extension"),
	};

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
