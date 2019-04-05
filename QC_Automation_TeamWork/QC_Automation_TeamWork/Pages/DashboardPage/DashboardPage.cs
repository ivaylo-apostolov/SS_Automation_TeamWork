using System;
using OpenCartTestsTeamWork.Core;
using OpenQA.Selenium;

namespace OpenCartTestsTeamWork.Pages.DashboardPage
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
     
    }
}
