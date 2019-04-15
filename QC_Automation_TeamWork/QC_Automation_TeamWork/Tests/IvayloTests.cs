using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;
using QC_Automation_TeamWork.Data;
using System.Threading;
using System;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class IvayloTests : BaseTest
    {
        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test01NavigateToCameraPage()
        {
            var homePage = NavigateToHomePage();

            var camerasPage = homePage.ClickCamerasButton();
            camerasPage.Validate().CamerasPage();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test02NavigateToSearchResultsPage()
        {
            var homePage = NavigateToHomePage();

            homePage.TypeInSearchTextBox(TestData.SearchText);

            var searchResultPage = homePage.ClickOnSearchButton();
            searchResultPage.Validate().SearchResult();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test03AddGoodsToCard()
        {
            var homePage = NavigateToHomePage();

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
            var homePage = NavigateToHomePage();

            var contactUsPage = homePage.ClickFooterContactUsButton();
            contactUsPage.Validate().ContactUsHeader();

            contactUsPage.TypeInYourNameTextBox(TestData.NameInContactUsForm);
            contactUsPage.TypeInEmailAddressTextBox(TestData.EmailInContactUsForm);
            contactUsPage.TypeInEnquiryTextBox(TestData.EnquiryTextInContactUsForm);

            var successContactPage = contactUsPage.ClickOnSubmitButton();
            successContactPage.Validate().PageHeading();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void Test05CompareTwoProducts()
        {
            var homePage = NavigateToHomePage();

            homePage.CompareFirstProduct();
            Thread.Sleep(1500);

            homePage.CompareSecondProduct();
            Thread.Sleep(1500);

            var productComparePage = homePage.ClickOnProductComparisonButton();
            Thread.Sleep(2000);

            var firstProduct = TestData.ProductMacBook;
            var secondProduct = TestData.ProductIPhone;

            productComparePage.Validate().FirstProduct(firstProduct.Productname);
            productComparePage.Validate().SecondProduct(secondProduct.Productname);
        }

        private StoreHomePage NavigateToHomePage()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();
            return homePage;
        }
    }
}
