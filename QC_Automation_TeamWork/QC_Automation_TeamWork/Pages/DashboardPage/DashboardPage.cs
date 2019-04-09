using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPage : BasePage<DashboardPageElementMap>
    {
        public string GetLoggedUserFullName()
        {
            var loggedUserName = Driver.Browser.FindElement(By.XPath("//a[contains(text(),'demo demo ')]"));
            return loggedUserName.Text;
        }

        internal void Logout()
        {
            Map.LogoutButton.Click();
        }
    }
}