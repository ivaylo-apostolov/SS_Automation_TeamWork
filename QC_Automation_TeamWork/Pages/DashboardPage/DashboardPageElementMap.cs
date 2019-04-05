using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPageElementMap : BasePageElementMap
    {
        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[2]/a/span"));
            }
        }
    }
}