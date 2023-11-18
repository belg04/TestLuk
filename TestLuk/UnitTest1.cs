using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestLuk
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://kaliningrad.gorko.ru/";
            Assert.AreEqual("Свадьба в Калининграде на Горько.ру", webDriver.Title);
            webDriver.Close();
        }
        [TearDown]
        public void tearEnd()
        {
            webDriver.Quit();
        }









        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestSuccessfulBooking()
        {
            driver.Navigate().GoToUrl("https://kaliningrad.gorko.ru/");

        }

        [Test]
        public void TestEventSearch()
        {
            driver.Navigate().GoToUrl("https://kaliningrad.gorko.ru/");

        }

        [Test]
        public void TestEventFiltering()
        {
            driver.Navigate().GoToUrl("https://kaliningrad.gorko.ru/");

        }

        [Test]
        public void TestAddToFavorite()
        {
            driver.Navigate().GoToUrl("https://kaliningrad.gorko.ru/");

        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }

}
        
    


   




