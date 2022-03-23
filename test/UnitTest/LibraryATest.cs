using NUnit.Framework;

namespace WebDriver.EdgeChromiumDriver.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EdgeTest()
        {
            var g = new MsEdgeClient.EdgeClient();
            var result = g.Search();

            Assert.AreEqual("Selenium", result);
        }

        [Test]
        public void ChromeTest()
        {
            var g = new ChromeClient.ChromeClient();
            var result = g.Search();

            Assert.AreEqual("Selenium", result);
        }

        [Test]
        public void FirefoxTest()
        {
            var g = new Firefox.FirefoxClient();
            var result = g.Search();

            Assert.AreEqual("Selenium", result);
        }
    }
}