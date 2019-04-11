using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


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
