using QC_Automation_TeamWork.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class ProfilePageElementMap : BasePageElementMap
    {
        public IWebElement FirstNameField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='input-firstname']"));
            }
        }
        public IWebElement LastNameField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='input-lastname']"));
            }
        }
        public IWebElement ProfileSaveButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[1]/div/div/button/i"));
            }
        }
        public IWebElement DeclineChangesMessage
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]"));
            }
        }
    }
}
