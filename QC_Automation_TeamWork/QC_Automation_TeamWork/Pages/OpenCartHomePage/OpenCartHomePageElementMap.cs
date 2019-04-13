using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
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
