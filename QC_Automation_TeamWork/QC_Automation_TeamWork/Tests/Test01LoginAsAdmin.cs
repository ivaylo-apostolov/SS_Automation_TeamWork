using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test01LoginAsAdmin : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void LoginAsAdmin()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            Assert.AreEqual(TestData.UserFullName,
                dashboardPage.GetLoggedUserFullName());
        }
    }
}
