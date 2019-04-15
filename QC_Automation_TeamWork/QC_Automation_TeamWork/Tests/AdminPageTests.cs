using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class AdminPageTests : BaseTest
    {
        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void LoginAsAdmin()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void LogoutAsAdmin()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();

            var loginPage = dashboardPage.Header.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void DeclineNameChange()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();

            var profilePage = new ProfilePage();

            profilePage = dashboardPage.Header.NavigateToUserProfile();

            var newUser = TestData.UserForNameChange;

            profilePage.ChangeName(newUser);
            profilePage.Validate().ThrowWarningMessage();
        }

        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void FilterOrdersByName()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();

            var loginPage = dashboardPage.GoToOrders();
            var ordersPage = new OrdersPage();
            var currentCustomer = TestData.Customer;

            ordersPage.FilterByUser(currentCustomer);
            ordersPage.Validate().Filtering();
        }

        [TestCategory("MladenVarbevTests")]
        [TestMethod]
        public void OpenSupportForum()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();

            var loginPage = dashboardPage.Header.NavigateToSupportForum();
            var supportForum = new SupportForum();

            supportForum.Validate().BannerChecking();
        }

        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void DashboardPageOpenCartLink()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();
            dashboardPage.ClickOpenCartLink();

            var openCartHomePage = new OpenCartHomePage();

            openCartHomePage.Validate().SuccessfullOpenCartLink();
        }

        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void ProductFilter()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();

            var catalog = new Navigation();

            catalog.ClickCatalogDropDownMenu();

            var products = new Products();

            products.ClickProductsButton();

            var productName = new Products();

            productName.ClickOnProductNameField();

            var product = TestData.Product;

            productName.TypeProductname(product.Productname);

            var model = TestData.Model;

            productName.TypeModel(model.Modelname);

            var filterButton = new Products();

            filterButton.ClickFilterButton();

            var modelFieldResult = new Products();

            modelFieldResult.Validate().SuccessfulFilterResult();
        }

        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void EditStoreTitle()
        {
            var dashboardPage = LoginProvider();

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

        [TestCategory("TomaLazarovTests")]
        [TestMethod]

        public void PrintShippingList()
        {
            var dashboardPage = LoginProvider();
            var sales = new Navigation();

            sales.ClickSalesDropDownMenu();

            var orders = new Orders();

            orders.ClickOrdersButton();

            var ordersPage = orders.NavigateToPrintShippingListPage();
            var printShippingList = new PrintShippingListPage();

            printShippingList.Validate().PrintShippingListChecking();
        }

        public DashboardPage LoginProvider()
        {
            var user = TestData.User;
            var loginPage = new LoginPage();

            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            return loginPage.Login(user);
        }
    }
}
