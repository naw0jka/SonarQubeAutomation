using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class AssertMainMenu
    {
        public static void IfSelectedCategoryInMainMenu(string mainMenuCategory)
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.LinkText(mainMenuCategory)).Text, mainMenuCategory, "Selected category in main menu fail.");
        }

        public static void IfSelectedDropDownCategoryInMainMenu(string dropDownCategory)
        {
            string dropDownCategoryPage;
            if (dropDownCategory == "Manage Dashboards")
                dropDownCategoryPage = "My Global Dashboards";
            else if (dropDownCategory == "Compare Projects")
                dropDownCategoryPage = "Compare";
            else dropDownCategoryPage = dropDownCategory; 

            Assert.AreEqual(Driver.Instance.FindElement(By.LinkText(dropDownCategory)).Text, dropDownCategoryPage, "Selected category in main menu fail.");
        }
    }
}
