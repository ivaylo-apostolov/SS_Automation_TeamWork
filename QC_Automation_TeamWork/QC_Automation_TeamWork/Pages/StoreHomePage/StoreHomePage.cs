using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreHomePage : BasePage<StoreHomePageElementMap, StoreHomePageValidator>
    {
        private string pageUrl = "https://demo.opencart.com/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageUrl);
        }

        internal void ClickCamerasButton()
        {
            Map.CamerasButton.Click();
        }

        internal IphonePage ClickIphoneButton()
        {
            Map.Iphone.Click();
            return new IphonePage();
        }

        internal void TypeInSearchTextBox(string searchText)
        {
            var searchTextBoxElement = Map.SearchTextBoxElement;
            searchTextBoxElement.Clear();
            searchTextBoxElement.SendKeys(searchText);

        }

        internal void ClickOnSearchButton()
        {
            Map.SearchButton.Click();
        }

        internal void AddToCardMacBook()
        {
            Map.MacBookAddToCard.Click();
        }

        internal void AddToCardIPhone()
        {
            Map.IPhoneAddToCard.Click();
        }

        internal void BasketButton()
        {
            Map.BasketButton.Click();
        }

        internal void ClickFooterContactUsButton()
        {
            Map.FooterContactUsButton.Click();
        }

        internal void CompareFirstProduct()
        {
            Map.CompareFirstProductButton.Click();
        }

        internal string GetFirstProductName()
        {
            return Map.TextFirstProduct;
        }

        internal void CompareSecondProduct()
        {
            Map.CompareSecondProductButton.Click();
        }

        internal string GetSecondProductName()
        {
            return Map.TextSecondProduct;
        }

        internal void ClickOnProductComparisonButton()
        {
            Map.ProductComparisonButton.Click();
        }
    }
}
