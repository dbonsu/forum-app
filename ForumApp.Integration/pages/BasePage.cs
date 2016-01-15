using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForumApp.Integration.pages
{
    /// <summary>
    /// Base class for handling WedDriver interactions
    /// </summary>
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Close()
        {
            _driver.Close();
        }

        public IWebElement Find(By by)
        {
            return _driver.FindElement(by);
        }

        public ICollection<IWebElement> FindAll(By by)
        {
            return _driver.FindElements(by);
        }

        public string GetTitle()
        {
            return _driver.Title;
        }

        public void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public void ScrollAndClick(By by)
        {
            IWebElement element = Find(by);
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Sleep(500);
            element.Click();
        }

        public void Sendkeys(IWebElement element, string keys)
        {
            element.SendKeys(keys);
        }

        public void SendKeys(By by, string keys)
        {
            Find(by).SendKeys(keys);
        }

        public void Sleep(int millisecondsToSleep)
        {
            Thread.Sleep(TimeSpan.FromSeconds(millisecondsToSleep));
        }
    }
}