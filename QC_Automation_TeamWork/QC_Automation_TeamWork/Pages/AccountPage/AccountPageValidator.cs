using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class AccountPageValidator : BasePageValidator<AccountPageElementMap>
    {
        public void SuccessfulLogin()
        {
            Assert.AreEqual(TestData.Account, Map.PageHeading.Text);
        }
    }
}

