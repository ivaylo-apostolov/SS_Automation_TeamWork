using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data.Models;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartLoginPage : BasePage<OpenCartLoginPageElementMap, OpenCartLoginPageValidator>
    {
        private string pageURL = "https://demo.opencart.com/admin/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        internal void TypeEmail(string username)
        {
            var usernameElement = Map.EmailElement;
            usernameElement.Clear();
            usernameElement.SendKeys(username);
        }

        internal void TypePassword(string password)
        {
            var passwordElement = Map.PasswordElement;
            passwordElement.Clear();
            passwordElement.SendKeys(password);
        }

        internal void ClickLoginButton()
        {
            Map.LoginButton.Click();
        }


        public PinSecurityCheckPage Login(LoginWithEmail email)
        {
            TypeEmail(email.Email);
            TypePassword(email.Password);

            ClickLoginButton();

            return new PinSecurityCheckPage();
        }
    }
}
