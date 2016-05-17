using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class AdministrationPageAssertions
    {
        public static void CaterotySelected(string page)
        {
            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath("//a[contains(.,"+page+")]")));
            Driver.Close();
        }
    }
}
