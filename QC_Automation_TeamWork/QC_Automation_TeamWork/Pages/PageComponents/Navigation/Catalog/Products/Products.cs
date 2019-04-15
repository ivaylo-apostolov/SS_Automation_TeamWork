using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class Products : BasePage<ProductsElementMap, ProductsValidator>
    {
        internal void ClickProductsButton()
        {
            Map.ProductsButton.Click();
        }

        internal void ClickOnProductNameField()
        {
            Map.ProductNameField.Click();
        }

        internal void TypeProductname(string productname)
        {
            var productnameElement = Map.ProductNameField;
            productnameElement.SendKeys(productname);            
        }

        internal void TypeModel(string model)
        {
            var modelElement = Map.ModelField;
            modelElement.SendKeys(model);           
        }

        internal void ClickFilterButton()
        {
            Map.FilterButton.Click();
        }
    }
}
