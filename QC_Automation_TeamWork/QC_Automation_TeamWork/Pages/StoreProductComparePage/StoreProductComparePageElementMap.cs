using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreProductComparePageElementMap : BasePageElementMap
    {
        public IWebElement FirstProduct
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/table/tbody[1]/tr[1]/td[2]/a/strong"));
            }
        }

        public IWebElement SecondProduct
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/table/tbody[1]/tr[1]/td[3]/a/strong"));
            }
        }
    }
}
