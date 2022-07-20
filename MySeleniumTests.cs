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
            driver.Url = "https://derivco.okta-emea.com/app/UserHome";
        }

        [TestCase]
        public void LaunchGoogleHomepage()
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='idp-discovery-username']")).SendKeys("Redmi 9");
            System.Threading.Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='idp-discovery-submit']")).Click();
            System.Threading.Thread.Sleep(2000);
            var result = driver.FindElement(By.XPath("//*[@id='okta-signin-password']")).Displayed;
            Assert.True(result);
        }

        [TestCase]
        public void SayHello()
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='idp-discovery-username']")).SendKeys("Redmi 9");
            System.Threading.Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='idp-discovery-submit']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='okta-signin-password']")).SendKeys("DJ");
            System.Threading.Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='okta-signin-submit']")).Click();
            //System.Threading.Thread.Sleep(2000);
            var result = driver.FindElement(By.XPath("//*[@id='form65']/div[1]/div[1]/div/div/p")).Displayed;
            Assert.True(result);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
