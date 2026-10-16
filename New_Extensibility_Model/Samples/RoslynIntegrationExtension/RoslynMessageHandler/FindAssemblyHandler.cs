// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RoslynMessageHandler;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Extensions;
using Microsoft.CodeAnalysis.FindSymbols;

#pragma warning disable VSEXTPREVIEW_LANGUAGES_QUERY // Roslyn integration is experimental.
#pragma warning disable RSEXPERIMENTAL008 // Roslyn extension message handlers are experimental.

public class FindAssemblyHandler : IExtensionDocumentMessageHandler<FindAssemblyMessage, FindAssemblyResponse>
{
    public async Task<FindAssemblyResponse> ExecuteAsync(FindAssemblyMessage message, ExtensionDocumentMessageContext context, CancellationToken cancellationToken)
    {
        _ = message ?? throw new ArgumentNullException(nameof(message));
        var document = context.TextDocument as Document ?? throw new ArgumentException("A source document is required.", nameof(context));

        var semanticModel = await document.GetSemanticModelAsync(cancellationToken);
        var symbol = await GetSymbolAsync(document, message.Position, cancellationToken);
        var typeSymbol = GetTypeSymbol(symbol);
        var assembly = typeSymbol?.ContainingAssembly;
        var filePath = assembly is null ?
            null :
            (semanticModel?.Compilation.GetMetadataReference(assembly) as PortableExecutableReference)?.FilePath;

        return new(
            typeSymbol?.ToDisplayString(),
            assembly?.Identity.Name,
            assembly?.Identity.Version.ToString(),
            filePath);
    }

    internal static async Task<ISymbol?> GetSymbolAsync(Document document, DocumentPosition documentPosition, CancellationToken cancellationToken)
    {
        var position = await documentPosition.ToPositionAsync(document, cancellationToken);
        return await SymbolFinder.FindSymbolAtPositionAsync(document, position, cancellationToken);
    }

    internal static ITypeSymbol? GetTypeSymbol(ISymbol? symbol)
    {
        return symbol switch
        {
            ILocalSymbol localSymbol => localSymbol.Type,
            IFieldSymbol fieldSymbol => fieldSymbol.Type,
            IPropertySymbol propertySymbol => propertySymbol.Type,
            IParameterSymbol parameterSymbol => parameterSymbol.Type,
            ITypeSymbol typeSymbol => typeSymbol,
            _ => null,
        };
    }
}
