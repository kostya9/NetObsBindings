Write-Host "--------------------------"
Write-Host "Fetching Obs repository..."
Write-Host "--------------------------"

./init_obs.ps1
Write-Host "----------------------"
Write-Host "Generating Bindings..."
Write-Host "----------------------"

./generate_bindings.ps1

Write-Host "--------"
Write-Host "Setting OBS version..."
Write-Host "--------"

./replace_version.ps1

Write-Host "--------"
Write-Host "Finished!"
Write-Host "--------"