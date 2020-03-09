using System;
using System.IO;
using System.Threading;
using KM_Bank.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KM_Bank.Tests
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        /* 
        Login Credentials with username:"test" and password:"test"
        Test should pass
        */
        [Test]
        public void Login_user_with_correct_credentials()
        {
            var homePage = new HomePage(driver);
            homePage.setUsername("test");
            homePage.setPassword("test");
            homePage.GoToWelcomePage();

            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));
        }

        /* 
       Login Credentials with username:"testFail" and password:"testFail"
       Test should fail
       */
        [Test]
        public void Login_user_with_incorrect_credentials()
        {
            var homePage = new HomePage(driver);
            homePage.setUsername("testFail");
            homePage.setPassword("testFail");
            homePage.GoToWelcomePage();

            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/welcome.php?login=success"));
        }


        /* 
        Create account and bring user to home page
        Test should pass
        */
        [Test]
        public void Create_account()
        {
            var homePage = new HomePage(driver);
            var signupPage = new SignupPage(driver);
            homePage.GoToSignupPage();
            Thread.Sleep(1000);
            signupPage.createAccountUsername("autoTest4");
            signupPage.createAccountEmailAddress("autoTest4@gmail.com");
            signupPage.createAccountPassword("test4");
            signupPage.createRepeatAccountPassword("test4");
            signupPage.GoToWelcomePage();

            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php?signup=success"));

        }

        /* 
        Create account but passwords do not match
        Test should fail
        */
        [Test]
        public void Create_account_password_mismatch()
        {
            var homePage = new HomePage(driver);
            var signupPage = new SignupPage(driver);
            homePage.GoToSignupPage();
            Thread.Sleep(1000);
            signupPage.createAccountUsername("autoTest4");
            signupPage.createAccountEmailAddress("autoTest4@gmail.com");
            signupPage.createAccountPassword("test6");
            signupPage.createRepeatAccountPassword("test4");
            signupPage.GoToWelcomePage();

            String current_URL = driver.Url;
            Assert.That(current_URL, Is.EqualTo("http://www.kevinstevenmoreno.com/projects/KM_Bank_DB/index.php?signup=success"));

        }
    }
}