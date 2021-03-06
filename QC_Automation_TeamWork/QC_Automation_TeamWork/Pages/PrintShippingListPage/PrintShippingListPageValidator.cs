﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class PrintShippingListPageValidator : BasePageValidator<PrintShippingListPageElementMap>
    {
        public void PrintShippingListChecking()
        {
            Assert.AreEqual(TestData.PrintShippingList, Map.orderdetails.Text);
        }
    }
}
