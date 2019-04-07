using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace QC_Automation_TeamWork.Core
{
    public class BasePageElementMap
    {
        protected IWebDriver Browser;
        protected WebDriverWait Wait;
        public BasePageElementMap()
        {
            Browser = Driver.Browser;
            Wait = Driver.Wait;
        }

        public IWebElement GetElement(By by)
        {
            return Wait.Until(d => Browser.FindElement(by));
        }
    }
}
