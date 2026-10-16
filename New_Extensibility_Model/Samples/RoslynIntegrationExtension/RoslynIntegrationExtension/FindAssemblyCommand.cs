// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynIntegrationExtension;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;
using Microsoft.VisualStudio.RpcContracts.Notifications;
using RoslynMessageHandler;

#pragma warning disable VSEXTPREVIEW_LANGUAGES_QUERY // Roslyn integration is experimental.

[VisualStudioContribution]
internal class FindAssemblyCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%RoslynIntegrationExtension.FindAssemblyCommand.DisplayName%")
    {
        Placements =
        [
            CommandPlacement.KnownPlacements.ExtensionsMenu,

            // Editor context menu, navigation group.
            CommandPlacement.VsctParent(new Guid(0xd309f791, 0x903f, 0x11d0, 0x9e, 0xfc, 0x00, 0xa0, 0xc9, 0x11, 0x00, 0x4f), 0x02B1, 0x1000),
        ],
        Icon = new(ImageMoniker.KnownValues.Assembly, IconSettings.IconAndText),
        VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.cs$"),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(context);

        using var textView = await context.GetActiveTextViewAsync(cancellationToken);
        if (textView is null)
        {
            await this.Extensibility.Shell().ShowPromptAsync("No active text view is available.", PromptOptions.OK, cancellationToken);
            return;
        }

        try
        {
            FindAssemblyMessage message = new(textView.Selection.ActivePosition.ToDocumentPosition());
            var response = await this.Extensibility.Languages().CSharp().QueryAsync<FindAssemblyHandler, FindAssemblyMessage, FindAssemblyResponse>(
                message, textView.Document, cancellationToken);

            if (response.SymbolType is not null)
            {
                using var popup = new AssemblyInfoPopup(response);
                await this.Extensibility.Shell().ShowDialogAsync(popup, "Find Assembly from Symbol", DialogOption.OK, cancellationToken);
            }
            else
            {
                await this.Extensibility.Shell().ShowPromptAsync("Unable to identify a supported symbol under the caret.", PromptOptions.OK, cancellationToken);
            }
        }
        catch (Exception ex) when (ex is not OperationCanceledException)
        {
            await this.Extensibility.Shell().ShowPromptAsync($"Error when sending a message to Roslyn:{Environment.NewLine}{ex}", PromptOptions.OK, cancellationToken);
            throw;
        }
    }
}
