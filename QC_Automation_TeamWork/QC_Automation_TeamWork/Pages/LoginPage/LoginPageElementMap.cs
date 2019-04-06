using OpenCartTestsTeamWork.Core;
using OpenQA.Selenium;

namespace OpenCartTestsTeamWork.Pages.LoginPage
{
    public class LoginPageElementMap : BasePageElementMap
    {
        public IWebElement PasswordElement
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement UsernameElement
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return GetElement(By.CssSelector("button.btn"));
            }
        }
    }
}
