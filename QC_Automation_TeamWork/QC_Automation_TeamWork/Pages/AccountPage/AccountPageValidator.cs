using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

