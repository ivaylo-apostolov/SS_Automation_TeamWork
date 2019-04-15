using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System.Collections.Generic;

namespace QC_Automation_TeamWork.Pages
{
    public class IphoneReviewPageElementMap : BasePageElementMap
    {
        public IWebElement Iphoneproduct
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div[2]/h1"));
            }
        }

        public IWebElement WriteReviewLink
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div[2]/div[3]/p/a[2]"));
            }
        }

        public IWebElement ReviewerName
        {
            get
            {
                return GetElement(By.Id("input-name"));
            }
        }

        public IWebElement Review
        {
            get
            {
                return GetElement(By.Id("input-review"));
            }
        }

        public IReadOnlyCollection<IWebElement> Rating
        {
            get
            {
                return GetElements(By.XPath("//input[@name='rating']"));
            }
        }
        public IWebElement Continuebutton
        {
            get
            {
                return GetElement(By.Id("button-review"));
            }
        }
        public IWebElement SuccessfulReviewMessage
        {
            get
            {
                return GetElement(By.CssSelector(".alert-success"));
            }
        }
    }
}
