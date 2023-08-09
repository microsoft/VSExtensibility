namespace CommentRemover;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

[VisualStudioContribution]
public class CommentRemoverExtension : Extension
{
	public override ExtensionConfiguration? ExtensionConfiguration => new() { RequiresInProcessHosting = true };

	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
