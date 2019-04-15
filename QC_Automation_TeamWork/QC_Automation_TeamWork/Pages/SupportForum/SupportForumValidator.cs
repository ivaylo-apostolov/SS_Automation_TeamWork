using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class SupportForumValidator : BasePageValidator<SupportForumElementMap>
    {
        public void BannerChecking()
        {
            Assert.AreEqual(TestData.ExpectedBanner, Map.forumBanner.Text);
        }
    }
}
