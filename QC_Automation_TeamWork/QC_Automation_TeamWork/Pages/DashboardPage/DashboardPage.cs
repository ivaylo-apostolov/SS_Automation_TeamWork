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
            return "abv";
        }
           
        internal void ClickOpenCartLink()
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

        internal string AdminHeader()
        {
            return Map.AdminHeader.Text;
        }

        public DashboardPage GoToOrders()
        {
            Map.OrdersPage.Click();
            return new DashboardPage();
        }
    }
}
