using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PipelineTestProject
{

    [TestFixture]
    public class Tests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.amazon.co.uk/";
        }

        [Test]
        public void LaunchGoogleHomepage()
        {
//            driver.FindElement(By.XPath("//*[@id='twotabsearchtextbox']")).SendKeys("Redmi 9");
            Assert.AreEqual("Hello, Sign in", driver.FindElement(By.XPath("//*[@id='nav-link-accountList-nav-line-1]")).Text);
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}