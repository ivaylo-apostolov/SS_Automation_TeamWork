using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test02LogoutAsAdmin : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void LogoutAsAdmin()
        {
            var dashboardPage = LoginProvider();
            dashboardPage.Validate().SuccessfulLogin();

            var loginPage = dashboardPage.Header.Logout();

            loginPage.Validate().LoginForm();
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