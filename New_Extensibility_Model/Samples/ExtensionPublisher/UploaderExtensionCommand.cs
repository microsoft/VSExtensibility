// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExtensionPublisher;

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Shell;

[VisualStudioContribution]
public class UploaderExtensionCommand : Command
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UploaderExtensionCommand"/> class.
    /// </summary>
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%ExtensionPublisher.UploaderExtensionCommand.DisplayName%")
    {
        // Use this object initializer to set optional parameters for the command. The required parameter,
        // displayName, is set above. DisplayName is localized and references an entry in .vsextension\string-resources.json.
        Icon = new(ImageMoniker.KnownValues.Favorite, IconSettings.IconAndText),
        Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
        VisibleWhen = ActivationConstraint.SolutionState(SolutionState.FullyLoaded),
    };

    /// <inheritdoc />
    public override async Task ExecuteCommandAsync(IClientContext clientContext, CancellationToken cancellationToken)
    {
        DataBinding dataBinding = new DataBinding(this.Extensibility);
        try
        {
            await dataBinding.InitializeAsync(clientContext, cancellationToken);
        }
        catch
        {
            await this.Extensibility.Shell().ShowPromptAsync(
                "Cannot find the TargetVsixContainer property for the selected project.\n" +
                "Make sure the selected project is a Visual Studio Extension and it was successfully built.",
                PromptOptions.OK,
                cancellationToken);
            return;
        }

        var control = new MyToolWindowContent(dataBinding);

        await this.Extensibility.Shell().ShowDialogAsync(control, "Extension Publisher",  cancellationToken);
    }
}
