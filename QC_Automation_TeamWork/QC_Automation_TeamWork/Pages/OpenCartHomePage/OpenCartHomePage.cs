using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePage : BasePage<OpenCartHomePageElementMap, OpenCartHomePageValidator>
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
