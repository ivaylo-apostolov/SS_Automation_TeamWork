using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class PinSecurityCheckPage : BasePage<PinSecurityCheckPageElementMap, PinSecurityCheckPageValidator>
    {
        public void TypePincode(string pincode)
        {
            var PincodeElement = Map.Pincode;

            PincodeElement.Clear();
            PincodeElement.SendKeys(pincode);
        }

        public AccountPage ContinueButtonClick()
        {
            Map.ContinueButton.Click();

            return new AccountPage();
        }
    }
}
