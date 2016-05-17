using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class LoginPageAssertions
    {
        public static void LoginPageWasOpened()
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.ClassName("maintenance-title text-center")).Text, "Log In to SonarQube", "Open LoginPage failed.");
        }
        public static void LoginError(string alert)
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.XPath("//div[@class='alert alert-danger']")).Text, alert, "Wrong or no information about the incorrect login attempt.");
            Driver.Close();
        }
        public static void CheckBoxNotSelected()
        {
            var checkboxStartState = LoginPage.checkboxStartStatus;
            var rememberMeCheckBox = Driver.Instance.FindElement(By.Id("remember_me"));
            Assert.AreNotEqual(checkboxStartState, rememberMeCheckBox.Selected, "Checkbox did not change value after click.");
            Driver.Close();
        }
    }
}
