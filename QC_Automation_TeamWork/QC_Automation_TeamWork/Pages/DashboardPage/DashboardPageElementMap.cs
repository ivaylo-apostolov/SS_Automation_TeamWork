﻿using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
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

        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[2]/a/span"));
            }
        }

        public IWebElement AdminHeader
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div/h1"));
            }
        }

        public IWebElement LoggedUserName
        {
            get
            {
                return GetElement(By.XPath("//a[contains(text(),'demo demo ')]"));
            }
        }

        public IWebElement HomePageHeading
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }

        public IWebElement OrdersPage
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]/div[1]/div/div[3]/a"));
            }
        }
    }
}
