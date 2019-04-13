using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartHomePage : BasePage<OpenCartHomePageElementMap, OpenCartHomePageValidator>
    {
        private string pageURL = "http://opencart.com/";

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        public OpenCartLoginPage ClickLoginButton()
        {
            Map.LoginButton.Click();

            return new OpenCartLoginPage();
        }
    }
}
