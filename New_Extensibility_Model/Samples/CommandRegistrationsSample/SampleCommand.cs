// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

namespace SampleCommandExtension
{
	using System.Globalization;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;

	/// <summary>
	/// Sample command handler.
	/// </summary>
	[Command("Microsoft.VisualStudio.MyExtension.SampleRemoteCommand2", "Executed 0 times", placement: CommandPlacement.ToolsMenu)]
	[CommandIcon("MyIcon", IconSettings.IconAndText)]
	internal class SampleCommand : Command
	{
		private const string DisplayNameFormat = "Executed {0} times";
		private readonly object syncLock = new object();

		private int executedCount = 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="SampleCommand"/> class.
		/// </summary>
		/// <param name="extensibility">Extensibility object.</param>
		/// <param name="name">Command name.</param>
		public SampleCommand(VisualStudioExtensibility extensibility, string name)
			: base(extensibility, name)
		{
		}

		/// <inheritdoc />
		public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			lock (this.syncLock)
			{
				this.executedCount++;
				this.DisplayName = string.Format(CultureInfo.CurrentCulture, DisplayNameFormat, this.executedCount.ToString(CultureInfo.CurrentCulture));
			}

			return Task.CompletedTask;
		}
	}
}
