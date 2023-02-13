---
title: Documents reference
description: An overview of extensibility documents
date: 2023-2-10
author: maiak
ms.author: maiak
ms.technology: vs-ide-sdk
ms.topic: overview
ms.date: 02/10/2023
ms.custom: template-overview
---

# Documents Overview

TODO: Add a high-level description of the domain, especially how it relates to the editor. Please write or link to relevant conceptual content across either domain.

# Work with documents

This guide is designed to cover the top user scenarios when working with documents:

- [Enumerate open documents](#enumerate-open-documents)
- [Get a text document snapshot](#get-a-text-document-snapshot)
- [React to events related to documents](#react-to-events-related-to-documents)

## 1. Enumerate open documents

TODO: Add a description of this scenario. Describe the DocumentsExtensibility object and the difference between a Document and a TextDocument if not described earlier.

```csharp
DocumentsExtensibility documents = this.Extensibility.Documents();
IReadOnlyList<DocumentSnapshot> openDocs = await documents.GetOpenDocumentsAsync(cancellationToken);

foreach (DocumentSnapshot document in openDocs)
{
    // do something with the document
}
```

## 2. Get a text document snapshot

TODO: Add a description of this scenario.

```csharp
public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    DocumentsExtensibility documents = this.Extensibility.Documents();

    Uri moniker = await context.GetSelectedPathAsync(cancellationToken);
    DocumentSnapshot document = await documents.GetDocumentAsync(moniker, cancellationToken);
    ITextDocumentSnapshot snapshot = document.AsTextDocumentAsync(cancellationToken);

    // do something with the snapshot; see <insert link>
}
```

## 3. React to events related to documents

TODO: Add a description of this scenario.

```csharp
internal sealed class SubscribeCommand : Command, IToggleCommand, IDocumentEventListener
{
    private IDisposable? subscription;

    bool? IToggleCommand.IsChecked => this.subscription is not null;

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        if (this.subscription is null)
        {
            // subscribe for events
            DocumentsExtensibility documents = this.Extensibility.Documents();
            this.subscription = await documents.SubscribeAsync(
                listener: this,
                filterRegex: null,
                openDocuments: out DocumentSnapshot[] _,
                cancellationToken);
        }
        else
        {
            // remove the event subscription
            this.subscription.Dispose();
            this.subscription = null;
        }

        this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(IToggleCommand.IsChecked)));
    }

    Task IDocumentEventListener.ClosedAsync(DocumentEventArgs e, CancellationToken token)
    {
        // react to the given document being closed
    }
}
```

# Next steps

- Follow the [create the project](../getting-started/create-your-first-extension.md) section in Getting Started section.
TODO: link to relevant samples (do we have a sample for this?) and documents.