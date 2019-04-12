using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class MadlenaTests : BaseTest
    {
        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test01LogInToDemoAsAdmin()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            var dashboard = loginPage.Login(TestData.User);
            dashboard.Validate().SuccessfulLogin();
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
            var pinSecurityCheckPage = openCartLoginPage.Login(new Data.Models.LoginWithEmail("mad17@abv.bg", "englisc"));

            pinSecurityCheckPage.TypePincode("1717");
            var accountPage = pinSecurityCheckPage.ContinueButtonClick();

            accountPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MadlenaTests")]
        [TestMethod]
        public void Test04RequestNewPassword()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            var openCartLoginPage = openCartHomePage.ClickLoginButton();

            openCartLoginPage.ClickForgotPasswordLink();

            var requestNewPasswordPage = new RequestNewPasswordPage();
            requestNewPasswordPage.RequestNewPassword("mad17@abv.bg");

            openCartLoginPage.Validate().ResetPasswordMessage();
        }
    }
}



