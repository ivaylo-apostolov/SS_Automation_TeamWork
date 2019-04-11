using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.StoreContactUsPage
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
