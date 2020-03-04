using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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

namespace KM_Bank
{
    [TestFixture]
    public class WelcomePage
    {
        IWebDriver driver;
        [SetUp]
        public void open_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(@"http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php");
            Thread.Sleep(1000);

            //Need to log in first
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
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Welcome Page setup - Error:  " + e);
            }
        }
    
        [Test]
        public void change_amount()
        {
            string account_text_amount = "824";
            string account_text_default_amount = "1000";
            
                try
                {
                    //Change amount
                    IWebElement account_text_box = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));
                    
                    //Clear and enter amount
                    account_text_box.Clear();
                    account_text_box.SendKeys(account_text_amount);

                    
                    IWebElement submit_amount_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));
                    submit_amount_button.Click();
                    Thread.Sleep(1000);

                    //check correct amount
                    string account_amount = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)")).GetAttribute("value");
                    Assert.That(account_amount, Is.EqualTo("824"));

                    //Reset to '1000'
                    IWebElement account_text_box_reset = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));
                    account_text_box_reset.Clear();
                    account_text_box_reset.SendKeys(account_text_default_amount);
                    IWebElement submit_amount_button_reset = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));
                    Thread.Sleep(1000);
                    submit_amount_button_reset.Click();
                    Thread.Sleep(1000);

                    //Sign out
                    IWebElement sign_out_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
                    sign_out_button.Click();
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Welcome Page change amount - Error:  " + e);
                }    
        }

        [Test]
        public void change_amount_fail()
        {
            //Should equal different amount, test should fail
            string account_text_amount = "824";
            string account_text_default_amount = "1000";

            try
            {
                //Change amount
                IWebElement account_text_box = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));

                //Clear and enter amount
                account_text_box.Clear();
                account_text_box.SendKeys(account_text_amount);


                IWebElement submit_amount_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));
                submit_amount_button.Click();
                Thread.Sleep(1000);

                //check amount, should fail here
                string account_amount = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)")).GetAttribute("value");
                Assert.That(account_amount, Is.EqualTo("222"));

                //Reset to '1000'
                IWebElement account_text_box_reset = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));
                account_text_box_reset.Clear();
                account_text_box_reset.SendKeys(account_text_default_amount);
                IWebElement submit_amount_button_reset = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));
                Thread.Sleep(1000);
                submit_amount_button_reset.Click();
                Thread.Sleep(1000);

                //Sign out
                IWebElement sign_out_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
                sign_out_button.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Welcome Page change amount - Error:  " + e);
            }
        }
        //Welcome page footer
        [Test]
        public void footer_icons()
        {
            //Loop to make sure footer has loaded
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    IWebElement welcome_facebook = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(1)>i"));
                    welcome_facebook.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement welcome_instagram = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(2)>i"));
                    welcome_instagram.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement welcome_linkedin = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(3)>i"));
                    welcome_linkedin.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement welcome_pinterest = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(4)>i"));
                    welcome_pinterest.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement welcome_twitter = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(5)>i"));
                    welcome_twitter.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement welcome_youtube = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(6)>i"));
                    welcome_youtube.Click();
                    Thread.Sleep(1000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);
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
