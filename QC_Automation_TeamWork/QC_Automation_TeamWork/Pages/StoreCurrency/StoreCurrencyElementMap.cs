using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCurrencyElementMap : BasePageElementMap
    {
        public IWebElement CurrencyDropDownList
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-currency']/div/button/span"));
            }
        }

        public IWebElement CurrencyEuro
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-currency']/div/ul/li[1]/button")); 
            }
        }

        public IWebElement CurrencyChangedToEuro
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div/div[2]/ul[2]/li[1]")); 
            }
        }
    }
}
