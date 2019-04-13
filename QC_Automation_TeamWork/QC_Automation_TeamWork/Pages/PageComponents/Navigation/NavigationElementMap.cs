using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
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

        public IWebElement SystemDropDownMenuButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu-system']/a"));
            }
        }

        public IWebElement SalesDropDownMenuButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu-sale']/a"));
            }
        }
    }
}
