// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

namespace Microsoft.VisualStudio.Gladstone.InsertGuidExtension
{
	using System;
	using System.Diagnostics;
	using System.Globalization;
	using System.Threading;
	using System.Threading.Tasks;
	using Microsoft.VisualStudio.Extensibility;
	using Microsoft.VisualStudio.Extensibility.Commands;
	using Microsoft.VisualStudio.Extensibility.Definitions;

	/// <summary>
	/// Command handler to insert a random guid at the current caret position.
	/// </summary>
	[Command(
		"Microsoft.VisualStudio.InsertGuidExtension.InsertGuidCommand",
		"Insert new guid",
		placement: CommandPlacement.ExtensionsMenu,
		clientContexts: "Editor,Shell")]
	[CommandIcon("OfficeWebExtension", IconSettings.IconAndText)]
	[CommandVisibleWhen("AnyFile", new string[] { "AnyFile" }, new string[] { "ClientContext:Shell.ActiveEditorContentType=.+" })]
	internal class InsertGuidCommand : Command
	{
		private readonly TraceSource logger;

		/// <summary>
		/// Initializes a new instance of the <see cref="InsertGuidCommand"/> class.
		/// </summary>
		/// <param name="extensibility">Extensibility object.</param>
		/// <param name="traceSource">Trace source instance to utilize.</param>
		/// <param name="name">Command identifier.</param>
		public InsertGuidCommand(VisualStudioExtensibility extensibility, TraceSource traceSource, string name)
			: base(extensibility, name)
		{
			this.logger = Requires.NotNull(traceSource, nameof(traceSource));
		}

		/// <inheritdoc />
		/// <remarks>
		/// Get the active text, if there is one replace the selection with a new guid string.
		/// </remarks>
		public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
		{
			Requires.NotNull(context, nameof(context));
			var newGuidString = Guid.NewGuid().ToString("N", CultureInfo.CurrentCulture);

			using var textView = await context.GetActiveTextViewAsync(cancellationToken);
			if (textView is null)
			{
				this.logger.TraceInformation("There was no active text view when command is executed.");
				return;
			}

			var document = await textView.GetTextDocumentAsync(cancellationToken);
			await this.Extensibility.Editor().MutateAsync(
				m =>
				{
					var mutator = m.GetMutator(document);
					mutator.Replace(textView.Selection.Extent, newGuidString);
				},
				cancellationToken);
		}
	}
}
