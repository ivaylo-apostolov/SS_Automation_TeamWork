using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartPinSecurityCheckPage
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
