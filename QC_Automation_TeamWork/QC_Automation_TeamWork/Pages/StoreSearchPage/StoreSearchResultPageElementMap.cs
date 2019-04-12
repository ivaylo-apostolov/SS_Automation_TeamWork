using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreSearchPage
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
