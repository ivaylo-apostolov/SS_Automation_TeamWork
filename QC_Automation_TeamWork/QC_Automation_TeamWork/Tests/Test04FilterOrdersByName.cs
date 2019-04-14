using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test04FilterOrdersByName : BaseTest
    {
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