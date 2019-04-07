using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.DemoPage
{
    public class DemoPageElementMap : BasePageElementMap
    {
        public IWebElement AdministrationSection

        {
            get
            {

                return GetElement(By.CssSelector("#cms-demo>div.container>div>div:nth-child(2)>div>a"));
            //    return GetElement(By.XPath("//*[@id='cms-demo']/div[2]/div/div[2]/div/a"));
            }                              
        }
    }
}
