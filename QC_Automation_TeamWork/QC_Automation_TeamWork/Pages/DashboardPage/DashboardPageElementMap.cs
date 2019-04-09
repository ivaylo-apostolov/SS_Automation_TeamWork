﻿using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QC_Automation_TeamWork.Pages.DashboardPage
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

        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[2]/a/span"));
            }
        }
    }
}
