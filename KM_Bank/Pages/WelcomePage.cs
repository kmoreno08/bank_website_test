using System;
using System.Text;
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

        //Change account amount
        public void changeAccountAmount(String number)
        {
            Map.account_text_box.SendKeys(number);
        }

        /* 
        Amount display has letters and numbers.
        this method only extracts the numbers
        */
        public String checkDisplayAccountAmount()
        {
            var totalDisplayAmount = Map.account_amount_display.Text;
            var builder = new StringBuilder();

            foreach (char ch in totalDisplayAmount)
            {
                if (Char.IsDigit(ch))
                    builder.Append(ch);

            }
            String displayAmount = builder.ToString();
            return displayAmount;
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

    public IWebElement account_amount_display => _driver.FindElement(By.CssSelector(".infobox>h3:nth-child(3)"));
}

