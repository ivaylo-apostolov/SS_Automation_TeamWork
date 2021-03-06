﻿using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;
using System.Collections.ObjectModel;
using System.Linq;


namespace QC_Automation_TeamWork.Pages
{
    public class DemoAdminPage : BasePage<DemoAdminPageElementMap>
    {
        private string pageUrl = "https://demo.opencart.com/admin/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageUrl);
        }

        internal void SwitchToLastTab()
        {
            ReadOnlyCollection<string> windowHandles = Driver.Browser.WindowHandles;
            //string firstTab = windowHandles.First();
            string lastTab = windowHandles.Last();
            Driver.Browser.SwitchTo().Window(lastTab);
        }

        internal void FillinLogingForm()
        {
            Map.Username.Clear();
            Map.Username.SendKeys("demo");

            Map.Password.Clear();
            Map.Password.SendKeys("demo");
        }


        internal void EnterLogInButton()
        {
            Map.LogInButton.Click();
           // Map.LogInButton.SendKeys(Keys.Enter);//.Click();
        }
    }
}

