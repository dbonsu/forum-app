using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Integration.pages
{
    public class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver) :
            base(driver)
        {
        }

        public void GotoGoogle()
        {
            GoTo("https://www.google.com");
        }
    }
}