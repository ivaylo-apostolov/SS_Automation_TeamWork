using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test03DeclineNameChange : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void DeclineNameChange()
        {
            var dashboardPage = LoginProvider();
            dashboardPage.Validate().SuccessfulLogin();

            var profilePage = new ProfilePage();

            profilePage = dashboardPage.Header.NavigateToUserProfile();

            var newUser = TestData.UserForNameChange;

            profilePage.ChangeName(newUser);
            profilePage.Validate().ThrowWarningMessage();
        }
        public DashboardPage LoginProvider()
        {
            var user = TestData.User;

            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            return loginPage.Login(user);
        }
    }
}