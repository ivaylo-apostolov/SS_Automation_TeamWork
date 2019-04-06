using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTestsTeamWork.Core;
using OpenCartTestsTeamWork.Data;
using OpenCartTestsTeamWork.Pages;
using OpenCartTestsTeamWork.Pages.DashboardPage;
using OpenCartTestsTeamWork.Pages.LoginPage;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpenCartTestsTeamWork.Tests
{
    [TestClass]
    public class AdminDemoDashboardPage : BaseTest
    {
        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void Test01DashboardPageOpenCartLink()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var user = TestData.User;

            loginPage.TypeUsername(user.Username);
            loginPage.TypePassword(user.Username);
            loginPage.ClickLoginButton();

            var dashboardPage = new DashboardPage();
            dashboardPage.OpenCart();

            Assert.AreEqual(TestData.OpenCartHomePageHeading, dashboardPage.GetHomePageHeadingText());     
        
        }
    }
}
