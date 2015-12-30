using ForumApp.Integration.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace ForumApp.Integration.steps
{
    [Binding]
    public class SampleSteps
    {
        private IWebDriver _driver;
        private GooglePage _page;

        [Given(@"I can have a driver")]
        public void GivenICanHaveADriver()
        {
            _driver = new FirefoxDriver();
            _page = new GooglePage(_driver);
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