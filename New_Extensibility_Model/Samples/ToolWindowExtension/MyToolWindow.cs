// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ToolWindowExtension;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.ToolWindows;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

/// <summary>
/// A sample tool window.
/// </summary>
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
	private object? dataContext;

	/// <summary>
	/// Initializes a new instance of the <see cref="MyToolWindow" /> class.
	/// </summary>
	/// <param name="extensibility">
	/// Extensibility object instance.
	/// </param>
	public MyToolWindow(VisualStudioExtensibility extensibility)
		: base(extensibility)
	{
		this.Title = "My Tool Window";
	}

	/// <inheritdoc />
	public override ToolWindowConfiguration ToolWindowConfiguration => new()
	{
		Placement = ToolWindowPlacement.DocumentWell,
	};

	/// <inheritdoc />
	public override Task InitializeAsync(CancellationToken cancellationToken)
	{
		this.dataContext = new MyToolWindowData(this.Extensibility);

		return Task.CompletedTask;
	}

	/// <inheritdoc />
	public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
	{
		return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl(this.dataContext));
	}
}
