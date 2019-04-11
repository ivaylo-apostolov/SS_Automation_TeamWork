using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.LoginPage
{
    public class OpenCartLoginPageElementMap : BasePageElementMap
    {
        public IWebElement PasswordElement
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement EmailElement
        {
            get
            {
                return GetElement(By.Id("input-email"));
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
