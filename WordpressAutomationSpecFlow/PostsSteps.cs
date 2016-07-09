using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            firefox.Manage().Window.Maximize();
            //chrome.FindElementByXPath(".//*[@id='menu-posts']/a/div[3]").Click(); //refactor: hover over
            firefox.FindElementByLinkText("Posts").Click();
            firefox.FindElementByLinkText("Add New").Click(); //refactor: find
            var title = "Add New Post ‹ Learning Automation Framework Pluralsight — WordPress";
            Assert.AreEqual(title, firefox.Title);
        }

        [When(@"I enter my post")]
        public void WhenIEnterMyPost()
        {
            var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //chrome.SwitchTo().Frame("wpbody-content");
            //chrome.SwitchTo().Frame(chrome.FindElement(By.Id("wpbody-content")).SendKeys("Test Title"));
            firefox.FindElement(By.Id("title")).SendKeys("Test Title");
            //firefox.SwitchTo().DefaultContent();
            Thread.Sleep(3000);
            //firefox.SwitchTo().Frame("content_ifr");
            //var contentFrame = firefox.FindElement(By.Id("content_ifr"));
            //contentFrame.SendKeys("Test Content");

            //firefox.SwitchTo().Frame(firefox.FindElement(By.Id("content_ifr")).SendKeys("Test Content"));
            firefox.FindElement(By.XPath(".//*[@id='tinymce']/p")).SendKeys("Test Content");
            //Thread.Sleep(10);
            //chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //WebDriverWait publishButtonWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(2));
            //ChromeWebElement publishButton = publishButtonWait.until(ExpectedConditions.ElementToBeClickable(By.Id("publish")));
            firefox.FindElement(By.Id("publish")).Click();
            //chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //Thread.Sleep(10);
        }

        [Then(@"I should see it on the Posts page")]
        public void ThenIShouldSeeItOnThePostsPage()
        {
            //var firefox = ScenarioContext.Current["browser"] as FirefoxDriver;
            //firefox.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click();
            ////chrome.FindElements(By.TagName("tr"));

        }

        [Given(@"I am on the dashboard page")]
        public void GivenIAmOnTheDashboardPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"There is at least one post created")]
        public void GivenThereIsAtLeastOnePostCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I go to the post page")]
        public void WhenIGoToThePostPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to delete selected post")]
        public void ThenIShouldBeAbleToDeleteSelectedPost()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
