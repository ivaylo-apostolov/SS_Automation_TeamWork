using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Collections.Generic;
using System.Linq;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test05PrintShippingList : BaseTest
    {
        [TestCategory("TomaLazarovTests")]
        [TestMethod]

        public void PrintShippingList()
        {
            var loginPage = new LoginPage();

            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            var sales = new Navigation();
            sales.ClickSalesDropDownMenu();

            var orders = new Orders();
            orders.ClickOrdersButton();

            var ordersPage = orders.NavigateToPrintShippingListPage();

            var printShippingList = new PrintShippingListPage();
            printShippingList.Validate().PrintShippingListChecking();
        }
    }
}


