using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.DemoPage
{
    public class DemoPage : BasePage<DemoPageElementMap>
    {
        //private string pageUrl = "https://www.opencart.com/index.php?route=cms/demo/";

        //internal void Navigate()
        //{
        //    Driver.Browser.Navigate().GoToUrl(pageUrl);
        //}

        internal void ClickAdministrationSection()
        {
            Map.AdministrationSection.Click();
        }
    }
}

