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
    class SignupPage
    {
        IWebDriver driver;

        //account number
        string account_number = "5";
        [SetUp]
        public void open_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(@"http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/signup.php");
            Thread.Sleep(4000);
        }

        [Test]
        public void footer_icons()
        {
            //Wait until footer is loaded
            for (int i = 0; i <= 2; i++)
            {

                try
                {
                    IWebElement signup_footer_facebook = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(1)"));
                    signup_footer_facebook.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(8000);

                    IWebElement signup_footer_insta = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(2)"));
                    signup_footer_insta.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement signup_footer_linkedin = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(3)"));
                    signup_footer_linkedin.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement signup_footer_pinterest = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(4)"));
                    signup_footer_pinterest.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement signup_footer_twitter = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(5)"));
                    signup_footer_twitter.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);

                    IWebElement signup_footer_youtube = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(6)"));
                    signup_footer_youtube.Click();
                    Thread.Sleep(6000);
                    this.driver.Navigate().Back();
                    Thread.Sleep(6000);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Signup Page Footer icons - Error:  " + e);
                }

            }
        }
        [Test]
        public void login_link()
        {
            try { 
             IWebElement login_link = driver.FindElement(By.CssSelector("body>div>div>form>a"));
            login_link.Click();
            Thread.Sleep(4000);
             //Check if url is correct
             String current_URL = driver.Url;
             Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php"));

            }
            catch (Exception e)
            {
                Console.WriteLine("SignupPage signin Link - Error:  " + e);
            }
        }

     
        [Test]
        public void create_account_pass() 
        {
            IWebElement signup_username_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(2)"));
            IWebElement signup_email_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(4)"));
            IWebElement signup_pass_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(6)"));
            IWebElement signup_pass_repeat_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(8)"));
            IWebElement signup_login = driver.FindElement(By.CssSelector("body>div>div>form>input[type=submit]:nth-child(9)"));

            signup_username_text_box.Clear();
            signup_username_text_box.SendKeys("autoTestAccount" + account_number);

            signup_email_text_box.Clear();
            signup_email_text_box.SendKeys("autoTestAccount" + account_number + "@gmail.com");

            signup_pass_text_box.Clear();
            signup_pass_text_box.SendKeys("test");

            signup_pass_repeat_text_box.Clear();
            signup_pass_repeat_text_box.SendKeys("test");

            signup_login.Click();
            //Check if url is correct
            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php?signup=success"));

            // Thread.Sleep(5000);
        }

        [Test]
        public void create_account_fail() 
        {
            IWebElement signup_username_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(2)"));
            IWebElement signup_email_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(4)"));
            IWebElement signup_pass_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(6)"));
            IWebElement signup_pass_repeat_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(8)"));
            IWebElement signup_login = driver.FindElement(By.CssSelector("body>div>div>form>input[type=submit]:nth-child(9)"));

            signup_username_text_box.Clear();
            signup_username_text_box.SendKeys("fail" + account_number);

            signup_email_text_box.Clear();
            signup_email_text_box.SendKeys("fail@gmail.com");

            signup_pass_text_box.Clear();
            signup_pass_text_box.SendKeys("fail");

            signup_pass_repeat_text_box.Clear();
            signup_pass_repeat_text_box.SendKeys("failrepeat");

            //Check URL and should fail
            signup_login.Click();
            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));
            //Thread.Sleep(5000);
        }
        [Test]
        /*Login with created test account
         * once logged in will log out
         * verify with url 
         */
        public void login_create_account_pass() 
        {
            //Signin link
            try
            {
                IWebElement signin_link = driver.FindElement(By.CssSelector("body>div>div>form>a"));
                signin_link.Click();
                Thread.Sleep(4000);
               
            }
            catch (Exception e)
            {
                Console.WriteLine("SignupPage login create account Signin Link- Error:  " + e);
            }

            //Create account w/ new credentials
            try
            {
                IWebElement test_account_username_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
                IWebElement test_account_password_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
                IWebElement test_account_login_button = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));
                test_account_username_text_box.Clear();
                test_account_username_text_box.SendKeys("autoTestAccount" + account_number);
                test_account_password_text_box.Clear();
                test_account_password_text_box.SendKeys("test");
                Thread.Sleep(5000);

                test_account_login_button.Click();
                Thread.Sleep(5000);
               
                String current_URL = driver.Url;
                Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));

                //Signout button
                IWebElement sign_out_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
                sign_out_button.Click();
               
               Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                Console.WriteLine("SignupPage login create account: Pass - Error:  " + e);
                Console.WriteLine("May need to change account number to a number that has not been used.");
            }
            
        }


        [Test]
        //Fail login test after account creation
        public void login_create_account_fail() 
        {
            //Signin link loaded
            try
            {
                IWebElement signin_link = driver.FindElement(By.CssSelector("body>div>div>form>a"));
                signin_link.Click();
                Thread.Sleep(4000);

            }
            catch (Exception e)
            {
                Console.WriteLine("SignupPage login create account - Error:  " + e);
            }

            //Create new account w/ failed credentials
            try
            {
                IWebElement test_account_username_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
                IWebElement test_account_password_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
                IWebElement test_account_login = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));
                test_account_username_text_box.Clear();
                test_account_username_text_box.SendKeys("failTest");
                test_account_password_text_box.Clear();
                test_account_password_text_box.SendKeys("failTest");
                Thread.Sleep(5000);

                test_account_login.Click();
                Thread.Sleep(5000);
                String current_URL = driver.Url;
                Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));

            }
            catch (Exception e)
            {
                Console.WriteLine("SignupPage login create account: Fail - Error:  " + e);
            }

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}



