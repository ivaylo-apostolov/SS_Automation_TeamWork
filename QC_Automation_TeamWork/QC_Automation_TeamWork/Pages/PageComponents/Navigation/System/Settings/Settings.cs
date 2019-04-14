using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
    public class Settings : BasePage<SettingsElementMap, SettingsValidator>
    {
        internal void ClickSettingsButton()
        {
            Map.SettingsButton.Click();
        }

        internal void ClickOnEditButton()
        {
            Map.EditButton.Click();
        }
        
        internal void ClickOnMetaTitleField()
        {
            Map.MetaTitleField.Click();
            Map.MetaTitleField.Clear();
        }

        internal void ClickOnSaveButton()
        {
            Map.SaveButton.Click();         
        }

        internal void TypeMetatitlename(string metatitlename) 
        {
            var metatitlenameElement = Map.MetaTitleField;
            metatitlenameElement.SendKeys(metatitlename);
        }

    }
}
