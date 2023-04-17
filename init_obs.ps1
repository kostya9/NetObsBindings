$BeforeLocation = Get-Location
$GitTag = "release/29.0"

try {
    $ObsFolder = './obs-studio'

    if (Test-Path -Path $ObsFolder) {
        Set-Location $ObsFolder
        git checkout $GitTag
        git pull origin
    } else {
        git clone https://github.com/obsproject/obs-studio
    }
}
finally {
    Set-Location $BeforeLocation
}