using OpenQA.Selenium;

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