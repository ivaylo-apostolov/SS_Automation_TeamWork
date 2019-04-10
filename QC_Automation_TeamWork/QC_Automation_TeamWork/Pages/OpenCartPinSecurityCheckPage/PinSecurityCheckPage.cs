using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.OpenCartPinSecurityCheckPage
{
    public class PinSecurityCheckPage : BasePage<PinSecurityCheckPageElementMap, PinSecurityCheckPageValidator>
    {
        public void TypePincode(string pincode)
        {
            var PincodeElement = Map.Pincode;
            PincodeElement.Clear();
            PincodeElement.SendKeys(pincode);
        }

        public AccountPage.AccountPage ContinueButtonClick()
        {
            Map.ContinueButton.Click();

            return new AccountPage.AccountPage();
        }
    }

}
