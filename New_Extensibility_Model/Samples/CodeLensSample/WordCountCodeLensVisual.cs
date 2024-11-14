// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using Microsoft.VisualStudio.Extensibility.UI;

internal class WordCountCodeLensVisual : RemoteUserControl
{
    private readonly WordCountCodeLens wordCountCodeLens;

    public WordCountCodeLensVisual(object? dataContext, WordCountCodeLens wordCountCodeLens)
        : base(dataContext)
    {
        this.wordCountCodeLens = wordCountCodeLens;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        this.wordCountCodeLens.UpdateWordCount();
    }
}
