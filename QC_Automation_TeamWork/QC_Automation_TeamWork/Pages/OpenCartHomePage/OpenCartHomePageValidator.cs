using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePageValidator : BasePageValidator<OpenCartHomePageElementMap>
    {
        internal void SuccessfullOpenCartLink()
        {
            Assert.AreEqual(TestData.OpenCartHomePageHeading, Map.HomePageHeading.Text);
        }
    }
}
