using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Threading;

namespace LimEx1
{
    [TestFixture]
    public class LimerickFirefox
    {
        private IWebDriver driver;
        private FirefoxDriverService service;

        [SetUp]
        public void SetUp()
        {
            // create the driver instance
            // replace the path with your path

            string path = @"C:\WebDrivers";
            service = FirefoxDriverService.CreateDefaultService(path);
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            driver = new FirefoxDriver(service);
        }

        [Test]
        public void GoToWikipediaInFirefox()
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
