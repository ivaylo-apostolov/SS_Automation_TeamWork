using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class OrdersElementMap : BasePageElementMap
    {
        public IWebElement OrdersButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='collapse26']/li[1]/a"));
            }
        }

        public IWebElement ViewOrderButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-order']/table/tbody/tr[1]/td[8]/div/div/a/i"));
            }
        }

        public IWebElement PrintShippingListButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div/div/a[2]/i"));
            }
        }

        public IWebElement OpenShippingList
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[1]/ul/li[9]/a"));
            }
        }
    }
}
