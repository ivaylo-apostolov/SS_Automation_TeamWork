using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTests.Core;
using OpenCartTests.Data;
using OpenCartTests.Pages;

namespace OpenCartTestsPageObjectModel.Tests
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