using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class MarketplacePage : BasePage<MarketplacePageElementMap, MarketplacePageValidator>
    {
        private string pageURL = "https://www.opencart.com/index.php?route=marketplace/extension";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        public void UseSearchFilter()
        {
            Map.SearchFilterBox.Clear();
            Map.SearchFilterBox.SendKeys(TestData.SearchFilterValue);
            Map.SearchFilterButton.Click();

            
        }
    }
}
