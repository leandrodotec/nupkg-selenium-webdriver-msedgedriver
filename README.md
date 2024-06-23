# DISCLAIMER: Maybe this package is not for you

From v4.0, Selenium has Selenium Manager (https://www.selenium.dev/documentation/selenium_manager/):

```
... "Selenium Manager is a command-line tool implemented in Rust that provides automated driver and browser management
for Selenium. Selenium bindings use this tool by default, so you do not need to download it or add
anything to your code or do anything else to use it." ...
```

# Install the NuGet Package

```
Install-Package Selenium.WebDriver.MSEdgeDriver
or
dotnet add package Selenium.WebDriver.MSEdgeDriver
```

# Getting started

```
var edgeOptions = new EdgeOptions
{
    UseChromium = true
};
var edgeDriverService = EdgeDriverService.CreateChromiumService();
```

For more information, see https://github.com/microsoft/edge-selenium-tools.

# Create the NuGet package

```
getPackage.bat <version>
```

For example, to automatically download the Microsoft Edge Driver and create the NuGet package '.\dist\Selenium.WebDriver.MSEdgeDriver.84.0.522.49.nupkg':

```
getPackage.bat 84.0.522.49
```

# Contributing

Most the process is automated, but I still need to check MS Edge Driver's page and execute the batch file manually. I am trying to do this once a month. If you would like to have faster releases, please contact me to become a contributor.


# Cross-platform building and publishing

Edge driver developers normally releases versions with win32, win64, mac and linux binaries, but sometimes they decide to release one version with just linux, or just mac and windows binaries. 
The automated process can only make nuget packages of full releases.

# How to include the driver file into published files?

"msedgedriver(.exe)" isn't included in published files on default configuration. This behavior is by design and follows https://raw.githubusercontent.com/jsakamoto/nupkg-selenium-webdriver-chromedriver/ design. For more info reffer to guides at https://raw.githubusercontent.com/jsakamoto/nupkg-selenium-webdriver-chromedriver.

To include published files, define `PublishMsEdgeDriver` property with value is "true" in MSBuild file (.csproj, .vbproj, etc...) to publish the driver file instead of define compilation symbol.

```xml
  <Project ...>
    ...
    <PropertyGroup>
      ...
      <PublishMsEdgeDriver>true</PublishMsEdgeDriver>
      ...
    </PropertyGroup>
...
</Project>
```
