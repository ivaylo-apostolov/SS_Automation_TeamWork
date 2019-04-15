using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class OrdersPageElementMap : BasePageElementMap
    {
        public IWebElement CustomerFilter
        {
            get
            {
                return GetElement(By.Id("input-customer"));
            }
        }

        public IWebElement FilterButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='button-filter']/i"));
            }
        }

        public IWebElement FilteredCustomer
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-order']/table/tbody/tr[1]/td[3]"));
            }
        }

    }
}
