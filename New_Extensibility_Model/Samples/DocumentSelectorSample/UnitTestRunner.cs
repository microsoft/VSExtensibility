// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentSelectorSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Documents;
using Microsoft.VisualStudio.Extensibility.Editor;

/// <summary>
/// A sample demonstrating how to define an editor extension that is only applicable to files matching a file path pattern.
/// This text view event listener monitors users opening/modifying/closing C# files in "tests" folder and emulates running
/// unit tests in these files.
/// </summary>
#pragma warning disable VSEXTPREVIEW_OUTPUTWINDOW // Type is for evaluation purposes only and is subject to change or removal in future updates.
[VisualStudioContribution]
internal class UnitTestRunner : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
    private readonly TextViewChangesAggregator textViewChangesAggregator;
    private OutputChannel? outputChannel;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitTestRunner"/> class.
    /// </summary>
    /// <param name="extension">Extension instance.</param>
    /// <param name="extensibility">Extensibility object.</param>
    public UnitTestRunner(Extension extension, VisualStudioExtensibility extensibility)
        : base(extension, extensibility)
    {
        this.textViewChangesAggregator = new((beforeTextView, afterTextView, cancellationToken) => this.RunUnitTestsAfterDelayAsync(afterTextView, cancellationToken));
    }

    /// <inheritdoc />
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromGlobPattern("**/tests/*.cs", relativePath: false)],
    };

    /// <inheritdoc />
    public Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        return this.textViewChangesAggregator.TextViewChangedAsync(args, cancellationToken);
    }

    /// <inheritdoc />
    public Task TextViewOpenedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        return this.RunUnitTestsAfterDelayAsync(textViewSnapshot, cancellationToken);
    }

    /// <inheritdoc />
    public Task TextViewClosedAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        return this.StopUnitTestsAsync(textViewSnapshot, cancellationToken);
    }

    /// <inheritdoc />
    protected override void Dispose(bool isDisposing)
    {
        base.Dispose(isDisposing);
        if (isDisposing)
        {
            this.outputChannel?.Dispose();
            this.textViewChangesAggregator.Dispose();
        }
    }

    private async Task RunUnitTestsAfterDelayAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        await Task.Delay(500, cancellationToken);
        await this.WriteToOutputWindowAsync($"Running unit tests in {textViewSnapshot.Document.Uri.LocalPath}", cancellationToken);
    }

    private async Task StopUnitTestsAsync(ITextViewSnapshot textViewSnapshot, CancellationToken cancellationToken)
    {
        await this.WriteToOutputWindowAsync($"Stop running unit tests in {textViewSnapshot.Document.Uri.LocalPath}", cancellationToken);
    }

    private async Task WriteToOutputWindowAsync(string message, CancellationToken cancellationToken)
    {
        this.outputChannel ??= await this.Extensibility.Views().Output.CreateOutputChannelAsync(
                    Resources.OutputWindowPaneName,
                    cancellationToken);
        await this.outputChannel.WriteLineAsync(message);
    }
}
#pragma warning restore VSEXTPREVIEW_OUTPUTWINDOW // Type is for evaluation purposes only and is subject to change or removal in future updates.
