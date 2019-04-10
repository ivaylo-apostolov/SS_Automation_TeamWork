using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.DemoAdminPage;
using System.Threading;
using QC_Automation_TeamWork.Pages.DashboardPage;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class DemoAdminLogin : BaseTest
    {
        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test01LogInToDemoAsAdmin()
        {
            var demoAdminPage = new DemoAdminPage();
            demoAdminPage.Navigate();
            demoAdminPage.FillinLogingForm();
            demoAdminPage.EnterLogInButton();

            var dashboardPage = new DashboardPage();
            dashboardPage.Validate().SuccessfulLogin();
        }
    }
}

