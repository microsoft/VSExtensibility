// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace UserPromptSample;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

/// <summary>
/// Extension entry point for the UserPromptSample.
/// </summary>
[VisualStudioContribution]
public class UserPromptSampleExtension : Extension
{
	/// <inheritdoc/>
	public override ExtensionConfiguration ExtensionConfiguration => new()
	{
		Metadata = new(
				id: "UserPromptSample.5948e29e-4d51-4b7a-91e4-e574ee4f3ccd",
				version: this.ExtensionAssemblyVersion,
				publisherName: "Microsoft",
				displayName: "User Prompt Sample Extension"),
	};

	/// <inheritdoc/>
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
