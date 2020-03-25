@echo off

if [%~1]==[] goto :noversion

set version=%1
set nugetFile=Selenium.WebDriver.MSEdgeDriver.nuspec
mkdir .\download\%version%
echo  Downloading %version%
curl https://msedgedriver.azureedge.net/%version%/edgedriver_win32.zip -o .\download\%version%\edgedriver_win32.zip
curl https://msedgedriver.azureedge.net/%version%/edgedriver_win64.zip -o .\download\%version%\edgedriver_win64.zip
curl https://msedgedriver.azureedge.net/%version%/edgedriver_mac64.zip -o .\download\%version%\edgedriver_mac64.zip
PowerShell -Command "Expand-Archive -Path .\download\%version%\edgedriver_win32.zip -DestinationPath .\download\%version%\edgedriver_win32"
PowerShell -Command "Expand-Archive -Path .\download\%version%\edgedriver_win64.zip -DestinationPath .\download\%version%\edgedriver_win64"
PowerShell -Command "Expand-Archive -Path .\download\%version%\edgedriver_mac64.zip -DestinationPath .\download\%version%\edgedriver_mac64"

PowerShell -Command "(Get-Content -path Selenium.WebDriver.MSEdgeDriver.template.nuspec -Raw) -replace '_version_','%version%'" > %nugetFile%

nuget pack %nugetFile% -OutputDirectory .\dist

echo Removing temp files ...
del /F /Q /S download\%version%
rmdir /S /Q download\%version%
del %nugetFile%
echo Done
goto :finish

:noversion
echo .
echo .
echo missing version parameter
echo usage: getPackage.bat VERSION
echo Example
echo getPackage.bat 81.12.654
echo .
echo .
:finish