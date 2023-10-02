// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MemoryStreamVisualizer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entrypoint for the VisualStudio.Extensibility extension.
/// </summary>
[VisualStudioContribution]
internal class ExtensionEntrypoint : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
			id: "MemoryStreamVisualizer.97a0a2fb-f163-4fa3-91f0-48a2d4ad9f57",
			version: this.ExtensionAssemblyVersion,
			publisherName: "Microsoft",
			displayName: "MemoryStream Debugger Visualizer"),
	};

	/// <inheritdoc />
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);

		// You can configure dependency injection here by adding services to the serviceCollection.
	}
}
