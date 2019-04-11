using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreContactUsPage
{
    public class StoreContactUsPage : BasePage<StoreContactUsPageElementMap, StoreContactUsPageValidator>
    {
        internal void TypeInYourNameTextBox(string name)
        {
            var yourNameTextBox = Map.YourNameTextBox;
            yourNameTextBox.Clear();
            yourNameTextBox.SendKeys(name);
        }

        internal void TypeInEmailAddressTextBox(string email)
        {
            var yourEmailTextBox = Map.YourEmailTextBox;
            yourEmailTextBox.Clear();
            yourEmailTextBox.SendKeys(email);
        }

        internal void TypeInEnquiryTextBox(string enquiry)
        {
            var enquiryTextBox = Map.EnquiryTextBox;
            enquiryTextBox.Clear();
            enquiryTextBox.SendKeys(enquiry);
        }

        internal void ClickOnSubmitButton()
        {
            Map.SubmitButton.Click();
        }
    }
}
