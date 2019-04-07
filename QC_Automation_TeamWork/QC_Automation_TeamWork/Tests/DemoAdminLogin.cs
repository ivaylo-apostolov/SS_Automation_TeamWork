using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.DemoPage;
using QC_Automation_TeamWork.Pages.OpenCartHomePage;
using QC_Automation_TeamWork.Pages.DemoAdminPage;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class DemoAdminLogin : BaseTest
    {
        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test01LogInToDemoAsAdmin()
        {
            var homePage = new OpenCartHomePage();
            homePage.Navigate();
            homePage.ClickDemoButton();

            var demoPage = new DemoPage();
            demoPage.ClickAdministrationSection();

            var demoAdminPage = new DemoAdminPage();
            demoAdminPage.SwitchToLastTab();
            demoAdminPage.EnterLogInButton();

            var dashboardPage = new DashboardPage();

            Assert.AreEqual("Dashboard", dashboardPage.AdminHeader());
        }
    }
}

