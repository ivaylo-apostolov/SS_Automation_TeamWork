using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class AccountPageValidator : BasePageValidator<AccountPageElementMap>
    {
        public void SuccessfulLogin()
        {
            Assert.AreEqual("Account", Map.PageHeading.Text);  
        }
    }
}

