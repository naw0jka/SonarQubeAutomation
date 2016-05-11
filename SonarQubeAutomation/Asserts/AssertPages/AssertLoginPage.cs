using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class AssertLoginPage
    {
        public static void IfOpenLoginPage()
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.ClassName("maintenance-title text-center")).Text, "Log In to SonarQube", "Open LoginPage failed.");
        }
        public static void IfInformationWrongDataToLoginShowUp(string alert)
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.XPath("//div[@class='alert alert-danger']")).Text, alert, "Wrong or no information about the incorrect login attempt.");
            Driver.Close();
        }
        //public static void IfCheckBoxNotSelected()
        //{
        //    var checkBoxAfterClick = 0;
        //    var rememberMeCheckBoxAfterClick = Driver.Instance.FindElement(By.Id("remember_me"));
        //    if (rememberMeCheckBoxAfterClick == checked)
        //        {
        //        checkBoxAfterClick = 1;
        //    }
        //    Assert.AreNotEqual(checkBox, checkBoxAfterClick);
        //}
    }
}
