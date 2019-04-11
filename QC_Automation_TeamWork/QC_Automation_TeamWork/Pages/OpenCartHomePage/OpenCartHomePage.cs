using QC_Automation_TeamWork.Core;

using QC_Automation_TeamWork.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
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
