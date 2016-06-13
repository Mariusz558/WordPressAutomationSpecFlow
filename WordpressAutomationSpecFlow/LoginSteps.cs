using System;
using TechTalk.SpecFlow;

namespace WordpressAutomationSpecFlow
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            ScenarioContext.Current.Pending();
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
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see my dashboard page")]
        public void ThenIShouldBeAbleToSeeMyDashboardPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see an error message ""(.*)""")]
        public void ThenIShouldBeAbleToSeeAnErrorMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
