﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace SonarQubeAutomation
{
    public class LoginPage
    {
        public static bool checkboxStartStatus;
        public static void GoTo()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAdress + "sessions/new?return_to=%2F");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "login");
        }

        public static void LogIn(string login, string password)
        {
            LoginAs(login).WithPassword(password).Login();
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
        public static void CheckIfCheckBoxSelected()
        {
            var rememberMeCheckBox = Driver.Instance.FindElement(By.Id("remember_me"));
            checkboxStartStatus = rememberMeCheckBox.Selected;
        }

        public static void RememberMeCheckBoxClick()
        {
            var rememberMeCheckBox = Driver.Instance.FindElement(By.XPath("//label[@for='remember_me']"));
            rememberMeCheckBox.Click();
        }
        
        public static void CancelButonClick()
        {
            var cancelButton = Driver.Instance.FindElement(By.XPath("//a[@class='spacer-left']"));
            cancelButton.Click();
        }
    }
    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("login"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.XPath("//button[@name='commit']"));
            loginButton.Click();
        }

    }
}
