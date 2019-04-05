using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTests.Core;
using OpenCartTests.Data;
using OpenCartTests.Pages;

namespace OpenCartTestsPageObjectModel.Tests
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