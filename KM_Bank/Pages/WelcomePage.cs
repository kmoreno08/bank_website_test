using OpenQA.Selenium;

namespace KM_Bank.Pages
{
    public class WelcomePage
    {
        public readonly WelcomePageMap Map;

        public WelcomePage(IWebDriver driver)
        {
            Map = new WelcomePageMap(driver);
        }

        public void GoToHomePage()
        {
            Map.logoutButton.Click();
        }
    }
    public class WelcomePageMap
    {
        IWebDriver _driver;

        public WelcomePageMap(IWebDriver driver)
        {
            _driver = driver;
        }


        public IWebElement logoutButton => _driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));
    }
}
