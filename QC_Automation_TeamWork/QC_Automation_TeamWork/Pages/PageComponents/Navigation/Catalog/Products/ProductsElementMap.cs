using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class ProductsElementMap : BasePageElementMap
    {
        public IWebElement ProductsButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='collapse1']/li[2]/a"));
            }
        }

        public IWebElement ProductsHomePageHeading
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }

        public IWebElement ProductNameField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='input-name']"));
            }
        }

        public IWebElement ModelField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='input-model']"));
            }
        }

        public IWebElement FilterButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='button-filter']"));
            }
        }

        public IWebElement ModelFilterResultField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-product']/div/table/tbody/tr/td[4]"));
            }
        }
    }
}
