using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace PipelineTestProject
{
    [TestFixture]

    public class DemoTests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://derivco.okta-emea.com/app/UserHome";
        }

        [TestCase]
        public void LaunchGoogleHomepage()
        {
           driver.FindElement(By.XPath("//*[@id='idp-discovery-username']")).SendKeys("Redmi 9");
           driver.FindElement(By.XPath("//*[@id='idp-discovery-submit']")).Click();
        }

        [TestCase]
        public void SayHello()
        {
            var result = driver.FindElement(By.XPath("//*[@id='okta-signin-password']")).Displayed;
            Assert.True(result);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
