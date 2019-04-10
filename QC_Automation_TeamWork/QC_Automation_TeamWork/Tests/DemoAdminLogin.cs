using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.DemoAdminPage;
using System.Threading;
using QC_Automation_TeamWork.Pages.DashboardPage;
using QC_Automation_TeamWork.Pages.OpenCartHomePage;
using QC_Automation_TeamWork.Pages.LoginPage;

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

        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test02NavigateToHomePage()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            openCartHomePage.Validate().HomePageHeadingText();
        }

        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test03OpenCartLogin()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            var openCartLoginPage = openCartHomePage.ClickLoginButton();
            var pinSecurityCheckPage =openCartLoginPage.Login(new Data.Models.LoginWithEmail("mad17@abv.bg", "englisc"));

            pinSecurityCheckPage.TypePincode("1717");
            var accountPage= pinSecurityCheckPage.ContinueButtonClick();

            accountPage.Validate().SuccessfulLogin();
        }
    }
}

