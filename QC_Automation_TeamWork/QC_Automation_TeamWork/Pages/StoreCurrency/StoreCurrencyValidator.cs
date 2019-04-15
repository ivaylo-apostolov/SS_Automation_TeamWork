using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCurrencyValidator : BasePageValidator<StoreCurrencyElementMap>
    {
        public void AssertCurrencyIsChanged()
        {
            Assert.AreEqual(TestData.ChangedCurrency, Map.CurrencyChangedToEuro.Text);
        }
    }
}
