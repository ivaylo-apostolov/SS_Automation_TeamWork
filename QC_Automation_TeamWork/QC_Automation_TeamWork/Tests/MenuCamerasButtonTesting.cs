using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.StoreCamerasPage;
using QC_Automation_TeamWork.Pages.StoreContactUsPage;
using QC_Automation_TeamWork.Pages.StoreHomePage;
using QC_Automation_TeamWork.Pages.StoreProductComparePage;
using QC_Automation_TeamWork.Pages.StoreSearchPage;
using QC_Automation_TeamWork.Pages.StoreSuccessContactPage;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class MenuCamerasButtonTesting : BaseTest
    {
        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test01NavigateToCameraPage()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();
            homePage.ClickCamerasButton();

            var camerasPage = new StoreCamerasPage();
            camerasPage.LocateCamerasPageHeader();

            camerasPage.Validate().CamerasPage();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test02NavigateToSearchResultsPage()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();

            homePage.TypeInSearchTextBox(TestData.SearchText);
            homePage.ClickOnSearchButton();

            var searchResultPage = new StoreSearchResultPage();
            searchResultPage.Validate().SearchResult();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test03AddGoodsToCard()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();

            homePage.AddToCardMacBook();
            Thread.Sleep(1500);

            homePage.AddToCardIPhone();
            Thread.Sleep(1500);

            homePage.BasketButton();
            Thread.Sleep(1500);

            homePage.Validate().TotalPrice();
            homePage.Validate().FirstItem();
            homePage.Validate().SecondItem();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test04SendEnquiryUsingContactForm()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();

            homePage.ClickFooterContactUsButton();

            var contactUsPage = new StoreContactUsPage();
            contactUsPage.Validate().ContactUsHeader();

            contactUsPage.TypeInYourNameTextBox(TestData.NameInContactUsForm);
            contactUsPage.TypeInEmailAddressTextBox(TestData.EmailInContactUsForm);
            contactUsPage.TypeInEnquiryTextBox(TestData.EnquiryTextInContactUsForm);

            contactUsPage.ClickOnSubmitButton();

            var successContactPage = new StoreSuccessContactPage();
            successContactPage.Validate().PageHeading();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test05CompareTwoProducts()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();

            homePage.CompareFirstProduct();
            Thread.Sleep(1500);

            homePage.CompareSecondProduct();
            Thread.Sleep(1500);

            homePage.ClickOnProductComparisonButton();
            Thread.Sleep(2000);

            var productComparePage = new StoreProductComparePage();

            var firstProduct = TestData.ProductMacBook;
            var secondProduct = TestData.ProductIPhone;

            productComparePage.Validate().FirstProduct(firstProduct.Productname);
            productComparePage.Validate().SecondProduct(secondProduct.Productname);
        }
    }
}
