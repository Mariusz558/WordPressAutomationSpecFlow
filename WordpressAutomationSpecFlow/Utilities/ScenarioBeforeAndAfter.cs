using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace WordpressAutomationSpecFlow
{
    [Binding]
   internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {

        }

        [AfterScenario]
        public static void AfterScenario()
        {
            WebBrowser.CurrentChromeWindow.Close();
        }
    }
}
