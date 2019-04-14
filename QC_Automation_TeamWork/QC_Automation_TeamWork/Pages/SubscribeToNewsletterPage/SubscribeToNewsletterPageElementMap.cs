using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class SubscribeToNewsletterPageElementMap : BasePageElementMap
    {
        public IWebElement SubscribeToNewsletterButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='newsletter']/div/div/button/i"));
            }

        }
        public IWebElement SubscribeToNewsletterEmail

        {
            get
            {
                return GetElement(By.Id("fieldEmail"));
            }
        }
        public IWebElement SubscribeToNewsletterCountry

        {
            get
            {
                return GetElement(By.XPath("//*[@id='fieldjrayki']/option[34]"));
            }
        }
        public IWebElement SubscribeToNewsletterType

        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-newsletter']/div[3]/div[4]/label"));
            }
        }
        public IWebElement SubscribeButton
        {
            get
            {
                return GetElement(By.Id("button-newsletter"));
            }
        }
    }
}

