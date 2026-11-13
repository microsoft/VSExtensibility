// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ExternalSettingsSample;

using System;

internal sealed class SampleSettingsStore
{
    private readonly object gate = new();
    private string greeting = "Hello from the store";

    public event Action? Changed;

    public string Greeting
    {
        get
        {
            lock (this.gate)
            {
                return this.greeting;
            }
        }
    }

    public void SetGreeting(string value)
    {
        lock (this.gate)
        {
            if (this.greeting == value)
            {
                return;
            }

            this.greeting = value;
        }

        this.Changed?.Invoke();
    }

    public void ChangeGreetingExternally()
    {
        this.SetGreeting(this.Greeting == "Externally updated" ? "Hello from the store" : "Externally updated");
    }
}
