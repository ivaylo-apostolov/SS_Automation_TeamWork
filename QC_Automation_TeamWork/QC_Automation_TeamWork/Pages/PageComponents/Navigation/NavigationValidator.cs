using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class NavigationValidator : BasePageValidator<NavigationElementMap>
    {
        internal void SuccessfulClickOnCatalog()
        {
            Assert.AreEqual(TestData.ProductsButtonDefaultName, Map.ProductsButton.Text);
        }              
    }
}
