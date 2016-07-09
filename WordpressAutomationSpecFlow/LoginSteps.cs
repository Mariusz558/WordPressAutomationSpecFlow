using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support;

namespace WordpressAutomationSpecFlow
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {

            //ChromeDriver chrome = new ChromeDriver();
            FirefoxDriver firefox = new FirefoxDriver();
            
            firefox.Navigate().GoToUrl("http://localhost:15662/wp-login.php");
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            var title = "Learning Automation Framework Pluralsight › Log In";
            Assert.AreEqual(title, firefox.Title);
            //Assert.That(chrome.Title, IsEqualTo(title).IgnoreCase);
            ScenarioContext.Current.Add("browser", firefox);

        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //var userNameField = 
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            firefox.FindElementById("user_login").SendKeys("mariusz");
            //var passwordField = 
            firefox.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
            
        }
        
        [Given(@"I have entered unvalid user name")]
        public void GivenIHaveEnteredUnvalidUserName()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //var userNameField = 
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            firefox.FindElementById("user_login").SendKeys("invalidusername");
            //var passwordField = 
            firefox.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
        }
        
        [Given(@"I have entered invalid password")]
        public void GivenIHaveEnteredInvalidPassword()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            firefox.FindElementById("user_login").SendKeys("mariusz");
            firefox.FindElementById("user_pass").SendKeys("invalidpassword");
        }
        
        [Given(@"I have entered invalid credentials")]
        public void GivenIHaveEnteredInvalidCredentials()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            firefox.FindElementById("user_login").SendKeys("invalidusername");
            firefox.FindElementById("user_pass").SendKeys("invalidpassword");
        }
        
        [When(@"I press Log in button")]
        public void WhenIPressLogInButton()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            firefox.FindElementByXPath("//*[@id='wp-submit']").Click();
        }
        
        [Then(@"I should be able to see my dashboard page")]
        public void ThenIShouldBeAbleToSeeMyDashboardPage()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            var titleDashboard = "Dashboard ‹ Learning Automation Framework Pluralsight — WordPress";
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            Assert.AreEqual(titleDashboard, firefox.Title);
        }
        
        [Then(@"I should be able to see an error message '(.*)'")]
        public void ThenIShouldBeAbleToSeeAnErrorMessage(string errorMessage)
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //var actualErrorMessage = chrome.FindElement((By.))
            var actualErrorMessage = firefox.FindElementById("login_error").Text;
            Assert.AreEqual(errorMessage, actualErrorMessage);
        }
    }
}
