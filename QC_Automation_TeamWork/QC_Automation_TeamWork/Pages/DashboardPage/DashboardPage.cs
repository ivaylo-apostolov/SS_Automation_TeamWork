using System;
using QC_Automation_TeamWork.Pages.DashboardPage;
using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.DashboardPage
{
    public class DashboardPage : BasePage<DashboardPageElementMap>
    {
        public string GetLoggedUserFullName()
        {
            var loggedUserName = Driver.Browser.FindElement(By.XPath("//a[contains(text(),'demo demo ')]"));
            return loggedUserName.Text;
        }

        internal void OpenCart()
        {
            Map.OpenCartLink.Click();
        }

        public string GetHomePageHeadingText()
        {
            return Map.HomePageHeading.Text;
        }

        internal void Logout()
        {
            Map.LogoutButton.Click();
        }

        //private string pageUrl = "https://www.opencart.com/index.php?route=cms/demo/";

        //internal void Navigate()
        //{
        //    Driver.Browser.Navigate().GoToUrl(pageUrl);
        //}

        internal string AdminHeader()
        {
            return Map.AdminHeader.Text;
        }
    }
}
