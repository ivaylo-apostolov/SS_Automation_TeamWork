using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreSearchResultPageElementMap : BasePageElementMap
    {
        public IWebElement SearchResult
        {
            get
            {
                return GetElement(By.PartialLinkText("iPhone"));
            }
        }
        
    }
}
