using OpenCartTestsTeamWork.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpenCartTestsTeamWork.Pages.DashboardPage
{
    public class DashboardPageElementMap : BasePageElementMap
    {
        public IWebElement OpenCartLink
        {
            get
            {
                return GetElement(By.XPath("//*[@id='footer']/a"));
            }
        }

        public IWebElement HomePageHeading
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }

        }
    }
}
