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
            int accountAmount = int.Parse(Map.accountTextBox.GetAttribute("value"));
            return accountAmount;
        }

        //Change account amount
        public void changeAccountAmount(String str)
        {
            Map.accountTextBox.SendKeys(str);
        }

        /* 
        Amount display has letters and numbers.
        this method only extracts the numbers
        */
        public String checkDisplayAccountAmount()
        {
            var totalDisplayAmount = Map.accountAmountDisplay.Text;
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


    public IWebElement logoutButton => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));

    public IWebElement accountTextBox => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));

    public IWebElement submitAmountButton => _driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));

    public IWebElement accountAmountDisplay => _driver.FindElement(By.CssSelector(".infobox>h3:nth-child(3)"));
}

