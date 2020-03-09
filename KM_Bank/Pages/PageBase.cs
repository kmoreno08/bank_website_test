using OpenQA.Selenium;

namespace KM_Bank.Pages
{
    public abstract class PageBase
    {
        public readonly HomePage HomePage;

        public PageBase(IWebDriver driver)
        {
            HomePage = new HomePage(driver);
        }
    }
}