namespace CommentRemover;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

[HostingOptions(requiresInProcessHosting: true)]
public class CommentRemoverExtension : Extension
{
	protected override void InitializeServices(IServiceCollection serviceCollection)
	{
		base.InitializeServices(serviceCollection);
	}
}
