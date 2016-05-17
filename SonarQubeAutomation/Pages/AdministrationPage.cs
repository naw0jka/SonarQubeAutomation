using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SonarQubeAutomation
{
    public class AdministrationPage
    {
        public static void GoTo()
        {
            MainMenu.GoToCategory("Administration");
        }

        public static void CategoryClick(string category)
        {
            //category:Analysis Scope, C#, General, Java, JavaScript, Licenses, MSBuild SonarQube Runner, SCM, Security, Tchnical Dabt.
            Driver.Instance.FindElement(By.LinkText(category)).Click();
        }
    }
}
