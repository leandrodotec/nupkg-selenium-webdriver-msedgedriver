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

Although all the process is automated, there are always improvements that can be made. Create a pull request or message me :-).
