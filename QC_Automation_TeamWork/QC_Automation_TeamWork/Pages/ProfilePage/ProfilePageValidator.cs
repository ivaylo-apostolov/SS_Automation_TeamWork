using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class ProfilePageValidator : BasePageValidator<ProfilePageElementMap>
    {
        public void ThrowWarningMessage()
        {
            Assert.AreEqual(TestData.WarningMessage, Map.DeclineChangesMessage.Text);
        }
    }
}