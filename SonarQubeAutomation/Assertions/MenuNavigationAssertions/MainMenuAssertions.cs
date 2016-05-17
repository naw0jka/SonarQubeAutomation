using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SonarQubeAutomation
{
    public class MainMenuAssertions
    {
        public static void CategoryInMainMenuSelected(string mainMenuCategory)
        {
            Assert.AreEqual(Driver.Instance.FindElement(By.LinkText(mainMenuCategory)).Text, mainMenuCategory, "Selected category in main menu fail.");
        }

        public static void DropDownCategoryInMainMenuSelected(string dropDownCategory)
        {
            string dropDownCategoryPage;
            if (dropDownCategory == "Manage_Dashboards")
                dropDownCategoryPage = "My_Global_Dashboards";
            else if (dropDownCategory == "Compare_Projects")
                dropDownCategoryPage = "Compare";
            else dropDownCategoryPage = dropDownCategory; 

            Assert.AreEqual(true, Driver.ElementIsPresent(By.XPath("//h1[contains(.," + dropDownCategoryPage + ")]")), "Selected category in main menu fail.");
        }
    }
}
