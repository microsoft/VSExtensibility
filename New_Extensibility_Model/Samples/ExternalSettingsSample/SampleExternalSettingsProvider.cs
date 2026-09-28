// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#pragma warning disable VSEXTPREVIEW_SETTINGS_EXTERNAL // External settings providers are experimental in this SDK.

namespace ExternalSettingsSample;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Settings;

[VisualStudioContribution]
internal sealed class SampleExternalSettingsProvider : ExternalSettingsProvider
{
    private const string GreetingId = "greeting";
    private const string InvalidGreetingMessage = "Enter a greeting of 1 to 24 non-whitespace characters.";
    private readonly SampleSettingsStore store;

    public SampleExternalSettingsProvider(SampleSettingsStore store)
    {
        this.store = store;
        this.store.Changed += this.OnStoreChanged;
    }

    [VisualStudioContribution]
    internal static SettingCategory Category { get; } = new("externalSettingsSample", "%ExternalSettingsSample.Category.DisplayName%")
    {
        Description = "%ExternalSettingsSample.Category.Description%",
    };

    /// <inheritdoc/>
    protected override ExternalSettingsProviderConfiguration ExternalSettingsProviderConfiguration => new(
        "memoryStore",
        "%ExternalSettingsSample.Provider.DisplayName%",
        Category,
        [
            new ExternalSetting.String(GreetingId, "%ExternalSettingsSample.Greeting.DisplayName%")
            {
                Description = "%ExternalSettingsSample.Greeting.Description%",
                GetValue = (identifier, cancellationToken) =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    return Task.FromResult(ExternalSettingOperationResult<string>.Success(this.store.Greeting));
                },
                SetValue = (value, identifier, cancellationToken) =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    if (!IsValid(value))
                    {
                        return Task.FromResult(ExternalSettingOperationResult.Failure(InvalidGreetingMessage, ExternalSettingsErrorScope.SingleSettingOnly, isTransient: false));
                    }

                    this.store.SetGreeting(value);
                    return Task.FromResult(ExternalSettingOperationResult.Success());
                },
                Validate = (value, identifier, cancellationToken) =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    IReadOnlyList<SettingMessage> messages = IsValid(value)
                        ? []
                        : [new SettingMessage(InvalidGreetingMessage) { Severity = SettingMessageSeverity.Error }];
                    return Task.FromResult(messages);
                },
            },
        ])
    {
        Description = "%ExternalSettingsSample.Provider.Description%",
        BackingStoreDescription = "%ExternalSettingsSample.Provider.BackingStoreDescription%",
    };

    /// <inheritdoc/>
    protected override void Dispose(bool isDisposing)
    {
        if (isDisposing)
        {
            this.store.Changed -= this.OnStoreChanged;
        }

        base.Dispose(isDisposing);
    }

    private static bool IsValid(string value) => !string.IsNullOrWhiteSpace(value) && value.Length <= 24;

    private void OnStoreChanged() => this.NotifySettingValuesChanged([GreetingId]);
}
