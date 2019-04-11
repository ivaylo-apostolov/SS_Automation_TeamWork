using System;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages.PageComponents.Navigation
{
    public class Navigation : BasePage<NavigationElementMap, NavigationValidator>
    {
        internal void ClickCatalogDropDownMenu()
        {
            Map.CatalogDropDownMenuButton.Click();
        }        
    }
}
