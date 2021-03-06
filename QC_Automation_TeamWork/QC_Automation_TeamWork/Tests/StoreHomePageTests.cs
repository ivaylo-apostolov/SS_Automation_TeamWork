﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class StoreHomePageTests : BaseTest
    {
        [TestCategory("IvayloTests")]
        [TestMethod]
        public void NavigateToCameraPage()
        {
            var homePage = NavigateToHomePage();
            var camerasPage = homePage.ClickCamerasButton();

            camerasPage.Validate().CamerasPage();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void NavigateToSearchResultsPage()
        {
            var homePage = NavigateToHomePage();

            homePage.TypeInSearchTextBox(TestData.SearchText);

            var searchResultPage = homePage.ClickOnSearchButton();

            searchResultPage.Validate().SearchResult();
        }

        [TestCategory("IvayloTests")]
        [TestMethod]
        public void AddGoodsToCard()
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
        public void SendEnquiryUsingContactForm()
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
        public void CompareTwoProducts()
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
            productComparePage.Validate().ProductsAreDifferent(firstProduct, secondProduct);
        }

        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void ChangeCurrency()
        {
            var homePage = NavigateToHomePage();

            homePage.ClickOnMacBook();

            var currency = new StoreCurrency();

            currency.ClickCurrencyDropDownList();

            var eurocurrency = new StoreCurrency();

            eurocurrency.ClickCurrencyEuro();
            eurocurrency.Validate().AssertCurrencyIsChanged();
        }


        [TestCategory("MadlenaIvanovaTests")]
        [TestMethod]
        public void IphoneReview()
        {
            var storeHomePage = new StoreHomePage();

            storeHomePage.Navigate();

            IphonePage iphonePage = storeHomePage.ClickIphoneButton();
            iphonePage.WriteReview();
            iphonePage.Validate().SuccessfulReview();
        }

        private StoreHomePage NavigateToHomePage()
        {
            var homePage = new StoreHomePage();

            homePage.Navigate();

            return homePage;
        }
    }
}
