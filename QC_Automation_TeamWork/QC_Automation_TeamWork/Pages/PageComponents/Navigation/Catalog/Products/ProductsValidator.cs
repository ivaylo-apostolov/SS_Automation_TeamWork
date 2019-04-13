using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class ProductsValidator : BasePageValidator<ProductsElementMap>
    {
        internal void SuccessfulClickOnProductsButton()
        {
            Assert.AreEqual(TestData.ProductsHomePageTitle, Map.ProductsHomePageHeading.Text);
        }

        internal void SuccessfulFilterResult()
        {
            Assert.AreEqual(TestData.ModelFilterResultField, Map.ModelFilterResultField.Text);
        }
    }
 }
