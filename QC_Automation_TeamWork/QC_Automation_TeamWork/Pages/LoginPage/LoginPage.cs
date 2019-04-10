using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data.Models;

namespace QC_Automation_TeamWork.Pages
{
    public class LoginPage : BasePage<LoginPageElementMap, LoginPageValidator>
    {
        private string pageURL = "https://demo.opencart.com/admin/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        internal void TypeUsername(string username)
        {
            var usernameElement = Map.UsernameElement;
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
            var element = Map.LoginButton;
            element.Click();
        }

        public DashboardPage Login(User user)
        {
            TypeUsername(user.Username);
            TypePassword(user.Password);
            ClickLoginButton();

            return new DashboardPage();
        }

        public string GetUsernameInputValue()
        {
            return Map.UsernameElement.GetAttribute("value");
        }
    }
}
