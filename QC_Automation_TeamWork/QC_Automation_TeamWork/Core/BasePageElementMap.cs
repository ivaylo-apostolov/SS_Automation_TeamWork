using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace QC_Automation_TeamWork.Core
{
    public class BasePageElementMap
    {
        protected IWebDriver Browser;

        public BasePageElementMap()
        {
            Browser = Driver.Browser;
        }

        public IWebElement GetElement(By by)
        {
            return Browser.FindElement(by);
        }
    }
}
