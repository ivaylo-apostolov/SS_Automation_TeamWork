using OpenQA.Selenium;
using QC_Automation_TeamWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Pages
{
   public class SettingsElementMap : BasePageElementMap
    {
        public IWebElement SettingsButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='collapse42']/li[1]/a"));
            }
        }

        public IWebElement EditButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='form-store']/div/table/tbody/tr/td[4]/a/i"));
            }
        }

        public IWebElement MetaTitleField
        {
            get
            {
                return GetElement(By.XPath("//*[@id='input-meta-title']"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id='button-save']/i"));
            }
        }

        public IWebElement DeclineSettingsMessage
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div[2]/div[1]"));
            }
        }

    }
}
