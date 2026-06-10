// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MultiTargetedHybridExtension;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;

/// <summary>
/// Command1 handler.
/// </summary>
[VisualStudioContribution]
internal class Command1 : Command
{
    private readonly TraceSource logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="Command1"/> class.
    /// </summary>
    /// <param name="traceSource">Trace source instance to utilize.</param>
    public Command1(TraceSource traceSource)
    {
        // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
        // other services here as well.
        this.logger = Requires.NotNull(traceSource, nameof(traceSource));
    }

    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new(displayName: "Command1")
    {
        // Use this object initializer to set optional parameters for the command. The required parameter,
        // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
        // and reference it here by passing "%MultiTargetedHybridExtension.Command1.DisplayName%" as a constructor parameter.
        Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
        Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    };

    /// <inheritdoc />
    public override Task InitializeAsync(CancellationToken cancellationToken)
    {
        // Use InitializeAsync for any one-time setup or initialization.
        return base.InitializeAsync(cancellationToken);
    }

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
#if VS_180_OR_GREATER
        string message = "Hello World from VS (18.5 or greater)!";
#else
        string message = "Hello World from VS!";
#endif
        await this.Extensibility.Shell().ShowPromptAsync(message, PromptOptions.OK, cancellationToken);
    }
}
