---
title: Known Issues
description: Known issues with VisualStudio.Extensibility
date: 2024-01-30
---

# Known Issues

This page keeps a short record of issues that were previously known in VisualStudio.Extensibility and the releases that fixed them. Current issues, when identified, will be added here.

## Historical issue: out-of-process extensions on ARM64

Older VisualStudio.Extensibility builds prevented fully out-of-process extensions from installing on ARM64 systems. If you needed ARM64 compatibility before the fix, you could structure your extension as an [in-proc/VSSDK-compatible extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions).

This issue was fixed in Visual Studio 17.12.

*Last updated on 09-September-2024*

## Historical issue: hot-loading with language packs

Older Visual Studio 2022 17.9 builds had a hot-loading issue when a language pack was installed. Instead of installing without restarting Visual Studio, the extension needed a restart.

This issue was fixed in Visual Studio 17.11.

*Last updated on 10-25-2024*