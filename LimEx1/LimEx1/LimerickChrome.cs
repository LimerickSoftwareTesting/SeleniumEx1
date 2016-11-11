using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace LimEx1
{
    [TestFixture]
    public class LimerickChrome
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // create the driver instance
            // replace the path with your path
            string path = @"C:\WebDrivers";
            driver = new ChromeDriver(path);
        }

        [Test]
        public void GoToWikipediaInChrome()
        {
            driver.Url = "https://en.wikipedia.org/wiki/Main_Page";
            IWebElement searchInput = driver.FindElement(By.CssSelector("#searchInput"));
            searchInput.Click();
            searchInput.SendKeys("Limerick");
            IWebElement searchButton = driver.FindElement(By.CssSelector("#searchButton"));
            searchButton.Click();

            // only here to make it easy to see the result
            // remove and check for page ready/dom quietness for your own test
            Thread.Sleep(4000);

            Assert.AreEqual(driver.Title, "Limerick - Wikipedia");
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}
