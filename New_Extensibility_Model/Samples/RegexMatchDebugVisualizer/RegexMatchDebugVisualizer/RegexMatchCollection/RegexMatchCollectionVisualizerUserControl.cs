﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RegexMatchVisualizer;

using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.Extensibility.UI;
using RegexMatchVisualizer.ObjectSource;

/// <summary>
/// Remote user control to visualize the <see cref="Match"/> value.
/// </summary>
internal class RegexMatchCollectionVisualizerUserControl : RemoteUserControl
{
    private readonly VisualizerTarget visualizerTarget;

    /// <summary>
    /// Initializes a new instance of the <see cref="RegexMatchCollectionVisualizerUserControl"/> class.
    /// </summary>
    /// <param name="visualizerTarget"><see cref="VisualizerTarget"/> to which the control will request data.</param>
    public RegexMatchCollectionVisualizerUserControl(VisualizerTarget visualizerTarget)
        : base(new ObservableCollection<RegexMatch>())
    {
        this.visualizerTarget = visualizerTarget;
    }

    private ObservableCollection<RegexMatch> RegexMatches => (ObservableCollection<RegexMatch>)this.DataContext!;

    /// <inheritdoc/>
    public override Task ControlLoadedAsync(CancellationToken cancellationToken)
    {
        _ = Task.Run(async () =>
        {
            for (int i = 0; ; i++)
            {
                RegexMatch? regexMatch = await this.visualizerTarget.ObjectSource.RequestDataAsync<int, RegexMatch?>(message: i, jsonSerializer: null, CancellationToken.None);
                if (regexMatch is null)
                {
                    break;
                }

                this.RegexMatches.Add(regexMatch);
            }
        });

        return Task.CompletedTask;
    }
}
