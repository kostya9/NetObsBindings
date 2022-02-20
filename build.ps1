Write-Host "--------------------------"
Write-Host "Fetching Obs repository..."
Write-Host "--------------------------"

./init_obs.ps1
Write-Host "----------------------"
Write-Host "Generating Bindings..."
Write-Host "----------------------"

./generate_bindings.ps1

Write-Host "--------"
Write-Host "Success!"
Write-Host "--------"