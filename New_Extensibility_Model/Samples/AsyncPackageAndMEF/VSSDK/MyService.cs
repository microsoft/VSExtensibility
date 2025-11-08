// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AsyncPackageAndMEF;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Shell;

internal class MyService
{
    internal Task SayHelloAsync(VisualStudioExtensibility extensibility, CancellationToken cancellationToken)
        => extensibility.Shell().ShowPromptAsync("Hello from a VS service!", PromptOptions.OK, cancellationToken);
}
