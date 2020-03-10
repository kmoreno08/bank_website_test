using System;
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

        public void clickLogoutButton()
        {
            Map.logoutButton.Click();
        }

        //Changes user account amount from string to int
        public int returnIntAccountAmount()
        {
            int accountAmount = int.Parse(Map.account_text_box.GetAttribute("value"));
            return accountAmount;
        }


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

    public IWebElement account_text_box => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));

    public IWebElement submit_amount_button => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));

}

