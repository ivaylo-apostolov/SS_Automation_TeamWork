using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePageValidator : BasePageValidator<OpenCartHomePageElementMap>
    {
        public void HomePageHeadingText()
        {
            Assert.AreEqual(TestData.OpenCartHomePageHeading, Map.OpenCartLink.Text);
        }
    }
}
