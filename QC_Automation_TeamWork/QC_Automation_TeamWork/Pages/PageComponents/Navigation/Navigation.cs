using System;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Pages;

namespace QC_Automation_TeamWork.Pages
{
    public class Navigation : BasePage<NavigationElementMap, NavigationValidator>
    {
        internal void ClickCatalogDropDownMenu()
        {
            Map.CatalogDropDownMenuButton.Click();
        }

        internal void ClickSystemDropDownMenu()
        {
            Map.SystemDropDownMenuButton.Click();
        }

        internal void ClickSalesDropDownMenu()
        {
            Map.SalesDropDownMenuButton.Click();
        }               
    }   
}

