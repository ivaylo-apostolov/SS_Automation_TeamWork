﻿using System;
using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.DashboardPage 
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
