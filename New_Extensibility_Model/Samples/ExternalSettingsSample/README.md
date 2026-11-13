# External Settings Sample

This sample demonstrates the experimental `ExternalSettingsProvider` API with one string
setting, **Greeting**, backed by a local in-memory store. It requires the 18.12 SDK.
There is no file, network service, or credential to configure; values reset when the
extension restarts.

Open **Tools > Options**, select **External Settings Sample > Memory Store**, and edit
**Greeting**. The provider reads and writes the store using `GetValue` and `SetValue`.
The `Validate` callback rejects empty, whitespace-only, and longer-than-24-character
values with an error message; `SetValue` also rejects invalid writes.

To observe a change originating outside the settings editor, leave the settings page
open and select **Tools > Change External Settings Sample Greeting**. The command
changes the same store, whose change event causes the provider to call
`NotifySettingValuesChanged` for the greeting. Invoke the command again to toggle
back to the original value. The store and provider are shared within the extension,
and the provider unsubscribes when disposed.

`ExternalSettingsProviderConfiguration` declares the category and setting without
requiring the extension to load just to show their metadata. The
`VSEXTPREVIEW_SETTINGS_EXTERNAL` diagnostic is suppressed only in the provider file
because this SDK marks the external provider API experimental.
