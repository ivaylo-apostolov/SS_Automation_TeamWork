using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test01DashboardPageOpenCartLink : BaseTest
    {
        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void DashboardPageOpenCartLink()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            dashboardPage.Validate().SuccessfulLogin();

            dashboardPage.ClickOpenCartLink();

            var openCartHomePage = new OpenCartHomePage();

            openCartHomePage.Validate().SuccessfullOpenCartLink();
        }
    }
}
