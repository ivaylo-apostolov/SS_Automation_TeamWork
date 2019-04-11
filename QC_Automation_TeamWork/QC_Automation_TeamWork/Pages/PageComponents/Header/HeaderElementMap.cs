using QC_Automation_TeamWork.Core;
using OpenQA.Selenium;

namespace QC_Automation_TeamWork.Pages
{
    public class HeaderElementMap : BasePageElementMap
    {
        public IWebElement CompanyLogo { get; internal set; }
        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.CssSelector(".fa-sign-out"));
            }

        }
        public IWebElement UserProfileName
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[1]/a"));
            }
        }
        public IWebElement YourProfileLink
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[1]/ul/li[1]/a"));
            }
        }
        public IWebElement OpenSupportForum
        {
            get
            {
                return GetElement(By.XPath("//*[@id='header']/div/ul/li[1]/ul/li[9]/a"));
            }
        }
    }
}
