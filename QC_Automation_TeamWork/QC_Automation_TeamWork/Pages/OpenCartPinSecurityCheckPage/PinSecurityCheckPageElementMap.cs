using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class PinSecurityCheckPageElementMap : BasePageElementMap
    {
        public IWebElement Pincode
        {
            get
            {
                return GetElement(By.Id("input-pin"));
            }
        }
        public IWebElement ContinueButton

        {
            get
            {
                return GetElement(By.CssSelector(".btn.btn-primary.btn-lg"));
            }
        }
    }
}
