using System;
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
            Map.signupLoginButton.Click();
        }

        //Method is to create user name on signup page
        public void createAccountUsername(String strUsername)
        {
            Map.signupUsernameTextBox.SendKeys(strUsername);
        }

        //Method is to create an email address on signup page
        public void createAccountEmailAddress(String strEmailAddress)
        {
            Map.signupEmailTextBox.SendKeys(strEmailAddress);
        }

        //Method is to create a password on signup page
        public void createAccountPassword(String strPassword)
        {
            Map.signupPasswordTextBox.SendKeys(strPassword);
        }

        //Method is to repeat the created password on signup page
        public void createRepeatAccountPassword(String strRepeatPassword)
        {
            Map.signupPasswordRepeatTextBox.SendKeys(strRepeatPassword);
        }
    }

    public class SignupPageMap
    {
        IWebDriver _driver;

        public SignupPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement signupLoginButton => _driver.FindElement(By.CssSelector("body>div>div>form>input[type=submit]:nth-child(9)"));




        public IWebElement signupUsernameTextBox => _driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(2)"));
        public IWebElement signupEmailTextBox => _driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(4)"));
        public IWebElement signupPasswordTextBox => _driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(6)"));

        public IWebElement signupPasswordRepeatTextBox => _driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(8)"));


    }
}