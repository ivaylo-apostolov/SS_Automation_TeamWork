using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class MarketplacePageElementMap : BasePageElementMap
    {
        public IWebElement SearchFilterBox
        {
            get
            {
                return GetElement(By.ClassName("form-control"));
            }
        }

        public IWebElement SearchFilterButton
        {
            get
            {
                return GetElement(By.ClassName("fa-search"));
            }
        }
        public IWebElement SearchFilterFacebook
        {
            get
            {
                return GetElement(By.XPath("//*[@id='extension-list']/div[1]/div/section/div[2]/p[1]/a"));
            }
        }
    }
}
