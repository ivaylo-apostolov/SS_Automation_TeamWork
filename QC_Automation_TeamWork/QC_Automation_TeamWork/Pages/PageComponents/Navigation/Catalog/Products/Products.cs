using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.PageComponents.Navigation.Catalog.Products
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
