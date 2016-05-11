using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class AssertAdministrationPage
    {
        public static void IfCaterotySelected(string page)
        {
            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath('//a[contains(.,'page')]')), "Logged in.");
            Driver.Close();
        }
    }
}
