using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages.DemoAdminPage
{
    public class DemoAdminPageElementMap : BasePageElementMap
    {

        public IWebElement Username
        {
            get
            {


                return GetElement(By.Id("input-username"));
            }
        }



        public IWebElement Password
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement LogInButton

        {
            get
            {
                //*[@id="content"]/div/div/div/div/div[2]/form/div[3]/button
                //*[@id="content"]/div/div/div/div/div[2]/form/div[3]/button
                //*[@id="content"]/div/div/div/div/div[2]/form/div[3]/button
                return GetElement(By.XPath("//*[@id='content']/div/div/div/div/div[2]/form/div[3]/button"));
            }
        }
    }

}



      