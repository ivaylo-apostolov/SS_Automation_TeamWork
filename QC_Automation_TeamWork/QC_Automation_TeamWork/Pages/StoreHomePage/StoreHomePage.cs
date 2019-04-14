using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreHomePage : BasePage<StoreHomePageElementMap, StoreHomePageValidator>
    {
        private string pageUrl = "https://demo.opencart.com/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageUrl);
        }

        internal StoreCamerasPage ClickCamerasButton()
        {
            Map.CamerasButton.Click();
            return new StoreCamerasPage();
        }

        internal void ClickOnMacBook()
        {
            Map.MacBookLink.Click();
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

        internal StoreSearchResultPage ClickOnSearchButton()
        {
            Map.SearchButton.Click();
            return new StoreSearchResultPage();
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

        internal StoreContactUsPage ClickFooterContactUsButton()
        {
            Map.FooterContactUsButton.Click();
            return new StoreContactUsPage();
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

        internal StoreProductComparePage ClickOnProductComparisonButton()
        {
            Map.ProductComparisonButton.Click();
            return new StoreProductComparePage();
        }
    }
}
