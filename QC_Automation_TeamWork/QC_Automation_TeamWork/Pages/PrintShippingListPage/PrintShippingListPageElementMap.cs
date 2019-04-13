using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class PrintShippingListPageElementMap : BasePageElementMap
    {
        public IWebElement orderdetails
        {
            get
            {
                return GetElement(By.XPath("/html/body/div/div/table[1]/thead/tr/td"));
            }
        }
    }
}
