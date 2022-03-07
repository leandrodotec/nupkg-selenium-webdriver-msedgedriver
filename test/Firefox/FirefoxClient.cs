using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Firefox
{
    public class FirefoxClient
    {
        public string Search()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchBox.SendKeys("Selenium");
            searchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value"); // => "Selenium"
            driver.Quit();
            return searchQuery;
        }
    }
}