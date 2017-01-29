using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WordpressAutomationSpecFlow.Pages
{
   public class LoginPage
    {
        public static bool IsAt
        {
            get
            {
                var title = "Learning Automation Framework Pluralsight › Log In";
                if (title.Equals(WebBrowser.CurrentChromeWindow.Title))
                    return true;
                return false;
            }
        }
        
       public static void PressLogInButton()
       {
            WebBrowser.CurrentChromeWindow.FindElementByXPath("//*[@id='wp-submit']").Click();
       }
        
       public static void EnterValidUserName()
       {
           WebBrowser.CurrentChromeWindow.FindElementById("user_login").SendKeys("mariusz");
       }
       
       public static void EnterValidPassword()
       {
           WebBrowser.CurrentChromeWindow.FindElementById("user_pass").SendKeys("dkz10L02VhgmklfRE@");
       }
       
       public static void EnterInvalidUserName()
       {
           WebBrowser.CurrentChromeWindow.FindElementById("user_login").SendKeys("invalidusername");
       }
       
       public static void EnterInvalidPassword()
       {
           WebBrowser.CurrentChromeWindow.FindElementById("user_pass").SendKeys("invalidpassword");
       }

    }
}
