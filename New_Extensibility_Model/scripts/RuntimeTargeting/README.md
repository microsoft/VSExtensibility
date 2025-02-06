# .NET Runtime Targeting

The function of these scripts is to enable testing of the .NET runtime targeting features, which were introduced for VisualStudio.Extensibility extensions in 17.14. This new set of features allows developers to specify which .NET runtimes their extension is compatible with, and to explicitly choose the .NET runtime that will host their extension when debugging with Visual Studio.

However, as of the 17.14 release the only supported LTS version of .NET is .NET 8. In order to give developers the chance to use these new features with multiple runtimes, these scripts are provided as a short-term option to test using .NET 9 in lieu of .NET 10.

Please note that this is *not* a supported a scenario and is only for testing and exploration purposes, and that once .NET 10 is publicly released these scripts will be retired.
