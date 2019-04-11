using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
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
