using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;
using System.Threading;

namespace QC_Automation_TeamWork.Tests
{
    [TestClass]
    public class Test04ChangeCurrency : BaseTest
    {
        [TestCategory("TomaLazarovTests")]
        [TestMethod]
        public void ChangeCurrency()
        {
            var homePage = new StoreHomePage();
            homePage.Navigate();

            homePage.ClickOnMacBook();
            
            var currency = new StoreCurrency();
            currency.ClickCurrencyDropDownList();

            var eurocurrency = new StoreCurrency();
            eurocurrency.ClickCurrencyEuro();

            eurocurrency.Validate().AssertCurrencyIsChanged();            
        }        
    }
}

