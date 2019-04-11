using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreProductComparePage
{
    public class StoreProductComparePageValidator : BasePageValidator<StoreProductComparePageElementMap>
    {
        public void FirstProduct(string firstProductName)
        {
            Assert.AreEqual(firstProductName, Map.FirstProduct.Text);
        }

        public void SecondProduct(string secondProductName)
        {
            Assert.AreEqual(secondProductName, Map.SecondProduct.Text);
        }

        public void ProductsAreDifferent(Product firstProduct, Product secondProduct)
        {
            Assert.IsFalse(firstProduct.CompareWithAnotherProduct(secondProduct));
        }
    }
}
