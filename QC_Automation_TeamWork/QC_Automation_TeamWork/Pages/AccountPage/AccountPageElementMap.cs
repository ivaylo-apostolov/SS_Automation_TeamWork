using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class AccountPageElementMap : BasePageElementMap
    {
        public IWebElement PageHeading
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }
    }
}
