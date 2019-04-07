using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.DashboardPage;
using QC_Automation_TeamWork.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Tests
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
