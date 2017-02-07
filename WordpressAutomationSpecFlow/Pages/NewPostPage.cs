using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WordpressAutomationSpecFlow.Pages
{
    public class NewPostPage
    {
        public static bool IsAt
        {
            get
            {
                var title = "Add New Post ‹ Learning Automation Framework Pluralsight — WordPress";

                //WebBrowser.CurrentChromeWindow.FindElementByLinkText("Posts").Click();

                LeftMenuBar.ClickOnPosts();
                LeftMenuBar.ClickAddNew();

                ////WebBrowser.CurrentChromeWindow.FindElementByLinkText("Add New").Click(); //refactor: find

                if(title.Equals(WebBrowser.CurrentChromeWindow.Title))
                {
                    return true;
                }
                return false;
            }
        }

        public static void AddNewPost()
        {
            WebBrowser.CurrentChromeWindow.FindElement(By.Id("title")).SendKeys("Test Title");
            WebBrowser.CurrentChromeWindow.SwitchTo().Frame("content_ifr");
            WebBrowser.CurrentChromeWindow.SwitchTo().ActiveElement().SendKeys("Test Content");
            WebBrowser.CurrentChromeWindow.SwitchTo().DefaultContent();
            Thread.Sleep(3000);
            WebBrowser.CurrentChromeWindow.FindElement(By.Id("publish")).Click();
        }
    }
}
