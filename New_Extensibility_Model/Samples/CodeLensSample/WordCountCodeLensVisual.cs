// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CodeLensSample;

using Microsoft.VisualStudio.Extensibility.UI;

internal class WordCountCodeLensVisual : RemoteUserControl
{
    public WordCountCodeLensVisual(object? dataContext)
        : base(dataContext)
    {
    }
}
