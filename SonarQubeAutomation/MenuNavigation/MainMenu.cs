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
    public class MainMenu
    {
        public static void GoToCategory(string mainMenuCategory)
        {
            //Category:Issues, Measures, Rules, Quality Profiles, Quality Gates, Administration
            Driver.Instance.FindElement(By.LinkText(mainMenuCategory)).Click();
        }
        public static void DropDownCategory(string mainCategory, string dropDownCategory)
        {
            //DropDownCategory: Dashboards(Home, Manage Dashboards), More(Compare Projects)
            Driver.Instance.FindElement(By.XPath("//span[contains(.," + mainCategory + ")]")).Click();
            Driver.Instance.FindElement(By.XPath("//a[contains(.," + dropDownCategory + ")]")).Click();
        }
    }
}