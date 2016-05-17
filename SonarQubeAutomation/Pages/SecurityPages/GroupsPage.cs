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
    public class GroupsPage
    {
        public static void GoTo()
        {
            MainMenu.GoToCategory("Administration");
            var security = Driver.Instance.FindElement(By.XPath("//span[contains(.,'Security')]"));
            security.Click();
            var group = Driver.Instance.FindElement(By.XPath("//a[contains(.,'Group')]"));
            group.Click();
        }

        public static void CreateNewGroup(string groupName, string description)
        {
            Driver.Instance.FindElement(By.XPath("//button[@id='groups-create']")).Click();
            Driver.Instance.FindElement(By.Id("create-group-name")).SendKeys(groupName);
            Driver.Instance.FindElement(By.Id("create-group-description")).SendKeys(description);

            Driver.Instance.FindElement(By.Id("create-group-submit")).Click();
        }

        public static void DeleteGroup(string groupName)
        {
            var button = Driver.Instance.FindElement(By.XPath("//strong[contains(.,'" + groupName + "')]/../../div[@class='pull-right big-spacer-left nowrap']/a[@class='js-group-delete icon-delete']"));
            button.Click();

            Driver.Wait(TimeSpan.FromSeconds(3));

            Driver.Instance.FindElement(By.Id("delete-group-submit")).Click();
        }

    }
}
