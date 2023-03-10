# How to upgrade NuGet dependencies in Microsoft OSS repos?

Many Microsoft OSS repos have nuget.config files that point to public feeds in one or more Azure DevOps accounts.
Depending on how a given repo and its feed sources are configured, an OSS contributor that is adding or updating a NuGet dependency may get a 401 error during the add/update/restore process.
This document outlines how that OSS contributor can workaround the issue and contribute a PR successfully.

To be clear, it is important to us that our OSS repos be buildable by external users.
Running nuget restore on any of our OSS repos without any changes made locally should Just Work.

Certain changes you may make to the nuget dependencies is where you can hit 401 errors, and the intent of this document is to get you unblocked.

## The symptom

First let's review what leads up to the problem.

These are the changes that you might make in one of our repos that we anticipate may present the issue:

1. Adding a `PackageReference`
1. Changing a `PackageReference`
1. Changing a `PackageVersion`

Note that these changes might be from direct changing of the xml in our msbuild files, or through some gesture in an IDE, or through a CLI command that manipulates nuget package references or versions.

The failure may be observed either during an automated operation that makes any of the above changes, or during a subsequent nuget restore operation.

The error will look something like this:

> C:\Program Files\dotnet\sdk\7.0.103\NuGet.targets(132,5): error : Failed to download package 'Nerdbank.GitVersioning.3.6.79-alpha' from 'https://pkgs.dev.azure.com/azure-public/3ccf6661-f8ce-4e8a-bb2e-eff943ddd3c7/_packaging/36a629e1-6c5b-4bcd-aa2e-6018802d6b99/nuget/v3/flat2/nerdbank.gitversioning/3.6.79-alpha/nerdbank.gitversioning.3.6.79-alpha.nupkg'. [C:\Users\andarno\source\repos\Library.Template\Library.sln]
>
> C:\Program Files\dotnet\sdk\7.0.103\NuGet.targets(132,5): **error : Response status code does not indicate success: 401 (Unauthorized - No local versions of package 'nerdbank.gitversioning'; please provide authentication to access versions from upstream that have not yet been saved to your feed.** (DevOps Activity ID: 8D41B3A3-E551-4F6C-BEFA-10C758EA8093)). [C:\Users\andarno\source\repos\Library.Template\Library.sln]
>
> C:\Program Files\dotnet\sdk\7.0.103\NuGet.targets(132,5): error : Restore canceled! [C:\Users\andarno\source\repos\Library.Template\Library.sln]

Note the bolded portion, but you can disregard the particular package id used in that sample.

When you see this, it means the restore operation cannot find the version of the package you requested in one of our Azure Artifact public feeds.
This document will help get you unblocked.

## The mitigation

There are several possible mitigations, which are enumerated below.
The high-level solution that they all have in common is to get the package version you requested into your local package cache.
This will allow nuget restore in the repo to succeed.
You can then continue to build, develop, and test your changes and (at your option) send a pull request to our repo with your changes (and thank you!).
When your pull request is merged into our repo, the package dependency you introduced is added to our Azure Artifacts feed so that you and others will see restore Just Work without extra steps.

All these mitigations assume you have access to the package of interest through nuget.org.

Each sub-section below outlines steps you can take to get unblocked.
It is only necessary to follow the steps in _one_ of the subsections.

### Populate your local package cache via another repo

In some temporary, empty directory on your machine (that is *not* within our repo), run these commands:

```
dotnet new classlib
dotnet new nugetconfig
dotnet add package <packageId> -v <packageVersion>
```

This will populate your local nuget package cache with the exact package version you need.
You can now delete this temporary directory.

Running restore in the Microsoft OSS repo should now be able to find that package.

### Modify nuget.config within your clone of the Microsoft repo

If the `nuget.config` file found at the root of the repo does not have nuget.org listed as a feed source, add it:

```xml
<add key="nuget" value="https://api.nuget.org/v3/index.json" />
```

You should *not* commit this change as it will not be necessary for your pull request to build successfully and merge.
Changes to nuget.config that are included in your pull request will likely need to be reverted and delay merging of your changes.

If the `nuget.config` file has a `<packageSourceMapping>` element inside it, you may need to add a section to it so nuget restore is willing to restore your package from nuget.org.
You can learn more about [package source mappings](https://learn.microsoft.com/nuget/consume-packages/package-source-mapping) in our docs.

For example, if you added nuget.org as a feed source yourself, you should add it to the mapping, along with the ID of the package you are changing:

```diff
  <packageSourceMapping>
    <packageSource key="test-tools">
      <package pattern="Microsoft.CodeCoverage" />
    </packageSource>
+   <packageSource key="nuget">
+     <package pattern="Nerdbank.GitVersioning" />
+   </packageSource>
    <packageSource key="msft_consumption">
      <package pattern="*" />
    </packageSource>
  </packageSourceMapping>
```

Or if nuget.org was already in the nuget.config file, you may need to just add the package ID to the inclusion list:

```diff
  <packageSourceMapping>
    <packageSource key="test-tools">
      <package pattern="Microsoft.CodeCoverage" />
    </packageSource>
    <packageSource key="nuget">
      <package pattern="System.Memory" />
+     <package pattern="Nerdbank.GitVersioning" />
    </packageSource>
    <packageSource key="msft_consumption">
      <package pattern="*" />
    </packageSource>
  </packageSourceMapping>
```

Running restore in the Microsoft OSS repo should now be able to find that package.
You can revert the nuget.config file change after running a successful restore locally.
