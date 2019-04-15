using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class SubscribeToNewsletterPageValidator : BasePageValidator<SubscribeToNewsletterPageElementMap>
    {
        public void ValidateError()
        {
            var alertText = Driver.BrowserWait.Until(d => Driver.Browser.SwitchTo().Alert().Text);
            Assert.AreEqual(alertText, "Error: This subscribe form requires that you fill in a CAPTCHA to be added to the list.");
        }
    }
}
