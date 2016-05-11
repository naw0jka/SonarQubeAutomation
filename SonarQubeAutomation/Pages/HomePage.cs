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
    
    public class HomePage
    {
        public static void GoTo(string login, string password)
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(login).WithPassword(password).Login();
        }
        public static void ConfigureWidgetsButtonClick()
        {
            Driver.Instance.FindElement(By.XPath("//a[contains(.,'Configure widgets')]")).Click();
        }

        //To refactoring
        //Appearance and Composition of Dashboard is created by user in "Configure Widget"


        //BOX Welcome to SonaQube Dashboard
        public static void RunAnalysisLinkClick()
        {
            Driver.Instance.FindElement(By.XPath("//a[@href='http://redirect.sonarsource.com/1']")).Click();
        }
        public static void CustomizingDashboardsLinkClick()
        {
            Driver.Instance.FindElement(By.XPath("//a[@href='http://redirect.sonarsource.com/2']")).Click();
        }
        public static void CompleteDocumentationLinkCLick()
        {
            Driver.Instance.FindElement(By.XPath("//a[@href='http://redirect.sonarsource.com/3']")).Click();
        }
        public static void GetSupportLinkClick()
        {
            Driver.Instance.FindElement(By.XPath("//a[@href='http://www.sonarsource.org/get-support/']")).Click();
        }

        //BOX My Favourities
        public static void MyFavouritestLinkClick()
        {
            Driver.Instance.FindElement(By.XPath("//a[@href='/measures/filter/2']")).Click();
        }
        public static void MyFavouritesSortedByQG()
        {
         //function to create...
        }
        public static void MyFavouritesSortedByName()
        {
            //function to create...
        }
        public static void MyFavouritesSortedByLastAnalysis()
        {
            //function to create...
        }

        //BOX Projects above

        //MyProjectSortedByQG
        //MyProjectSortedByName
        //MyProjectSortedByVersion
        //MyProjectSortedByLoc
        //MyProjectSortedByTechnicalDebt
        //MyProjectSortedByLastAnalysis

    }
}
