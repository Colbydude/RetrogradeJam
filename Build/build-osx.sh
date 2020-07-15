#!/bin/bash

dotnet publish -c Release -r osx-x64 /p:PublishReadyToRun=false /p:TieredCompilation=false --self-contained

rm -rf dist/osx
mkdir -p dist/osx/RetrogradeJam.app/Contents/Resources

mv bin/Release/netcoreapp3.1/osx-x64/publish dist/osx/RetrogradeJam.app/Contents/MacOS
mv dist/osx/RetrogradeJam.app/Contents/MacOS/Content dist/osx/RetrogradeJam.app/Contents/Resources/Content
# cp Build/OSX/RetrogradeJam.icns dist/osx/RetrogradeJam.app/Contents/Resources/RetrogradeJam.icns
cp Build/OSX/Info.plist dist/osx/RetrogradeJam.app/Info.plist
