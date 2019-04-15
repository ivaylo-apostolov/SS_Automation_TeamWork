using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartHomePageElementMap : BasePageElementMap
    {
        public IWebElement OpenCartLink
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='navbar-collapse-header']/div/a[1]"));
            }
        }

        public IWebElement HomePageHeading
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }


        public IWebElement NewsletterButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='newsletter']/div/div/button"));
            }
        }

    }
}