using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace QC_Automation_TeamWork.Core
{
    public class BasePageElementMap
    {
        protected IWebDriver Browser;
        protected WebDriverWait BrowserWait;

        public BasePageElementMap()
        {
            Browser = Driver.Browser;
            BrowserWait = Driver.BrowserWait;
        }

        public IWebElement GetElement(By by)
        {
            var t = Browser.FindElement(by);
            bool isDisplayed = BrowserWait.Until(driver => driver.FindElement(by).Displayed);
            bool isEnabled = BrowserWait.Until(driver => driver.FindElement(by).Enabled);

            if (isDisplayed && isEnabled)
            {
                return Browser.FindElement(by);
            }

            throw new ElementNotVisibleException($"Element with locator {by.ToString()} is not visible!");
        }

        public IReadOnlyCollection<IWebElement> GetElements(By by)
        {
            return BrowserWait.Until(driver => driver.FindElements(by));
        }
    }
}
