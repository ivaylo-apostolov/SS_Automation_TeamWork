using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreContactUsPageValidator : BasePageValidator<StoreContactUsPageElementMap>
    {
        public void ContactUsHeader()
        {
            Assert.AreEqual(TestData.ExpectedContactUsHeader, Map.ContactUsHeader.Text);
        }
    }
}
