﻿using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCamerasPageElementMap : BasePageElementMap
    {
        public IWebElement CamerasHeader
        {
            get
            {
                return GetElement(By.CssSelector("h2"));
            }
        }
    }
}
