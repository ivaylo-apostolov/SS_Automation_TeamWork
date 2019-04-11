using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages.PageComponents.Navigation
{
    public class NavigationValidator : BasePageValidator<NavigationElementMap>
    {
        internal void SuccessfulClickOnCatalog()
        {
            Assert.AreEqual(TestData.ProductsButtonDefaultName, Map.ProductsButton.Text);
        }              
    }
}
