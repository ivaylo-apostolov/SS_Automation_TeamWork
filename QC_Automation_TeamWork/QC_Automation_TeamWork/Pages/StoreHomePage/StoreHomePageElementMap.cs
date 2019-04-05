using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreHomePage
{
    public class StoreHomePageElementMap : BasePageElementMap
    {
        public IWebElement CamerasButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu']/div[2]/ul/li[7]/a"));
            }
        }
    }
}
