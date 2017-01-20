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
   class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {

        }

        [AfterScenario("closeAfter")]
        public static void AfterScenario()
        {
            WebBrowser.CurrentChromeWindow.Close();
        }
    }
}
