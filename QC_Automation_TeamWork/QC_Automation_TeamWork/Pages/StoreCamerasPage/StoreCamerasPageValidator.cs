﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCamerasPageValidator : BasePageValidator<StoreCamerasPageElementMap>
    {
        public void CamerasPage()
        {
            Assert.AreEqual(TestData.ExpectedCamerasPageHeading, Map.CamerasHeader.Text);
        }
    }
}
