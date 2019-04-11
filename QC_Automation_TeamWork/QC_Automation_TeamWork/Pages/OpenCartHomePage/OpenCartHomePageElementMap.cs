using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePageElementMap : BasePageElementMap
    {
        public IWebElement DemoHeader
        {
            get
            {
                return GetElement(By.XPath("//*[@id='navbar-collapse-header']/ul/li[2]/a"));
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
