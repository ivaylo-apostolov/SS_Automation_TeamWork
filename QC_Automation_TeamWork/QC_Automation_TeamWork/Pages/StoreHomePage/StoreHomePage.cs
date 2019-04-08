using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreHomePage
{
    public class StoreHomePage : BasePage<StoreHomePageElementMap>
    {
        private string pageUrl = "https://demo.opencart.com/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageUrl);
        }

        internal void ClickCamerasButton()
        {
            Map.CamerasButton.Click();
        }
    }
}
