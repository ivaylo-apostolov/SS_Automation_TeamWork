using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePage : BasePage<OpenCartHomePageElementMap>
    {
        private string pageUrl = "https://www.opencart.com/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageUrl);
        }

        internal void ClickDemoButton()
        {
            Map.DemoHeader.Click();
        }
    }
}
