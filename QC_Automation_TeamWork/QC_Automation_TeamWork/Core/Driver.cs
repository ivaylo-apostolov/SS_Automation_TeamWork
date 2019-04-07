using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace QC_Automation_TeamWork.Core
{
    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait wait;

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

        public static WebDriverWait Wait
        {
            get
            {
                if (wait == null)
                {
                    throw new NullReferenceException("Webdriver is not started! Call StartBrowser method first!");
                }
                return wait;
            }
        }



        internal static void StartBrowser()
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.FullScreen();

            wait = new WebDriverWait(Browser,TimeSpan.FromSeconds(2));
        }

        internal static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            wait = null;
        }
    }
}
