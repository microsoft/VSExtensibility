#requires -RunAsAdministrator

param(
    [Parameter(Mandatory=$true)]
    [string]$VsInstanceRootPath,
    [Parameter(Mandatory=$false)]
    [string[]]$Runtimes = @("net8.0", "net9.0")
)


if (-not (Test-Path -Path $VsInstanceRootPath)) {
    Write-Error "Visual Studio instance root path does not exist: $VsInstanceRootPath"
    exit 1
}

$dotnetInstallScriptName = "dotnet-install.ps1"
$dotnetInstallScriptPath = [System.IO.Path]::Combine([System.Environment]::CurrentDirectory, $dotnetInstallScriptName)
$dotnetInstallUrl = "https://dot.net/v1/dotnet-install.ps1";
$netVersions = @{
    "net8.0" = "8.0.405";
    "net9.0" = "9.0.102";
}

# Copy host directory and remove existing host configs
$extensibilityHostsDirectory = [System.IO.Path]::Combine($VsInstanceRootPath, "Common7", "ServiceHub", "Hosts", "ServiceHub.Host.Extensibility.amd64")
$newExtensibilityHostsDirectory = [System.IO.Path]::Combine($VsInstanceRootPath, "Common7", "ServiceHub", "Hosts", "ServiceHub.Host.Extensibility.ExtendedHosts.amd64")
Copy-Item -Path $extensibilityHostsDirectory -Destination $newExtensibilityHostsDirectory -Recurse
Remove-Item -Path $newExtensibilityHostsDirectory -Include *servicehub.host.json -Recurse -Force
Write-Host "Created new host directory at $newExtensibilityHostsDirectory"

foreach ($runtime in $Runtimes) {
    # Verify that we have a specific version for the runtime
    if (-not ($netVersions.ContainsKey($runtime))) {
        Write-Host "Cannot find specific version for .NET runtime: $runtime. Skipping."
        continue
    }

    $netVersion = $netVersions[$runtime]
    $hostFiles = @("dotnetExtensibility-$($runtime).servicehub.host.json", "dotnetExtensibility-$($runtime).x64.servicehub.host.json")
    $dotnetInstallLocation = [System.IO.Path]::Combine($VsInstanceRootPath, "dotnet", $runtime, "runtime");
    $hostConfigTemplate = @"
{
  "`$schema": "../../../schemas/servicehub.host.schema.json",
  "hostExecutable": "./ServiceHub.Host.Extensibility.x64.exe",
  "hostArgs": [ "`$HOSTID", "`$PIPE", "`$TELEMETRYSESSION", "`$HostRemoteBrokerPipeName" ],
  "additionalEnvironmentVariables": {
    "DOTNET_ROOT": "$($dotnetInstallLocation -replace '\\', '\\')"
  }
}
"@

    # Install .NET if needed
    if (-not (Test-Path -Path $dotnetInstallLocation)) {
        Write-Host "Installing runtime for $($runtime). Installing version $($netVersion) to $dotnetInstallLocation."

        # Create .NET install directory
        New-Item -ItemType Directory -Path $dotnetInstallLocation > $null

        # Install .NET installer script
        try {
            if (-not (Test-Path -Path $dotnetInstallScriptPath)) {
                Invoke-WebRequest -Uri $dotnetInstallUrl -OutFile $dotnetInstallScriptPath
            }
        } catch {
            Write-Error "Failed to download installer."
            exit 1
        }

        # Verify .NET installer script exists
        if (-not (Test-Path -Path $dotnetInstallScriptPath)) {
            Write-Error "Cannot locate .NET installer script"
            exit 1
        }

        # Download .NET to target location
        try {
            & $dotnetInstallScriptPath -Version $netVersion -InstallDir $dotnetInstallLocation -NoPath
        } catch {
            Write-Error "Failed to install $($runtime)"
        }

        Write-Host "Successfully installed runtime version $($netVersion) to $dotnetInstallLocation."
    }

    # Add new host configs
    foreach ($file in $hostFiles) {
        $hostConfigPath = [System.IO.Path]::Combine($newExtensibilityHostsDirectory, $file)
        New-Item $hostConfigPath -ItemType File -Value $hostConfigTemplate > $null
    }
    Write-Host "Service hub host configs updated for $($runtime)"
}

if (Test-Path -Path $dotnetInstallScriptPath) {
    Remove-Item -Path $dotnetInstallScriptPath -Force
    Write-Host "Removed .NET installer script at $dotnetInstallScriptPath"
}

Write-Host "Setup complete. Installed .NET runtimes and updated service hub hosts for $($Runtimes)"