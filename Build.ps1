﻿param (
  [string]$packageSuffix = "0",
  [bool]$isLocal = $false,
  [string]$outputDirectory = "..\..\buildoutput"
)

if ($isLocal){
  $packageSuffix = "dev" + [datetime]::UtcNow.Ticks.ToString()
  Write-Host "Local build - setting package suffixes to $packageSuffix" -ForegroundColor Yellow
}
dotnet --version

dotnet build -v q

if (-not $?) { exit 1 }

$projects =
    "WebJobs.Extensions",
    "WebJobs.Extensions.CosmosDB",
    "WebJobs.Extensions.Http",
    "WebJobs.Extensions.Twilio",
    "WebJobs.Extensions.Timers.Storage"
    "WebJobs.Extensions.SendGrid"

foreach ($project in $projects)
{
  $cmd = "pack", "src\$project\$project.csproj", "-o", $outputDirectory, "--no-build"
  
  if ($packageSuffix -ne "0")
  {
    $cmd += "--version-suffix", "-$packageSuffix"
  }
  
  & dotnet $cmd
}

### Sign package if build is not a PR
$shouldPackage = -not $env:APPVEYOR_PULL_REQUEST_NUMBER -or $env:APPVEYOR_PULL_REQUEST_TITLE.Contains("[pack]")

if ($shouldPackage) {
  & ".\tools\RunSigningJob.ps1" 
  if (-not $?) { exit 1 }
}