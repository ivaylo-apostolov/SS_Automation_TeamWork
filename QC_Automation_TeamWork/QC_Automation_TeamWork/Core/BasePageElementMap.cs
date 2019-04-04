using OpenQA.Selenium;
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

        public IWebDriver GetElement(By by)
        {
            return Browser.FindElement(by);
        }
    }
}
