$BeforeLocation = Get-Location
$GitTag = "32.0.0"

try {
    $ObsFolder = './obs-studio'

    if (Test-Path -Path $ObsFolder) {
        Set-Location $ObsFolder
        git fetch origin
        git checkout $GitTag
        git pull origin
    } else {
        git clone https://github.com/obsproject/obs-studio
        git checkout $GitTag
    }

    # Create obsconfig.h in libobs folder
    $LibObsFolder = './libobs'
    $ObsConfigPath = Join-Path $LibObsFolder 'obsconfig.h'

    if (Test-Path -Path $LibObsFolder) {
        if (-not (Test-Path -Path $ObsConfigPath)) {
            Write-Host "Creating obsconfig.h in libobs folder..."
            '#pragma once' | Out-File -FilePath $ObsConfigPath -Encoding UTF8
            Write-Host "obsconfig.h created successfully at: $ObsConfigPath"
        } else {
            Write-Host "obsconfig.h already exists at: $ObsConfigPath"
        }
    } else {
        Write-Host "Warning: libobs folder not found at expected location: $LibObsFolder"
    }
}
finally {
    Set-Location $BeforeLocation
}
