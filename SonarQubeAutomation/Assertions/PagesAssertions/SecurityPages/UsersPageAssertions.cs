using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class UsersPageAssertions
    {
        public static void NewUserCreated(string userName)
        {
            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath("//strong[contains(.,'" + userName + "')]")), "Creating new user fail.");
        }

        public static void UserDeleted(string userLogin)
        {
            Assert.AreEqual(false, Driver.ElementIsPresent(By.XPath("//strong[contains(.,'" + userLogin + "')]")), "Deleting user fail.");
        }
    }
}
