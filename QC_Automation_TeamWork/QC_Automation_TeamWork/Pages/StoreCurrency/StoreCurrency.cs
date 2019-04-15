using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCurrency : BasePage<StoreCurrencyElementMap, StoreCurrencyValidator>
    {
        internal void ClickCurrencyDropDownList()
        {
            Map.CurrencyDropDownList.Click(); 
        }

        internal void ClickCurrencyEuro()
        {
            Map.CurrencyEuro.Click();
        }
    }
}

