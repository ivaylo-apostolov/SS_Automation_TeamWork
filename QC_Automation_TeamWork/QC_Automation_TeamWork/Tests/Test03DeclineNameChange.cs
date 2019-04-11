using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test03DeclineNameChange : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void DeclineNameChange()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            var profilePage = new ProfilePage();

            profilePage = dashboardPage.Header.NavigateToUserProfile();

            var newUser = TestData.UserForNameChange;

            profilePage.ChangeName(newUser);
            profilePage.Validate().ThrowWarningMessage();
        }
    }
}
