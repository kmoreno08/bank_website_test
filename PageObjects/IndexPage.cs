using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KM_Bank
{
    [TestFixture]
    public class IndexPage
    {
        IWebDriver driver;
       

        [SetUp]
        public void open_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl(@"http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php");
            Thread.Sleep(1000);
           
        }



        [Test]
        public void carousel_arrow_buttons()
        {
                try
                {

                    //Thread.Sleep(2000);
                   
                    IWebElement right_button = driver.FindElement(By.CssSelector("body>div>div.carousel>button.carousel__button.carousel__button--right>i"));

                    
                    right_button.Click();
                    Thread.Sleep(1000);
                 
                    right_button.Click();
                    Thread.Sleep(1000);
                  
                    right_button.Click();
                    Thread.Sleep(1000);
                  
                    right_button.Click();
                    Thread.Sleep(1000);
                   
                    right_button.Click();
                    Thread.Sleep(1000);
                  
                    right_button.Click();
                    Thread.Sleep(1000);
                   
                    right_button.Click();
                    Thread.Sleep(1000);
                   
                    right_button.Click();
                    Thread.Sleep(1000);
                
                }
                catch (Exception e)
                {
                    Console.WriteLine("Carousel right button - Error:  " + e); 
                }

            //Left arrow button
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    IWebElement left_button = driver.FindElement(By.CssSelector("body>div>div.carousel>button.carousel__button.carousel__button--left>i"));
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                    left_button.Click();
                    Thread.Sleep(1000);
                   
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Carousel left button - Error:  " + e);
                }
            }
            Thread.Sleep(1000);
        }
    
        [Test]
        public void carousel_indicators()
        {
            //Carousel Indicators
            for (int i = 2; i <= 2; i++)
                {
                    try
                    {
                IWebElement carousel_ind_button_1 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(1)"));
                IWebElement carousel_ind_button_2 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(2)"));
                IWebElement carousel_ind_button_3 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(3)"));
                IWebElement carousel_ind_button_4 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(4)"));
                IWebElement carousel_ind_button_5 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(5)"));
                IWebElement carousel_ind_button_6 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(6)"));
                IWebElement carousel_ind_button_7 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(7)"));
                IWebElement carousel_ind_button_8 = driver.FindElement(By.CssSelector("body>div>div.carousel__nav>button:nth-child(8)"));
                carousel_ind_button_8.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_7.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_6.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_5.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_4.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_3.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_2.Click();
                    Thread.Sleep(1000);
                    carousel_ind_button_1.Click();
                    Thread.Sleep(1000);
                    break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Carousel Indicator button - Error:  " + e);
                }
            }
 
        }

        [Test]
        public void news_grid_buttons()
        {

            // Grid buttons
            // 1 of 3
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    IWebElement grid_button_1 = driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-1-container>div.grid-button-1"));
                    grid_button_1.Click();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page grid button 1 0f 3 - Error:  " + e);
                }
            }
            //Page reloads after click
            Thread.Sleep(1000);

            // 2 of 3
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    IWebElement grid_button_2 = driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-2-container>div.grid-button-2"));
                    grid_button_2.Click();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page grid button 2 0f 3 - Error:  " + e);
                }
            }

            // 3 of 3
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    IWebElement grid_button_3 = driver.FindElement(By.CssSelector("body>div>div.total-grid-container>div.grid-wrapper>div.grid-3-container>div.grid-button-3"));
                    grid_button_3.Click();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page grid button 3 0f 3 - Error:  " + e);
                }
            }
        }

        //Login box - Enroll Link
        [Test]
        public void loginbox_enrollLink()
        {
            try
            {
                IWebElement enroll_link = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>a"));
                enroll_link.Click();
                Thread.Sleep(1000);

                //Check if url is correct
                String signup_URL = driver.Url;
                Assert.That(signup_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/signup.php"));

            }
            catch (Exception e)
            {
                Console.WriteLine("Index Page Enroll Link - Error:  " + e);
            }
        }
        //Log in with active credentials
        [Test]
        public void loginbox_user_pass()
        {
            
            //Elements are loaded
            for (int i = 0; i <= 2; i++)
            {
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

                    //Check if url is correct
                    String current_URL = driver.Url;
                    Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page Log in User Fail - Error:  " + e);
                }
            }

        }
        [Test]
        //Test should fail
        public void loginbox_user_fail()
        {
            
                try
                {
                    IWebElement username_fail_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=text]:nth-child(2)"));
                    IWebElement password_fail_text_box = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=password]:nth-child(4)"));
                    IWebElement login_button_fail = driver.FindElement(By.CssSelector("body>div>div.loginbox>form>input[type=submit]:nth-child(5)"));

                    username_fail_text_box.Clear();
                    username_fail_text_box.SendKeys("testFail");

                    password_fail_text_box.Clear();
                    password_fail_text_box.SendKeys("testFail");
                    Thread.Sleep(1000);

                    login_button_fail.Click();
                    Thread.Sleep(1000);

                    //Log in fail 
                    String current_URL = driver.Url;
                     Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));
            }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page Log in User Fail - Error:  " + e);
                }
            
        }

        //Index Page Footer
        [Test]
        public void footer_icons()
        {
            //Footer is loaded
            for (int i = 0; i <= 2; i++)
            {

                try
                {

                    IWebElement footer_facebook = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(1)>i"));
                    footer_facebook.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement footer_insta = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(2)>i"));
                    footer_insta.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement footer_linkedin = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(3)>i"));
                    footer_linkedin.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement footer_pinterest = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(4)>i"));
                    footer_pinterest.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement footer_twitter = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(5)>i"));
                    footer_twitter.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);

                    IWebElement footer_youtube = driver.FindElement(By.CssSelector("body>div>footer>div>div>a:nth-child(6)>i"));
                    footer_youtube.Click();
                    this.driver.Navigate().Back();
                    Thread.Sleep(1000);
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Index Page Footer icons - Error:  " + e);
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
