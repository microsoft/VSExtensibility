namespace CommandParentingSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Definitions;

[Command("CommandParentingSample.SampleCommand", "My Command")]
internal class SampleCommand : Command
{
	public SampleCommand(VisualStudioExtensibility extensibility, string id)
		: base(extensibility, id)
	{
	}

	public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}
}
