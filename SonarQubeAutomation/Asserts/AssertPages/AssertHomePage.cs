using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class AssertHomePage
    {
        public static void IfLoggedInAs(string userName)
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.XPath("//span[@data-reactid='.0.2.0.0.2']")).Text, userName, "Login failed.");
            if (userName == "Administrator")
                Driver.Close();
        }

        public static void IfNotLoggedIn()
        {
            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath("//a[contains(.,'Log in')]")), "Logged in.");
            Driver.Close();
        }
    }
}
