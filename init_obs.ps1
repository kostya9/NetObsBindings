$BeforeLocation = Get-Location

try {
    $ObsFolder = './obs-studio'

    if (Test-Path -Path $ObsFolder) {
        Set-Location $ObsFolder
        git checkout master
        git pull origin
    } else {
        git clone https://github.com/obsproject/obs-studio
    }
}
finally {
    Set-Location $BeforeLocation
}