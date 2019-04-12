
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class IphoneReviewPageValidator : BasePageValidator<IphoneReviewPageElementMap>
    {
        internal void SuccessfulReview()
        {
            Assert.AreEqual(TestData.SuccessfulReview, Map.SuccessfulReviewMessage.Text);
        }

    }
}
