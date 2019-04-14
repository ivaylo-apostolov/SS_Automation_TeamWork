using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class MadlenaTests : BaseTest
    {
        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void Test01SubscribeToNewsletter()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            openCartHomePage.Validate().HomePageHeadingText();
            var subscribeToNewsletterPage = openCartHomePage.ClickNewsletter();
            Thread.Sleep(2000);
            subscribeToNewsletterPage.FilledSubscriptionForm();

            subscribeToNewsletterPage.Validate().ValidateError();
        }

        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void Test02OpenCartLogin()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            var openCartLoginPage = openCartHomePage.ClickLoginButton();
            var pinSecurityCheckPage = openCartLoginPage.Login(TestData.LoginWithEmail);
            pinSecurityCheckPage.TypePincode(TestData.Pincode);
            var accountPage = pinSecurityCheckPage.ContinueButtonClick();

            accountPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void Test03RequestNewPassword()
        {
            var openCartHomePage = new OpenCartHomePage();
            openCartHomePage.Navigate();
            var openCartLoginPage = openCartHomePage.ClickLoginButton();
            var requestNewPasswordPage = openCartLoginPage.ClickForgotPasswordLink();
            requestNewPasswordPage.RequestNewPassword(TestData.Email);

            openCartLoginPage.Validate().CheckResetPasswordMessage();
        }

        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void Test04IphoneReview()
        {
            var storeHomePage = new StoreHomePage();
            storeHomePage.Navigate();
            IphonePage iphonePage = storeHomePage.ClickIphoneButton();
            iphonePage.WriteReview();

            iphonePage.Validate().SuccessfulReview();
        }

        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void Test05SearchForFacebook()
        {
            var marketplacepage = new MarketplacePage();
            marketplacepage.Navigate();
            marketplacepage.UseSearchFilter();

            marketplacepage.Validate().SearchForFacebook();
        }
    }
}



