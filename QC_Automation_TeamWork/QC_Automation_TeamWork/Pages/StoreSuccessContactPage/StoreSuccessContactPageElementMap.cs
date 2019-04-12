using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
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
