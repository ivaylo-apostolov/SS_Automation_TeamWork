using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreHomePage
{
    public class StoreHomePageValidator : BasePageValidator<StoreHomePageElementMap>
    {
        public void TotalPrice()
        {
            Assert.AreEqual(TestData.ExpectedTotalPrice, Map.TotalPrice.Text);
        }

        internal void FirstItem()
        {
            Assert.AreEqual(TestData.ExpectedFirstItem, Map.FirstItemInBasket.Text);
        }

        internal void SecondItem()
        {
            Assert.AreEqual(TestData.ExpectedSecondItem, Map.SecondItemInBasket.Text);
        }
    }
}
