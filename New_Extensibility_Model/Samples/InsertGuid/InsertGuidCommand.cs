// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace InsertGuid;

using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;

/// <summary>
/// Command handler to insert a random guid at the current caret position.
/// </summary>
[VisualStudioContribution]
internal class InsertGuidCommand : Command
{
    private readonly TraceSource logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="InsertGuidCommand"/> class.
    /// </summary>
    /// <param name="traceSource">Trace source instance to utilize.</param>
    public InsertGuidCommand(TraceSource traceSource)
    {
        this.logger = Requires.NotNull(traceSource, nameof(traceSource));
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%InsertGuid.InsertGuidCommand.DisplayName%")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
        Icon = new(ImageMoniker.KnownValues.OfficeWebExtension, IconSettings.IconAndText),
        VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, ".+"),
        ClientContexts = new[] { "Editor", "Shell" },
    };

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

        await this.Extensibility.Editor().EditAsync(
            batch =>
            {
                textView.Document.AsEditable(batch).Replace(textView.Selection.Extent, newGuidString);
            },
            cancellationToken);
    }
}
