// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Editor;

internal class ClickableCodeLens : InvokableCodeLens
{
    private readonly CodeElement codeElement;
    private readonly VisualStudioExtensibility extensibility;
    private int clickCount;

    public ClickableCodeLens(CodeElement codeElement, VisualStudioExtensibility extensibility)
    {
        this.codeElement = codeElement;
        this.extensibility = extensibility;
    }

    public override void Dispose()
    {
    }

    public override Task ExecuteAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken cancelToken)
    {
        this.clickCount++;
        this.Invalidate();
        return Task.CompletedTask;
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        return Task.FromResult(new CodeLensLabel()
        {
            Text = this.clickCount == 0 ? "Click me" : $"Clicked {this.clickCount} times",
            Tooltip = "Invokable CodeLens Sample Tooltip",
        });
    }
}
