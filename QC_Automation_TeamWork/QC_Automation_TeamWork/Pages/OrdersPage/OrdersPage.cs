using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data.Models;

namespace QC_Automation_TeamWork.Pages
{
    public class OrdersPage : BasePage<OrdersPageElementMap, OrdersPageValidator>
    {
        public OrdersPage() : base(new Header())
        {
        }

        internal void WriteFilterName(string Customer)
        {
            var customerFilter = Map.CustomerFilter;

            customerFilter.Clear();
            customerFilter.SendKeys(Customer);
        }

        internal void ClickFilterButton()
        {
            var filterButton = Map.FilterButton;

            filterButton.Click();
        }

        public OrdersPage FilterByUser(Customer customer)
        {
            WriteFilterName(customer.CustomerName);

            ClickFilterButton();

            return new OrdersPage();
        }
    }
}
