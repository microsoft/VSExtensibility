// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if INPROC
namespace InProcFeatureGallery.LanguageServer;
#else
namespace FeatureGallery.LanguageServer;
#endif

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Newtonsoft.Json.Linq;
using StreamJsonRpc;
using System.Threading;
using System.Linq;

#pragma warning disable IDE0060, CA1801 // Remove unused parameter
internal class LanguageServer
{
    private static readonly Regex TodoRegex = new(@"TODO:\s*(.+)$", RegexOptions.Compiled);
    private readonly JsonRpc rpc;

    public LanguageServer(JsonRpc rpc)
    {
        this.rpc = rpc;
    }

    [JsonRpcMethod(Methods.InitializeName)]
    public InitializeResult Initialize(JToken arg)
    {
        return new()
        {
            Capabilities = new()
            {
                TextDocumentSync = new()
                {
                    OpenClose = true,
                    Change = TextDocumentSyncKind.Full,
                },
            },
        };
    }

    [JsonRpcMethod(Methods.TextDocumentDidOpenName, UseSingleObjectParameterDeserialization = true)]
    public async Task OnTextDocumentOpenedAsync(DidOpenTextDocumentParams messageParams, CancellationToken cancellationToken)
    {
        await this.VerifyDocumentAsync(messageParams.TextDocument.Uri, messageParams.TextDocument.Text);
    }

    [JsonRpcMethod(Methods.TextDocumentDidChangeName, UseSingleObjectParameterDeserialization = true)]
    public async Task OnTextDocumentChangedAsync(DidChangeTextDocumentParams messageParams, CancellationToken cancellationToken)
    {
        await this.VerifyDocumentAsync(messageParams.TextDocument.Uri, messageParams.ContentChanges.Single().Text);
    }

    [JsonRpcMethod(Methods.TextDocumentDidCloseName, UseSingleObjectParameterDeserialization = true)]
    public async Task OnTextDocumentClosedAsync(DidCloseTextDocumentParams messageParams, CancellationToken cancellationToken)
    {
        PublishDiagnosticParams notificationParams = new() { Uri = messageParams.TextDocument.Uri, Diagnostics = Array.Empty<Diagnostic>() };
        await this.rpc.NotifyWithParameterObjectAsync(Methods.TextDocumentPublishDiagnosticsName, notificationParams);
    }

    private async Task VerifyDocumentAsync(Uri uri, string text)
    {
        List<Diagnostic> diagnostics = new();

        using StringReader reader = new(text);
        string? line;
        for (int lineCounter = 0;
            (line = await reader.ReadLineAsync()) != null;
            lineCounter++)
        {
            var match = TodoRegex.Match(line);
            if (match.Success)
            {
                var group = match.Groups[1];

                diagnostics.Add(new()
                {
                    Severity = DiagnosticSeverity.Error,
                    Code = "TODO",
#if INPROC
                    Source = "In-proc TODO Language Server",
#else
                    Source = "TODO Language Server",
#endif
                    Message = group.Value,
                    Range = new()
                    {
                        Start = new()
                        {
                            Line = lineCounter,
                            Character = group.Index,
                        },
                        End = new()
                        {
                            Line = lineCounter,
                            Character = group.Index + group.Length,
                        },
                    },
                });
            }
        }

        PublishDiagnosticParams notificationParams = new() { Uri = uri, Diagnostics = diagnostics.ToArray() };
        await this.rpc.NotifyWithParameterObjectAsync(Methods.TextDocumentPublishDiagnosticsName, notificationParams);
    }
}
