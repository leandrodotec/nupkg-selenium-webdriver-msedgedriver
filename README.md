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

~~All~~ Most the process is automated, but I still need to check MS Edge Driver's page and execute the batch file. I am trying to do this once a month. If you would like to have faster releases, please contact me to become a contributor.
