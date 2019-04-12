using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class RequestNewPasswordPageElementMap : BasePageElementMap
    {
        public IWebElement EmailElement 
        {
            get
            {
                return GetElement(By.Id("input-email"));
                {

                }
            }
        }
        public IWebElement SubmitElement
        {
            get
            {
                return GetElement(By.XPath("//*[@id='account-forgotten']/div[2]/form/div/div/div/div/button"));
            }
        }

    }
}
