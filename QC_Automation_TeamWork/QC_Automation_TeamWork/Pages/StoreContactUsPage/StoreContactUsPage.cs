using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
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

        internal StoreSuccessContactPage ClickOnSubmitButton()
        {
            Map.SubmitButton.Click();
            return new StoreSuccessContactPage();
        }
    }
}
