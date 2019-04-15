using QC_Automation_TeamWork.Core;
using System.Collections.ObjectModel;
using System.Linq;

namespace QC_Automation_TeamWork.Pages
{
    public class Header : BaseComponent<HeaderElementMap, HeaderValidator>
    {
        public DashboardPage NavigateToDashboardPage()
        {
            Map.CompanyLogo.Click();

            return new DashboardPage();
        }

        public LoginPage Logout()
        {
            Map.LogoutButton.Click();

            return new LoginPage();
        }

        internal void OpenProfileMenu()
        {
            Map.UserProfileName.Click();
        }

        public ProfilePage NavigateToUserProfile()
        {
            OpenProfileMenu();

            Map.YourProfileLink.Click();

            return new ProfilePage();
        }

        public ProfilePage NavigateToSupportForum()
        {
            OpenProfileMenu();

            Map.OpenSupportForum.Click();

            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);

            return new ProfilePage();
        }

    }
}