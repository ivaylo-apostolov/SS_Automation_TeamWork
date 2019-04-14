
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

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

            var settings = new Settings();
            settings.ClickSettingsButton();

            var editButton = new Settings();
            editButton.ClickOnEditButton();

            var metaTitleField = new Settings();
            metaTitleField.ClickOnMetaTitleField();

            var metaTitle = TestData.MetaTitle;
            metaTitleField.TypeMetatitlename(metaTitle.Metatitlename);

            var saveButton = new Settings();
            saveButton.ClickOnSaveButton();

            var warningMessage = new Settings();
            warningMessage.Validate().ThrowSettingsWarningMessage();
        }
    }
}


