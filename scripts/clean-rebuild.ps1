# PowerShell script to clean bin/obj folders and rebuild the solution
# Run this from the repository root in an elevated PowerShell session if needed.

Write-Host "Restoring packages..."
dotnet restore

Write-Host "Cleaning solution and removing bin/obj folders..."
dotnet clean

# Remove all bin and obj directories under the repo (force)
Get-ChildItem -Path . -Recurse -Force -Directory -ErrorAction SilentlyContinue |
    Where-Object { $_.Name -in ('bin','obj') } |
    ForEach-Object {
        Write-Host "Removing: $($_.FullName)"
        Remove-Item -Path $_.FullName -Recurse -Force -ErrorAction SilentlyContinue
    }

Write-Host "Rebuilding solution (Debug)..."
dotnet build -c Debug

Write-Host "Build finished. If you target Windows MAUI, use Visual Studio or 'dotnet build' with the correct target runtime."