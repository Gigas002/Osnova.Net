$buildAll=$args[0]

# Build and publish

Write-Output "Started building/publishing"

Write-Output "Started building Osnova.Net"
dotnet publish "Osnova.Net/Osnova.Net.csproj" -c Release /p:Platform=x64
Write-Output "Ended building Osnova.Net"

# win-x64
if ($IsWindows -or $buildAll)
{
    Write-Output "Started win-x64-OsnovaImageDownloader publish"
    dotnet publish "OsnovaImageDownloader/OsnovaImageDownloader.csproj" -c Release -r win-x64 /p:PublishDir=../Publish/OsnovaImageDownloader/win-x64 /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true /p:PublishTrimmed=true
    Write-Output "Ended win-x64-OsnovaImageDownloader publish"
}

# linux-x64
if ($IsLinux -or $buildAll)
{
    Write-Output "Started linux-x64-OsnovaImageDownloader publish"
    dotnet publish "OsnovaImageDownloader/OsnovaImageDownloader.csproj" -c Release -r linux-x64 /p:PublishDir=../Publish/OsnovaImageDownloader/linux-x64 /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true /p:PublishTrimmed=true
    Write-Output "Ended linux-x64-OsnovaImageDownloader publish"
}

# osx-x64
if ($IsMacOS -or $buildAll)
{
    Write-Output "Started osx-x64-OsnovaImageDownloader publish"
    dotnet publish "OsnovaImageDownloader/OsnovaImageDownloader.csproj" -c Release -r osx-x64 /p:PublishDir=../Publish/OsnovaImageDownloader/osx-x64 /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true /p:PublishTrimmed=true
    Write-Output "Ended osx-x64-OsnovaImageDownloader publish"
}

Write-Output "Ended building/publishing"

# Remove all *.pdb files
Write-Output "Removing all *.pdb files from Publish directory"
Get-ChildItem "Publish/" -Include *.pdb -Recurse | Remove-Item

# Copy docs, etc to published directories before zipping them
Write-Output "Copying docs, LICENSE, etc to published directories"

# win-x64
if ($IsWindows -or $buildAll)
{
    Copy-Item -Path "OsnovaImageDownloader/start.ps1" -Destination "Publish/OsnovaImageDownloader/win-x64/start.ps1"
    Copy-Item -Path "LICENSE" -Destination "Publish/OsnovaImageDownloader/win-x64/LICENSE"
    Copy-Item -Path "CHANGELOG.md" -Destination "Publish/OsnovaImageDownloader/win-x64/CHANGELOG.md"
}

# linux-x64
if ($IsLinux -or $buildAll)
{
    Copy-Item -Path "OsnovaImageDownloader/start.ps1" -Destination "Publish/OsnovaImageDownloader/linux-x64/start.ps1"
    Copy-Item -Path "LICENSE" -Destination "Publish/OsnovaImageDownloader/linux-x64/LICENSE"
    Copy-Item -Path "CHANGELOG.md" -Destination "Publish/OsnovaImageDownloader/linux-x64/CHANGELOG.md"
}

# osx-x64
if ($IsMacOS -or $buildAll)
{
    Copy-Item -Path "OsnovaImageDownloader/start.ps1" -Destination "Publish/OsnovaImageDownloader/osx-x64/start.ps1"
    Copy-Item -Path "LICENSE" -Destination "Publish/OsnovaImageDownloader/osx-x64/LICENSE"
    Copy-Item -Path "CHANGELOG.md" -Destination "Publish/OsnovaImageDownloader/osx-x64/CHANGELOG.md"
}

# Add everything into archives. Requires installed 7z added to PATH.

Write-Output "Started adding published files to .zip archives"

# win-x64
if ($IsWindows -or $buildAll)
{
    Write-Output "Start adding win-x64 to .zip"
    Start-Process -NoNewWindow -Wait -FilePath "7z" -ArgumentList "a ../../win-x64-OsnovaImageDownloader.zip *" -WorkingDirectory "Publish/OsnovaImageDownloader/win-x64/"
    Write-Output "Ended adding win-x64 to .zip"
}

# linux-x64
if ($IsLinux -or $buildAll)
{
    Write-Output "Start adding linux-x64 to .zip"
    Start-Process -NoNewWindow -Wait -FilePath "7z" -ArgumentList "a ../../linux-x64-OsnovaImageDownloader.zip *" -WorkingDirectory "Publish/OsnovaImageDownloader/linux-x64/"
    Write-Output "Ended adding linux-x64 to .zip"
}

# osx-x64
if ($IsMacOS -or $buildAll)
{
    Write-Output "Start adding osx-x64 to .zip"
    Start-Process -NoNewWindow -Wait -FilePath "7z" -ArgumentList "a ../../osx-x64-OsnovaImageDownloader.zip *" -WorkingDirectory "Publish/OsnovaImageDownloader/osx-x64/"
    Write-Output "Ended adding osx-x64 to .zip"
}

Write-Output "Ended adding published files to .zip archives"
