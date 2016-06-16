using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace WordpressAutomationSpecFlow
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            var title = "Learning Automation Framework Pluralsight › Log In";
            FirefoxDriver firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("http://localhost:15662/wp-login.php");
            Assert.AreEqual(firefox.Title, title);//Assert.AreEqual(title, firefox.Title);
            //Assert.That(firefox.Title, IsEqualTo(title).IgnoreCase); //nowa forma assercji NUnit>3

        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            FirefoxDriver firefox = new FirefoxDriver();
            //var userNameField = 
            firefox.FindElementById("user_login").SendKeys("mariusz");
            //var passwordField = 
            firefox.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
            
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
            FirefoxDriver firefox = new FirefoxDriver();
            //var logInButton = 
            firefox.FindElementById("wp-submit").Click();
        }
        
        [Then(@"I should be able to see my dashboard page")]
        public void ThenIShouldBeAbleToSeeMyDashboardPage()
        {
            FirefoxDriver firefox = new FirefoxDriver();
            var welcomePanel = firefox.FindElementById("welcome-panel");
            Assert.AreEqual(welcomePanel, firefox.FindElementById("welcome-panel"));
        }
        
        [Then(@"I should be able to see an error message ""(.*)""")]
        public void ThenIShouldBeAbleToSeeAnErrorMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
