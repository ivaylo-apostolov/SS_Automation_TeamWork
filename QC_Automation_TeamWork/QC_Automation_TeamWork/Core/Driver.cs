using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace QC_Automation_TeamWork.Core
{
    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait browserWait;
        private const int defaultExplicitWait = 15;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("Webdriver is not started! Call StartBrowser method first!");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browser == null || browserWait == null)
                {
                    throw new NullReferenceException("WebDriver is not started or Wait object is not initialized!");
                }

                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        internal static void StartBrowser()
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.FullScreen();

            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultExplicitWait));
        }

        internal static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;

            BrowserWait = null;
        }
    }
}
