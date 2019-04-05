using OpenCartTests.Core;
using OpenQA.Selenium;

namespace OpenCartTests.Pages
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