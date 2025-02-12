#requires -RunAsAdministrator

param(
    [Parameter(Mandatory=$true)]
    [string]$VsInstanceRootPath,
    [Parameter(Mandatory=$false)]
    [string[]]$Runtimes = @("net9.0")
)

$newExtensibilityHostsDirectory = [System.IO.Path]::Combine($VsInstanceRootPath, "Common7", "ServiceHub", "Hosts", "ServiceHub.Host.Extensibility.ExtendedHosts.amd64")
if (Test-Path -Path $newExtensibilityHostsDirectory) {
    Remove-Item -Path $newExtensibilityHostsDirectory -Recurse -Force
    Write-Host "Removed extended hosts directory at $($newExtensibilityHostsDirectory)"
}

foreach ($runtime in $Runtimes)
{
    if ($runtime -eq "net8.0") {
        Write-Host "Cannot remove .NET runtime 8.0, it is required for VS. Skipping."
        continue
    }

    $dotnetInstallLocation = [System.IO.Path]::Combine($VsInstanceRootPath, "dotnet", $runtime, "runtime");

    if (Test-Path -Path $dotnetInstallLocation) {
        Remove-Item -Path $dotnetInstallLocation -Recurse -Force
        Write-Host "Removed .NET runtime for $($runtime) at $($dotnetInstallLocation)"
    }
}

Write-Host "Cleanup complete. Removed .NET runtime and hosts for $($Runtimes -join ", ")"