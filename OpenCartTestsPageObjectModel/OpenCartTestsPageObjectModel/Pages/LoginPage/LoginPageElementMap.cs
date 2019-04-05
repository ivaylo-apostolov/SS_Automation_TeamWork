﻿using OpenCartTests.Core;
using OpenQA.Selenium;

namespace OpenCartTests.Pages
{
    public class LoginPageElementMap : BasePageElementMap
    {
        public IWebElement PasswordElement
        {
            get
            {
                return GetElement(By.Id("input-password"));
            }
        }

        public IWebElement UsernameElement
        {
            get
            {
                return GetElement(By.Id("input-username"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return GetElement(By.CssSelector("button.btn"));
            }
        }

        public IWebElement LoginPanelTitle
        {
            get
            {
                return GetElement(By.XPath("//*[@id='content']/div/div/div/div/div[1]/h1"));
            }
        }
    }
}