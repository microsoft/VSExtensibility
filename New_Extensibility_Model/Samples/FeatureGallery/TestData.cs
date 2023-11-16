// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace FeatureGallery;

using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.UI;

[DataContract]
internal abstract class TestData
{
    public TestData(VisualStudioExtensibility extensibility)
    {
        this.Extensibility = extensibility;
        this.Command = new AsyncCommand((_, cc, ct) => this.RunAsync(cc, ct));
    }

    [DataMember]
    public abstract string ButtonText { get; }

    [DataMember]
    public abstract string Description { get; }

    [DataMember]
    public IAsyncCommand Command { get; }

    protected VisualStudioExtensibility Extensibility { get; }

    protected abstract Task RunAsync(IClientContext clientContext, CancellationToken cancellationToken);
}
