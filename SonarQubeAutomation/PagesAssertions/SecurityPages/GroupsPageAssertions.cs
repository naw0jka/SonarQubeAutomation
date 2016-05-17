using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class GroupsPageAssertions
    {
        public static void NewGroupCreated(string groupName)
        {
            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath("//strong[contains(.,'" + groupName + "')]")), "Creating new group fail.");
        }

        public static void GroupDeleted(string groupName)
        {
            Assert.AreEqual(false, Driver.ElementIsPresent(By.XPath("//strong[contains(.,'" + groupName + "')]")), "Deleting user fail.");
        }
    }
}
