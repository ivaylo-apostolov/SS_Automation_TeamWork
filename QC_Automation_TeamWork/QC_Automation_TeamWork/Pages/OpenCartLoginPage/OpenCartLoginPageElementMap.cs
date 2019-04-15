using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
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
    
        public IWebElement ForgottenPasswordElement
        {
            get
            {
                return GetElement(By.XPath("//*[@id='account-login']/div[2]/div/div[1]/form/div[3]/div[2]/a"));
            }
        }
        
        public IWebElement ResetPasswordMessage
        {
            get
            {
                return GetElement(By.XPath("//*[@id='account-login']/div[2]/div[1]"));
            }
        }
    }
 }

