namespace RuntimeTargetSample;

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
                id: "RuntimeTargetSample.e70fad4f-7d9b-4f06-ae6c-9583811dd956",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Runtime Target Sample",
                description: "Test different .NET targets")
        {
            // DotnetTargetVersions = null,                 // <-- Comment out all options or leave this option to use default value
            // DotnetTargetVersions = [DotnetTarget.Net8],  // <-- Selects a valid value
            // DotnetTargetVersions = ["net6.0"],           // <-- Compilation warning will be raised because the extension is built targeting .NET 8
        },
    };

    /// <inheritdoc />
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);

        // You can configure dependency injection here by adding services to the serviceCollection.
    }
}
