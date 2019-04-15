using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartLoginPageValidator : BasePageValidator<OpenCartLoginPageElementMap>
    {
        public void CheckResetPasswordMessage()
        {
            Assert.IsTrue(Map.ResetPasswordMessage.Text.Contains(TestData.ResetPasswordMessage));
        }
    }
}
