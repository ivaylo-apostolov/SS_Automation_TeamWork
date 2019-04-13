using System;
using OpenQA.Selenium;
using QC_Automation_TeamWork.Pages;
using QC_Automation_TeamWork.Core;
using System.Collections.ObjectModel;
using System.Linq;

namespace QC_Automation_TeamWork.Pages
{
    public class DashboardPage : BasePage<DashboardPageElementMap, DashboardPageValidator>
    {          
        internal void ClickOpenCartLink()
        {
            Map.OpenCartLink.Click();
        }

        internal void Logout()
        {
            throw new NotImplementedException();
        }

        internal string GetLoggedUserFullName()
        {
            throw new NotImplementedException();
        }

        internal string AdminHeader()
        {
            throw new NotImplementedException();
        }                       
    }
}

