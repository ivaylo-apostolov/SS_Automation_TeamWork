using System;
using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPage : BasePage<DashboardPageElementMap, DashboardPageValidator>
    {
        public string GetLoggedUserFullName()
        {
            return "abv";
        }
           
        internal void ClickOpenCartLink()
        {
            Map.OpenCartLink.Click();
        }

        internal void Logout()
        {
            throw new NotImplementedException();
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
