using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using WordpressAutomationSpecFlow;

namespace WordpressAutomationSpecFlow
{
    [Binding]
   internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            WebBrowser.CurrentChromeWindow.Navigate().GoToUrl("http://localhost:15662/wp-login.php");
            WebBrowser.CurrentChromeWindow.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            WebBrowser.CurrentChromeWindow.Close();
        }
    }
}
