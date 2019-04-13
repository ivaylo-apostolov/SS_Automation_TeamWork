using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
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

