using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class IphoneReviewPageElementMap : BasePageElementMap
    {
        public IWebElement Iphoneproduct
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement WriteReviewLink
        {
            get
            {
                return GetElement(By.XPath("////*[@id='content']/div[1]/div[2]/div[3]/p/a[2]"));
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

        public IWebElement Rating
        {
            get
            {
                return GetElement(By.Id("input-review"));
            }
        }// WRITE IWEBELEMENT FOR RADIOBUTTONS
        public IWebElement Continuebutton
        {
            get
            {
                return GetElement(By.Id("button-review"));
            }
        }
    }
}

    


