using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

            ChromeDriver chrome = new ChromeDriver();
            
            chrome.Navigate().GoToUrl("http://localhost:15662/wp-login.php");
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            var title = "Learning Automation Framework Pluralsight › Log In";
            Assert.AreEqual(title, chrome.Title);
            //Assert.That(chrome.Title, IsEqualTo(title).IgnoreCase);
            ScenarioContext.Current.Add("browser", chrome);

        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //var userNameField = 
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            chrome.FindElementById("user_login").SendKeys("mariusz");
            //var passwordField = 
            chrome.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
            
        }
        
        [Given(@"I have entered unvalid user name")]
        public void GivenIHaveEnteredUnvalidUserName()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //var userNameField = 
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            chrome.FindElementById("user_login").SendKeys("invalidusername");
            //var passwordField = 
            chrome.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
        }
        
        [Given(@"I have entered invalid password")]
        public void GivenIHaveEnteredInvalidPassword()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.FindElementById("user_login").SendKeys("mariusz");
            chrome.FindElementById("user_pass").SendKeys("invalidpassword");
        }
        
        [Given(@"I have entered invalid credentials")]
        public void GivenIHaveEnteredInvalidCredentials()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.FindElementById("user_login").SendKeys("invalidusername");
            chrome.FindElementById("user_pass").SendKeys("invalidpassword");
        }
        
        [When(@"I press Log in button")]
        public void WhenIPressLogInButton()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            chrome.FindElementByXPath("//*[@id='wp-submit']").Click();
        }
        
        [Then(@"I should be able to see my dashboard page")]
        public void ThenIShouldBeAbleToSeeMyDashboardPage()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            var titleDashboard = "Dashboard ‹ Learning Automation Framework Pluralsight — WordPress";
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            Assert.AreEqual(titleDashboard, chrome.Title);
        }
        
        [Then(@"I should be able to see an error message '(.*)'")]
        public void ThenIShouldBeAbleToSeeAnErrorMessage(string errorMessage)
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //var actualErrorMessage = chrome.FindElement((By.))
            var actualErrorMessage = chrome.FindElementById("login_error").Text;
            Assert.AreEqual(errorMessage, actualErrorMessage);
        }
    }
}
