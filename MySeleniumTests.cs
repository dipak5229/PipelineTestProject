using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace PipelineTestProject
{
    [TestFixture]

    public class MySeleniumTests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Url = "http://southseasgaming.microgaming.com/web/app/playersegmentation/";
        }

        [TestCase]
        public void LaunchAppHomepage()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(driver.Title);
            Assert.AreEqual(driver.Title,"Player Segmentation");
        }

        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
