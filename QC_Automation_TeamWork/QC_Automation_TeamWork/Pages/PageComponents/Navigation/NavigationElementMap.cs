using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages.PageComponents.Navigation
{
    public class NavigationElementMap : BasePageElementMap
    {
        public IWebElement CatalogDropDownMenuButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu-catalog']/a"));
            }
        }

        public IWebElement ProductsButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='collapse1']/li[2]/a"));
            }
        }
    }
}
