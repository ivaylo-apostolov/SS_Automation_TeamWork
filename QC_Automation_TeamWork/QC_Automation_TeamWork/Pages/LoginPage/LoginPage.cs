﻿using OpenCartTestsTeamWork.Core;
using OpenCartTestsTeamWork.Data.Models;
using OpenQA.Selenium;
using OpenCartTestsTeamWork.Pages.DashboardPage;


namespace OpenCartTestsTeamWork.Pages.LoginPage
{
    public class LoginPage : BasePage<LoginPageElementMap>
    {
        private string pageURL = "https://demo.opencart.com/admin/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        internal void TypeUsername(string username)
        {
            var usernameElement = Map.UsernameElement;
            usernameElement.Clear();
            usernameElement.SendKeys(username);
        }

        internal void TypePassword(string password)
        {
            var passwordElement = Map.PasswordElement;
            passwordElement.Clear();
            passwordElement.SendKeys(password);
        }

        internal void ClickLoginButton()
        {
            Map.LoginButton.Click();
        }

        public DashboardHomePage Login(User user)
        {
            TypeUsername(user.Username);
            TypePassword(user.Password);
            ClickLoginButton();

            return new DashboardHomePage();
        }

        public string GetUsernameInputValue()
        {
            return Map.UsernameElement.GetAttribute("value");
        }
    }

    public class DashboardHomePage
    {
    }
}
