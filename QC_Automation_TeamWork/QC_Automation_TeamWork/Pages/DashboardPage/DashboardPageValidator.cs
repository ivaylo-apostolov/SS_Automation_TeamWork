﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using QC_Automation_TeamWork.Pages.DashboardPage;

namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPageValidator : BasePageValidator<DashboardPageElementMap>
    {
        internal void SuccessfulLogin()
        {
            Assert.AreEqual(TestData.UserFullName, Map.LoggedUserName.Text);
        }   
    }
}