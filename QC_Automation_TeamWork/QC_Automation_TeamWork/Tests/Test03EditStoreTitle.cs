
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test03EditStoreTitle : BaseTest
    {
        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void EditStoreTitle()
        {
            var loginPage = new LoginPage();

            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            var system = new Navigation();
            system.ClickSystemDropDownMenu();
            Thread.Sleep(3000);

            var settings = new Settings();
            settings.ClickSettingsButton();
            Thread.Sleep(3000);

            var editButton = new Settings();
            editButton.ClickOnEditButton();
            Thread.Sleep(3000);

            var metaTitleField = new Settings();
            metaTitleField.ClickOnMetaTitleField();
            Thread.Sleep(3000);

            var metaTitle = TestData.MetaTitle;
            metaTitleField.TypeMetatitlename(metaTitle.Metatitlename);
            Thread.Sleep(3000);

            var saveButton = new Settings();
            saveButton.ClickOnSaveButton();
            Thread.Sleep(3000);

            var warningMessage = new Settings();
            warningMessage.Validate().ThrowSettingsWarningMessage();
        }
    }
}


