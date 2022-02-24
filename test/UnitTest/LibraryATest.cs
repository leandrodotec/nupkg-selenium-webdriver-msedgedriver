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
        public void Test1()
        {
            var g = new MsEdgeClient.EdgeClient();
            var result = g.Search();

            Assert.AreEqual("", result);
        }

        [Test]
        public void Test2()
        {
            var g = new ChromeClient.ChromeClient();
            var result = g.Search();

            Assert.AreEqual("", result);
        }
    }
}