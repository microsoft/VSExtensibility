// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery;
#else
namespace FeatureGallery;
#endif

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

#pragma warning disable VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

internal class MarkdownCodeLens : InvokableCodeLens
{
    private readonly CodeElement codeElement;

    public MarkdownCodeLens(CodeElement codeElement)
    {
        this.codeElement = codeElement;
    }

    public override void Dispose()
    {
    }

    public override Task ExecuteAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken cancelToken)
    {
        TaskCompletionSource<bool> taskCompletionSource = new();
        var thread = new Thread(() =>
        {
            try
            {
                Clipboard.SetText(this.codeElement.UniqueIdentifier ?? "Unknown identifier");
                taskCompletionSource.SetResult(false);
            }
            catch (Exception e)
            {
                taskCompletionSource.SetException(e);
            }
        });

        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();

        return taskCompletionSource.Task;
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        return Task.FromResult(new CodeLensLabel()
        {
            Text = this.codeElement.UniqueIdentifier ?? "Unknown identifier",
            Tooltip = "Unique identifier of this section, click to copy the identifier to the clipboard",
        });
    }
}

#pragma warning restore VSEXTPREVIEW_CODELENS // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
