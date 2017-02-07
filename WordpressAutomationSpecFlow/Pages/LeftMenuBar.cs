using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WordpressAutomationSpecFlow.Pages
{
    public class LeftMenuBar
    {
        public static void ClickOnPosts()
        {
            WebBrowser.CurrentChromeWindow.FindElementByLinkText("Posts").Click();
        }

        public static void ClickAddNew()
        {
            WebBrowser.CurrentChromeWindow.FindElementByLinkText("Add New").Click();
        }
    }
}
