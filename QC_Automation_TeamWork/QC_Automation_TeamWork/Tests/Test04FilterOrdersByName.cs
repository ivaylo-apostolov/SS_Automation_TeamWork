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
        public void DeclineNameChange()
        {
            var loginPage = new LoginPage();

            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user).GoToOrders();

            var ordersPage = new OrdersPage();

            var currentCustomer = TestData.Customer;

            ordersPage.FilterByUser(currentCustomer);
            ordersPage.Validate().Filtering();                       
        }
    }
}
