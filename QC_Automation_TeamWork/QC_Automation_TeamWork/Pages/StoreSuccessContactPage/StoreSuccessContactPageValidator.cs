using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.StoreSuccessContactPage
{
    public class StoreSuccessContactPageValidator : BasePageValidator<StoreSuccessContactPageElementMap>
    {
        internal void PageHeading()
        {
            Assert.IsTrue(Map.PageHeaded.Displayed, "Success contact page is not displayed");
        }
    }
}
