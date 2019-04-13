using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreHomePageElementMap : BasePageElementMap
    {
        public IWebElement CamerasButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu']/div[2]/ul/li[7]/a"));
            }
        }

        public IWebElement MacBookLink
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/h4/a"));
            }
        }
    }
}
