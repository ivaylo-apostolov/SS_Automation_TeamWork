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
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);
            dashboardPage.Logout();

            Assert.AreEqual(TestData.LoginPanelDefaultTitle,
                loginPage.GetLoginPanelTitleText());
        }
    }
}
