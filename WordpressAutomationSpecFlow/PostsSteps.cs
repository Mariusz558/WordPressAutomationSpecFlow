﻿using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

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
            chrome.FindElementByXPath(".//*[@id='menu-posts']/a/div[3]").Click(); //refactor: hover over
            chrome.FindElementByLinkText("Posts").Click();
            chrome.FindElementByLinkText("Add New").Click(); //refactor: find
            
            /*// hover over menu
                // get Posts menu item

            Actions action = new Actions(chrome);
            IWebElement postsMenuItem = chrome.FindElementById("menu-posts");

            action.MoveToElement(postsMenuItem).Click().Build().Perform();

            //WebDriverWait wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(5));
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Add New")));

            IWebElement addNewMenuItem = chrome.FindElementByLinkText("Add New");
            action.MoveToElement(addNewMenuItem).Click().Build().Perform(); ;*/

            // verify wehter landed on the correct page
            var title = "Add New Post ‹ Learning Automation Framework Pluralsight — WordPress";
            Assert.AreEqual(title, chrome.Title);
        }

        [When(@"I enter my post")]
        public void WhenIEnterMyPost()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.FindElement(By.Id("title")).SendKeys("Test Title");
            chrome.SwitchTo().Frame("content_ifr");
            chrome.SwitchTo().ActiveElement().SendKeys("Test Content");
            chrome.SwitchTo().DefaultContent();
            Thread.Sleep(3000);
            chrome.FindElement(By.Id("publish")).Click();

            //var contentFrame = firefox.FindElement(By.Id("content_ifr"));
            //contentFrame.SendKeys("Test Content");
            //firefox.SwitchTo().Frame(firefox.FindElement(By.Id("content_ifr")).SendKeys("Test Content"));
            //firefox.FindElement(By.XPath(".//*[@id='tinymce']/p")).SendKeys("Test Content");
            //Thread.Sleep(10);
            //chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //WebDriverWait publishButtonWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(2));
            //ChromeWebElement publishButton = publishButtonWait.until(ExpectedConditions.ElementToBeClickable(By.Id("publish")));
            //chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //Thread.Sleep(10);
        }

        [Then(@"I should see it on the Posts page")]
        public void ThenIShouldSeeItOnThePostsPage()
        {
            //bool postsListNotEmpty = Assert.IsNotEmpty(postsList);

            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            chrome.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click();
            IList<IWebElement> postsList = (chrome.FindElements(By.ClassName("row-title")));
            Assert.IsNotEmpty(postsList, "Post does not exist. Fuck you!");
            /*if(postsList.Count>0){//jesli jest kilka postow petla for each
                //var postToTrash = firefox.FindElements(By.TagName("row-title"))[0];
                IList<IWebElement> checkBoxes = chrome.FindElements(By.Name("post[]"));
                var postToTrash = checkBoxes[0];
                postToTrash.Click();
                var actionsMenu = chrome.FindElement(By.Id("bulk-action-selector-top"));
                var selectElement = new SelectElement(actionsMenu);
                selectElement.SelectByText("Move to Trash");
                var applyButton = chrome.FindElement(By.Id("doaction"));
                applyButton.Click();
            }*/

        }

        [Given(@"I am on the dashboard page")]
        public void GivenIAmOnTheDashboardPage()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            var titleDashboard = "Dashboard ‹ Learning Automation Framework Pluralsight — WordPress";
            //chrome.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            Assert.AreEqual(titleDashboard, chrome.Title);
        }

        [Given(@"There is at least one post created")]
        public void GivenThereIsAtLeastOnePostCreated()
        {
            // go to the post page
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //chrome.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click(); nie dziala
            chrome.FindElementByLinkText("Posts").Click();

            // check amount of posts on the posts page
            IList<IWebElement> postsList = (chrome.FindElements(By.ClassName("row-title")));
            Assert.IsNotEmpty(postsList, "Post does not exist. Fuck you!");
        }

        [When(@"I am on the posts page")]
        public void WhenIGoToThePostPage()
        {
            // go to the post page
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;
            //chrome.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click(); nie dziala
            chrome.FindElementByLinkText("Posts").Click();
        }

        [Then(@"I should be able to delete selected post")]
        public void ThenIShouldBeAbleToDeleteSelectedPost()
        {
            var chrome = ScenarioContext.Current["browser"] as ChromeDriver;

            //check posts
            IList<IWebElement> checkBoxes = chrome.FindElements(By.Name("post[]"));
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                var postToTrash = checkBoxes[i];
                postToTrash.Click();
            }
            //var postToTrash = checkBoxes[0];
            //postToTrash.Click();

            //Thread.Sleep(9000);

            // trash checked posts
            var actionsMenu = chrome.FindElement(By.Id("bulk-action-selector-top"));
            var selectElement = new SelectElement(actionsMenu);
            selectElement.SelectByText("Move to Trash");
            var applyButton = chrome.FindElement(By.Id("doaction"));
            applyButton.Click();
        }


        }

    }

