using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreCamerasPage
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
