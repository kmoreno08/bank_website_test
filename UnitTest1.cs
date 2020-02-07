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
    class test_test
    {
        //IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            //driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {

        //    Signup page
        //    this.driver.Navigate().GoToUrl(@"http://localhost/KM_bank/signup.php");
        //    Thread.Sleep(5000);

        //    Test Signup footer
        //    IWebElement signup_footer_facebook = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(1)"));

        //    signup_footer_facebook.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(8000);

        //    IWebElement signup_footer_insta = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(2)"));
        //    signup_footer_insta.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement signup_footer_linkedin = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(3)"));
        //    signup_footer_linkedin.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement signup_footer_pinterest = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(4)"));
        //    signup_footer_pinterest.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement signup_footer_twitter = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(5)"));
        //    signup_footer_twitter.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement signup_footer_youtube = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(6)"));
        //    signup_footer_youtube.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    sign -in page
        //     IWebElement signup_signin = driver.FindElement(By.CssSelector("body>div>div>form>a"));
        //    signup_signin.Click();
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    Signup - Create account
        //    IWebElement signup_username_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(2)"));
        //    IWebElement signup_email_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=text]:nth-child(4)"));
        //    IWebElement signup_pass_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(6)"));
        //    IWebElement signup_pass_repeat_text_box = driver.FindElement(By.CssSelector("body>div>div>form>input[type=password]:nth-child(8)"));
        //    IWebElement signup_login = driver.FindElement(By.CssSelector("body>div>div>form>input[type=submit]:nth-child(9)"));

        //    signup_username_text_box.Clear();
        //    signup_username_text_box.SendKeys("autoTestAccount5");

        //    signup_email_text_box.Clear();
        //    signup_email_text_box.SendKeys("autoTestAccount5@gmail.com");

        //    signup_pass_text_box.Clear();
        //    signup_pass_text_box.SendKeys("test");

        //    signup_pass_repeat_text_box.Clear();
        //    signup_pass_repeat_text_box.SendKeys("test");

        //    signup_login.Click();
        //    Thread.Sleep(5000);





        //    Login page -Login with created test account
        //    IWebElement test_account_username_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
        //    IWebElement test_account_password_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
        //    IWebElement test_account_login = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));
        //    test_account_username_text_box.Clear();
        //    test_account_username_text_box.SendKeys("autoTestAccount5");

        //    test_account_password_text_box.Clear();
        //    test_account_password_text_box.SendKeys("test");
        //    Thread.Sleep(5000);

        //    test_account_login.Click();
        //    Thread.Sleep(10000);


        //    Welcome page footer
        //    IWebElement welcome_facebook = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(1)>i"));
        //    welcome_facebook.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement welcome_instagram = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(2)>i"));
        //    welcome_instagram.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement welcome_linkedin = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(3)>i"));
        //    welcome_linkedin.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement welcome_pinterest = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(4)>i"));
        //    welcome_pinterest.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement welcome_twitter = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(5)>i"));
        //    welcome_twitter.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);

        //    IWebElement welcome_youtube = driver.FindElement(By.CssSelector("body>footer>div>div>a:nth-child(6)>i"));
        //    welcome_youtube.Click();
        //    Thread.Sleep(6000);
        //    this.driver.Navigate().Back();
        //    Thread.Sleep(6000);


        //    Welcome Page -change account amount
        //    IWebElement account_text_box = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=number]:nth-child(2)"));

        //    account_text_box.Clear();
        //    account_text_box.SendKeys("824");

        //    IWebElement submit_amount_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>input[type=submit]:nth-child(4)"));

        //    submit_amount_button.Click();
        //    Thread.Sleep(5000);


        //    IWebElement sign_out_button = driver.FindElement(By.CssSelector("body>div.infobox-img>div>div>div>form>a>input[type=button]"));
        //    sign_out_button.Click();
        //    Thread.Sleep(5000);






        }

        [TearDown]
        public void closeBrowser()
        {
           // driver.Close();
        }

    }
}
