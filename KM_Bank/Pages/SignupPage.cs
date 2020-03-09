using OpenQA.Selenium;

namespace KM_Bank.Pages
{
    public class SignupPage
    {
        public readonly SignupPageMap Map;

        public SignupPage(IWebDriver driver)
        {
            Map = new SignupPageMap(driver);
        }


        public void GoToWelcomePage()
        {
            Map.loginButton.Click();
        }

        /* public SignupPage GoTo()
         {
             HomePage.GoToSignupPage();
             return this;
         }*/
    }

    public class SignupPageMap
    {
        IWebDriver _driver;

        public SignupPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement loginButton => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
    }
}