using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartHomePageValidator : BasePageValidator<OpenCartHomePageElementMap>
    {
        public void HomePageHeadingText()
        {
            Assert.AreEqual(TestData.OpenCartHomePageHeading, Map.OpenCartLink.Text);
        }

        internal void SuccessfullOpenCartLink()
        {
            Assert.AreEqual(TestData.OpenCartHomePageHeading, Map.HomePageHeading.Text);
        }
    }
}
