using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class OrdersPageValidator : BasePageValidator<OrdersPageElementMap>
    {
        public void Filtering()
        {
            Assert.AreEqual(TestData.ExpectedCustomer, Map.FilteredCustomer.Text);
        }
    }
}
