---
title: Known Issues
description: Known issues with VisualStudio.Extensibility
date: 2024-01-30
---

# Known Issues

This is a list of known issues with VisualStudio.Extensibility. We'll keep this page updated if any fixes or workarounds become available.

## Out-of-process extensions won't install on ARM64 machines

We've found a bug that prevents fully out-of-process VisualStudio.Extensibility extensions from installing on ARM64 systems. In the meantime, you could structure your extension as an [in-proc/VSSDK-compatible extension](https://learn.microsoft.com/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions) if you need ARM64 compatability.

We will share updates on a fix once we have one available.

*Last updated on 29-May-2024*

## Hot-loading issue when language packs are installed

With Visual Studio 2022 17.9, we've added the ability to publish VisualStudio.Extensibility-based extensions in the Visual Studio Marketplace. Users can then find your extensions in the Marketplace, and they can install them without closing or restarting Visual Studio, which we call "hot-loading".

We've discovered that if you have a Language Pack installed with Visual Studio, hot-loading new extensions won't work. Instead, until we release a fix, you'll need to close and restart Visual Studio after installing your extensions like you would for traditional non-VisualStudio.Extensibility extensions.

**This issue is now fixed with Visual Studio 17.11 release.**

*Last updated on 05-September-2024*