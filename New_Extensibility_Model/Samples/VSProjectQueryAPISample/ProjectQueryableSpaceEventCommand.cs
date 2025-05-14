// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace VSProjectQueryAPISample
{
    using System.Diagnostics;
    using Microsoft;
    using Microsoft.ServiceHub.Framework;
    using Microsoft.VisualStudio.Extensibility;
    using Microsoft.VisualStudio.Extensibility.Commands;
    using Microsoft.VisualStudio.Extensibility.Shell;
    using Microsoft.VisualStudio.ProjectSystem.Query;

    [VisualStudioContribution]
    internal class ProjectQueryableSpaceEventCommand : Command
    {
        private readonly TraceSource logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectQueryableSpaceEventCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public ProjectQueryableSpaceEventCommand(TraceSource traceSource)
        {
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: "%VSProjectQueryAPISample.SubscribeQS.DisplayName%")
        {
            Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
        };

        /// <inheritdoc />
        public override Task InitializeAsync(CancellationToken cancellationToken)
        {
            return base.InitializeAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
        {
            IServiceBroker serviceBroker = context.Extensibility.ServiceBroker;
            ProjectQueryableSpace workspace = new(serviceBroker: serviceBroker, joinableTaskContext: null);
            workspace.QueryableSpaceChanged += this.EventCalledAsync;

            await this.Extensibility.Shell().ShowPromptAsync($"Project Queryable Space Changed Event subscribed.", PromptOptions.OK, CancellationToken.None);
        }

        private Task EventCalledAsync(ProjectQueryableSpaceChangedEventArgs e)
        {
            var solutionPath = e.SolutionPath;
            var version = e.QueryableSpaceVersion;
            return this.Extensibility.Shell().ShowPromptAsync($"Project queryable space changed. Solution path is \"{solutionPath}\", queryable space version is {version}", PromptOptions.OK, CancellationToken.None);
        }
    }
}
