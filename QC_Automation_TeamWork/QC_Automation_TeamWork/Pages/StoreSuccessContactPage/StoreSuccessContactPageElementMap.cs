using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreSuccessContactPage
{
    public class StoreSuccessContactPageElementMap : BasePageElementMap
    {
        public IWebElement PageHeaded
        {
            get
            {
                return GetElement(By.CssSelector("#content h1"));
            }
        }
    }
}
