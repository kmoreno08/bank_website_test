using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_test
{
    class WelcomePage
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(@"http://localhost/KM_bank/index.php");
            Thread.Sleep(4000);

            try
            {
                IWebElement username_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
                IWebElement password_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
                IWebElement login_button = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));
                username_text_box.Clear();
                username_text_box.SendKeys("test");

                password_text_box.Clear();
                password_text_box.SendKeys("test");
                Thread.Sleep(4000);

                login_button.Click();
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Welcome Page setup - Error:  " + e);
            }
        }
        [Test]
        public void change_amount()
        {
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    


                    //Change amount
                    IWebElement account_text_box = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));

                    account_text_box.Clear();
                    account_text_box.SendKeys("824");

                    IWebElement submit_amount_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));

                    submit_amount_button.Click();
                    Thread.Sleep(5000);


                    IWebElement sign_out_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
                    sign_out_button.Click();
                    Thread.Sleep(5000);

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Welcome Page change amount - Error:  " + e);
                }
            }
        }
        //Welcome page footer
        [Test]
        public void footer_icons()
        {
            //Footer is loaded
            for (int i = 0; i <= 2; i++)
            {

                try
                {
                    IWebElement welcome_facebook = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(1)>i"));
                    welcome_facebook.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement welcome_instagram = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(2)>i"));
                    welcome_instagram.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement welcome_linkedin = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(3)>i"));
                    welcome_linkedin.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement welcome_pinterest = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(4)>i"));
                    welcome_pinterest.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement welcome_twitter = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(5)>i"));
                    welcome_twitter.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement welcome_youtube = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(6)>i"));
                    welcome_youtube.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Welcome Page Footer icons - Error:  " + e);
                }
            }






        }

        [TearDown]
        public void closeBrowser()
        {
           driver.Close();
        }

    }
}
