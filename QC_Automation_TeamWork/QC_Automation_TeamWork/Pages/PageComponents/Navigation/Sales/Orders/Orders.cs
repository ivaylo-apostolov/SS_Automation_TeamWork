using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class Orders : BasePage<OrdersElementMap, OrdersValidator>
    {
        internal void ClickOrdersButton()
        {
            Map.OrdersButton.Click();
        }

        internal void ClickViewOrderButton()
        {
            Map.ViewOrderButton.Click();
        }

        //internal void ClickPrintShippingListButton()
        //{
        //    Map.PrintShippingListButton.Click();
        //}

        public Orders NavigateToPrintShippingListPage()
        {
            ClickViewOrderButton();
            Map.PrintShippingListButton.Click();

            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);

            return new Orders();
        }
    }
}
