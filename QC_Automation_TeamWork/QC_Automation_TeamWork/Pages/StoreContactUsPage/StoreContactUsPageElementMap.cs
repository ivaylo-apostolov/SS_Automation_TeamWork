using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreContactUsPageElementMap : BasePageElementMap
    {
        public IWebElement ContactUsHeader
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/h1"));
            }
        }

        public IWebElement YourNameTextBox
        {
            get
            {
                return GetElement(By.CssSelector("#input-name"));
            }
        }

        public IWebElement YourEmailTextBox
        {
            get
            {
                return GetElement(By.CssSelector("#input-email"));
            }
        }

        public IWebElement EnquiryTextBox
        {
            get
            {
                return GetElement(By.CssSelector("#input-enquiry"));
            }
        }

        public IWebElement SubmitButton
        {
            get
            {
                return GetElement(By.CssSelector("input[type='submit']"));
            }
        }
    }
}
