using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;

namespace QC_Automation_TeamWork.Pages
{
    public class SubscribeToNewsletterPage : BasePage<SubscribeToNewsletterPageElementMap, SubscribeToNewsletterPageValidator>
    {
        internal void FilledSubscriptionForm()
        {
            Map.SubscribeToNewsletterEmail.Clear();
            Map.SubscribeToNewsletterEmail.SendKeys(TestData.Email);
            Map.SubscribeToNewsletterCountry.Click();
            Map.SubscribeToNewsletterType.Click();
            Map.SubscribeButton.Click();
        }
    }
}
