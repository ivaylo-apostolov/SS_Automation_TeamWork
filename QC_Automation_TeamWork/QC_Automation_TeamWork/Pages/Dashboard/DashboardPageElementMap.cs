using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.DemoPage
{
    public class DashboardPageElementMap : BasePageElementMap
    {
        public IWebElement AdminHeader

        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div/h1"));
            }                              
        }
    }
}
