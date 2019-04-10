using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPage : BasePage<DashboardPageElementMap, DashboardPageValidator>
    {
        public DashboardPage() : base(new Header())
        {
        }

        public string GetLoggedUserFullName()
        {
            var loggedUserName = Map.LoggedUserName;
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
