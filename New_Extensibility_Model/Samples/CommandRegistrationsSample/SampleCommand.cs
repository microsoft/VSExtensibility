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

	[Command("Microsoft.VisualStudio.MyExtension.SampleRemoteCommand2", CommandId, "Executed 0 times", placement: KnownCommandPlacement.ToolsMenu)]
	[CommandIcon("AddItem", IconSettings.IconAndText)]
	internal class SampleCommand2 : Command
	{
		private const int CommandId = 2;
		private const string DisplayNameFormat = "Executed {0} times";
		private readonly object syncLock = new object();

		private int executedCount = 0;

		public SampleCommand2(VisualStudioExtensibility extensibility, ushort id)
			: base(extensibility, id)
		{
		}

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
