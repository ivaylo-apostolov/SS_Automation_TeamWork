using System;
using System.Linq;
using System.Collections.ObjectModel;
using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data;
using System.Threading;

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
