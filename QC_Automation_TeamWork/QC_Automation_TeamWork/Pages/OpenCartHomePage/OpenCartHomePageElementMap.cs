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
        public IWebElement OpenCartLink
        {
            get
            {
                return GetElement(By.CssSelector("h1"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='navbar-collapse-header']/div/a[1]"));
            }
        }
    }
}
