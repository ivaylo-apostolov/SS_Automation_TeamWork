using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartHomePage
{
    public class OpenCartHomePageElementMap : BasePageElementMap
    {
        public IWebElement DemoHeader
        {
            get
            {
                return GetElement(By.XPath("//*[@id='navbar-collapse-header']/ul/li[2]/a"));
            }
        }
    }
}
