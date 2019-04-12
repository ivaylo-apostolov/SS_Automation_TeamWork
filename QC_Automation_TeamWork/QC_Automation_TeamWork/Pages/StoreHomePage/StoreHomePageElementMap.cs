using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class StoreHomePageElementMap : BasePageElementMap
    {
        public IWebElement CamerasButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='menu']/div[2]/ul/li[7]/a"));
            }

        }
            
        public IWebElement Iphone
        {
            get
            {
                return GetElement(By.CssSelector("#content>div.row>div:nth-child(2)>div>div.image>a>img"));
            }
        }

    }
}
