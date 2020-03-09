using System;
using OpenQA.Selenium;

namespace KM_Bank.Pages
{
    public class HomePage
    {
        public readonly HomePageMap Map;

        public HomePage(IWebDriver driver)
        {
            Map = new HomePageMap(driver);
        }

        //Click link to go to signup page
        public void GoToSignupPage()
        {
            //Map.enrollLink.Click();
            Map.enrollLink.Click();
        }

        //Click login button
        public void GoToWelcomePage()
        {
            Map.loginButton.Click();
        }

        //Method is to set a user name in the user name text box
        public void setUsername(String strUsername)
        {
            Map.usernameTextBox.SendKeys(strUsername);
        }

        //Method is to set password in the password text box
        public void setPassword(String strPassword)
        {
            Map.passwordTextBox.SendKeys(strPassword);
        }


    }
    public class HomePageMap
    {
        IWebDriver _driver;

        public HomePageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        //Carousel
        public IWebElement carouselRightArrowButton => _driver.FindElement(By.CssSelector("body>div>div.carousel>button.carousel__button.carousel__button--right>i"));
        public IWebElement carouselLeftArrowButton => _driver.FindElement(By.CssSelector("body>div>div.carousel>button.carousel__button.carousel__button--left>i"));

        //Grid buttons
        public IWebElement grid_button_1 => _driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-1-container>div.grid-button-1"));
        public IWebElement grid_button_2 => _driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-2-container>div.grid-button-2"));
        public IWebElement grid_button_3 => _driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-3-container>div.grid-button-3"));

        //Enroll link 
        public IWebElement enrollLink => _driver.FindElement(By.CssSelector("body>div>div.loginbox>form>a"));

        //Log in 
        public IWebElement usernameTextBox => _driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
        public IWebElement passwordTextBox => _driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
        public IWebElement loginButton => _driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));

        //Footer Icons
        public IWebElement footerFacebookIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(1)>i"));
        public IWebElement footerInstaIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(2)>i"));
        public IWebElement footerLinkedinIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(3)>i"));
        public IWebElement footerPinterestIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(4)>i"));
        public IWebElement footerTwitterIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(5)>i"));
        public IWebElement footerYoutubeIcon => _driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(6)>i"));
    }
}
