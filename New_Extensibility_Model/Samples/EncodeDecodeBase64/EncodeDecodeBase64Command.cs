// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace EncodeDecodeBase64;

using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// Command handler to encode or decode a base64 text from the currently selected text.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="EncodeDecodeBase64Command"/> class.
/// </remarks>
/// <param name="traceSource">Trace source instance to utilize.</param>
[VisualStudioContribution]
internal class EncodeDecodeBase64Command(TraceSource traceSource) : Command
{
    private readonly TraceSource logger = traceSource;

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%EncodeDecodeBase64.EncodeDecodeBase64Command.DisplayName%")
    {
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.ConvertPartition, IconSettings.IconAndText),
        VisibleWhen = ActivationConstraint.SolutionState(SolutionState.FullyLoaded),
        EnabledWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveEditorContentType, "csharp"),
    };

    /// <inheritdoc />
    /// <remarks>
    /// Get the active text and replace it by its equivalent in base64 or plain text.
    /// </remarks>
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        using ITextViewSnapshot? textView = await context.GetActiveTextViewAsync(cancellationToken);
        if (textView is null)
        {
            this.logger.TraceInformation("There was no active text view when command is executed.");
            return;
        }

        await this.Extensibility.Editor().EditAsync(
            batch =>
            {
                ITextDocumentEditor textDocumentEditor = textView.Document.AsEditable(batch);

                var selections = textView.Selections;

                for (int i = 0; i < selections.Count; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    var selection = selections[i];
                    if (selection.IsEmpty)
                    {
                        continue;
                    }

                    // For each selection, we will replace the selected text with its base64 or plain text equivalent
                    string newText = this.EncodeOrDecode(selection.Extent.CopyToString());
                    textDocumentEditor.Replace(selection.Extent, newText);
                }
            },
            cancellationToken);
    }

    private string EncodeOrDecode(string text)
    {
        // Try to decode the string, maybe it's Base64?
        Span<byte> buffer = stackalloc byte[text.Length];
        if (Convert.TryFromBase64String(text, buffer, out int bytesWritten))
        {
            return Encoding.UTF8.GetString(buffer.Slice(0, bytesWritten));
        }
        else
        {
            // Seems like the input was not Base64, let's try to encode it to Base64 then.
            byte[] data = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(data);
        }
    }
}
