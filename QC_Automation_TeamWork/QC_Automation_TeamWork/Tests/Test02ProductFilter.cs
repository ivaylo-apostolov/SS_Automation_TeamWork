using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.LoginPage;
using QC_Automation_TeamWork.Pages.PageComponents.Navigation;
using QC_Automation_TeamWork.Pages.PageComponents.Navigation.Catalog.Products;

namespace QC_Automation_TeamWork.Tests
{
    public class Test02ProductFilter
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
                loginPage.Validate().LoginForm();

                var user = TestData.User;

                var dashboardPage = loginPage.Login(user);
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
        }
    }
}
