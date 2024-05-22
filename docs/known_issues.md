---
title: Known Issues
description: Known issues with VisualStudio.Extensibility
date: 2024-01-30
---

# Known Issues

This is a list of known issues with VisualStudio.Extensibility. We'll keep this page updated if any fixes or workarounds become available.

## Hot-loading issue when language packs are installed

With Visual Studio 2022 17.9, we've added the ability to publish VisualStudio.Extensibility-based extensions in the Visual Studio Marketplace. Users can then find your extensions in the Marketplace, and they can install them without closing or restarting Visual Studio, which we call "hot-loading".

We've discovered that if you have a Language Pack installed with Visual Studio, hot-loading new extensions won't work. Instead, until we find a fix, you'll need to close and restart Visual Studio after installing your extensions like you would for traditional non-VisualStudio.Extensibility extensions.