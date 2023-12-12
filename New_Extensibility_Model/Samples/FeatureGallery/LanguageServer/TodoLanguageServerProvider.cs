// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.LanguageServer;
#else
namespace FeatureGallery.LanguageServer;

using System;
#endif

using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.LanguageServer;
using Nerdbank.Streams;
using StreamJsonRpc;

/// <inheritdoc/>
[VisualStudioContribution]
#pragma warning disable VSEXTAPI0001 // This API is marked as Preview.
internal class TodoLanguageServerProvider : LanguageServerProvider
{
    /// <inheritdoc/>
    public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration => new(
#if INPROC
        "%InProcFeatureGallery.LanguageServer.TodoLanguageServerProvider.DisplayName%",
#else
        "%FeatureGallery.LanguageServer.TodoLanguageServerProvider.DisplayName%",
#endif
        [DocumentFilter.FromDocumentType(LanguageServerTest.TodosDocumentType)]);

    /// <inheritdoc/>
    public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
    {
        var streams = FullDuplexStream.CreatePair();

        JsonRpc rpc = new(streams.Item2);
        rpc.AddLocalRpcTarget(new LanguageServer(rpc));
        rpc.StartListening();

        return Task.FromResult<IDuplexPipe?>(new DuplexPipe(
                PipeReader.Create(streams.Item1),
                PipeWriter.Create(streams.Item1)));
    }
}
#pragma warning restore VSEXTAPI0001 // This API is marked as Preview.
