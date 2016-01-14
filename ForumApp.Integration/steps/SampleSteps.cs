using ForumApp.Integration.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System.Configuration;
using TechTalk.SpecFlow;

namespace ForumApp.Integration.steps
{
    [Binding]
    public class SampleSteps
    {
        private IWebDriver _driver;
        private GooglePage _page;
        private DesiredCapabilities cap;

        private IWebDriver driver;

        [Given(@"I can have a driver")]
        public void GivenICanHaveADriver()
        {
            //location is relative to executing dll in bin/debug
            var driverPath = ConfigurationManager.AppSettings["driverLocation"];
            EdgeOptions options = new EdgeOptions();
            options.PageLoadStrategy = EdgePageLoadStrategy.Eager;

            cap = DesiredCapabilities.Chrome();

            driver = new EdgeDriver(driverPath, options);
            // _driver = new ChromeDriver(driverPath);
            _page = new GooglePage(driver);
        }

        [Then(@"the web page is displayed")]
        public void ThenTheWebPageIsDisplayed()
        {
            Assert.AreEqual(_page.GetTitle(), _driver.Title);
        }

        [When(@"I go to google")]
        public void WhenIGoToGoogle()
        {
            _page.GotoGoogle();
        }
    }
}