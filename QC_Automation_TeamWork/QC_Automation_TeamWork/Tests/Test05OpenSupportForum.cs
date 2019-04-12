using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test05OpenSupportForum : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void OpenSupportForum()
        {
            var loginPage = new LoginPage();

            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user).Header.NavigateToSupportForum();

            var supportForum = new SupportForum();

            supportForum.Validate().BannerChecking();
        }
    }
}