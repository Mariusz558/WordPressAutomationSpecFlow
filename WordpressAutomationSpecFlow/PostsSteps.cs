using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support;

namespace WordpressAutomationSpecFlow
{
    [Binding]
    public class PostsSteps : Steps
    {
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            //ChromeDriver chrome = new ChromeDriver();
            //ScenarioContext.Current.Add("browser", chrome);

            Given(string.Format("I am on the login page"));
            Given(string.Format("I have entered my credentials"));
            When(string.Format("I press Log in button"));
            Then(string.Format("I should be able to see my dashboard page"));

        }

        [Given(@"I am on the new post page")]
        public void GivenIAmOnTheNewPostPage()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.Manage().Window.Maximize();
            //chrome.FindElementByXPath(".//*[@id='menu-posts']/a/div[3]").Click(); //refactor: hover over
            chrome.FindElementByLinkText("Posts").Click();
            chrome.FindElementByLinkText("Add New").Click(); //refactor: find
            var title = "Add New Post ‹ Learning Automation Framework Pluralsight — WordPress";
            Assert.AreEqual(title, chrome.Title);
        }

        [When(@"I enter my post")]
        public void WhenIEnterMyPost()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //chrome.SwitchTo().Frame("wpbody-content");
            //chrome.SwitchTo().Frame(chrome.FindElement(By.Id("wpbody-content")).SendKeys("Test Title"));
            chrome.FindElement(By.Id("title")).SendKeys("Test Title");
            //chrome.SwitchTo().DefaultContent();
            chrome.FindElementById("content_ifr").SendKeys("Test Content");
            chrome.FindElementById("publish").Click();
        }

        [Then(@"I should see it on the Posts page")]
        public void ThenIShouldSeeItOnThePostsPage()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click();
            //chrome.FindElements(By.TagName("tr"));

        }
    }
}
