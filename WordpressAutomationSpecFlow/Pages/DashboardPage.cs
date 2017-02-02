using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomationSpecFlow.Pages
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var titleDashboard = "Dashboard ‹ Learning Automation Framework Pluralsight — WordPress";
                if(titleDashboard.Equals(WebBrowser.CurrentChromeWindow.Title))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
