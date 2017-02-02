using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WordpressAutomationSpecFlow.Pages
{
    class AllPostsPage
    {
        public static bool PostExists
        {
            get
            {
                WebBrowser.CurrentChromeWindow.FindElementByXPath(".//*[@id='menu-posts']/ul/li[2]/a").Click();
                IList<IWebElement> postsList = (WebBrowser.CurrentChromeWindow.FindElements(By.ClassName("row-title")));
                if(postsList.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool IsAt
        {
            get
            {
                WebBrowser.CurrentChromeWindow.FindElementByLinkText("Posts").Click();

                var title = "Posts ‹ Learning Automation Framework Pluralsight — WordPress";
                if(title.Equals(WebBrowser.CurrentChromeWindow.Title))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
