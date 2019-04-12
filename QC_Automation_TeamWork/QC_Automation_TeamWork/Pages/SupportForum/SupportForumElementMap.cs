using QC_Automation_TeamWork.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class SupportForumElementMap : BasePageElementMap
    {
        public IWebElement forumBanner
        {
            get
            {
                return GetElement(By.XPath("//*[@id='forum']/div[1]/div/h1"));
            }
        }
    }
}