using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome; // bez tego nie zadziala przegladarka
using WordpressAutomationSpecFlow;

namespace WordpressAutomationSpecFlow
{
    public static class WebBrowser
    {
        private const string Key = "browser";

        public static ChromeDriver CurrentChromeWindow // property o typie przegladarki, ktora chcemy wykorzystac w tescie, tworzy automatycznie ScenarioContext
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key)) // jesli krok zawiera ScenarioContext zwracamy instancje przegladarki (linia 27)
                {
                    // jesli nie zawiera - tworzymy instancje przegladarki
                    var chrome = new ChromeDriver();

                    ScenarioContext.Current[Key] = chrome; 
                }

                return ScenarioContext.Current[Key] as ChromeDriver; //zastepuje var chrome = ScenarioContext.Current["browser"] as ChromeDriver; w kazdym kroku
            }
        }
    }
}
