using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreCamerasPage
{
    public class StoreCamerasPageValidator : BasePageValidator<StoreCamerasPageElementMap>
    {
        public void CamerasPage()
        {
            Assert.AreEqual(TestData.ExpectedCamerasPageHeading, Map.CamerasHeader.Text);
        }
    }
}
