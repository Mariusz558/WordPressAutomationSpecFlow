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
            Assert.AreEqual(chrome.Title, title);
            ScenarioContext.Current.Add("browser", chrome);

        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //var userNameField = 
            chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            chrome.FindElementById("user_login").SendKeys("mariusz");
            //var passwordField = 
            chrome.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
            
        }
        
        [Given(@"I have entered unvalid user name")]
        public void GivenIHaveEnteredUnvalidUserName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered invalid password")]
        public void GivenIHaveEnteredInvalidPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered invalid credentials")]
        public void GivenIHaveEnteredInvalidCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Log in button")]
        public void WhenIPressLogInButton()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //var logInButton = 
            chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            chrome.FindElementByXPath("//*[@id='wp-submit']").Click();
        }
        
        [Then(@"I should be able to see my dashboard page")]
        public void ThenIShouldBeAbleToSeeMyDashboardPage()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            
            var titleDashboard = "Dashboard ‹ Learning Automation Framework Pluralsight — WordPress";
            chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            Assert.AreEqual(chrome.Title, titleDashboard);
        }
        
        [Then(@"I should be able to see an error message ""(.*)""")]
        public void ThenIShouldBeAbleToSeeAnErrorMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
