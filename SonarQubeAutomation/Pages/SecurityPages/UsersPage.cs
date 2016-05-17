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
    public class UsersPage
    {
        public static void GoTo()
        {
            MainMenu.GoToCategory("Administration");
            var security = Driver.Instance.FindElement(By.XPath("//span[contains(.,'Security')]"));
            security.Click();
            var users = Driver.Instance.FindElement(By.XPath("//a[contains(.,'Users')]"));
            users.Click();
        }

        public static void CreateNewUser(string login, string name, string email, string password)
        {
            Driver.Instance.FindElement(By.XPath("//button[@id='users-create']")).Click();
            Driver.Instance.FindElement(By.Id("create-user-login")).SendKeys(login);
            Driver.Instance.FindElement(By.Id("create-user-name")).SendKeys(name);
            Driver.Instance.FindElement(By.Id("create-user-email")).SendKeys(email);
            Driver.Instance.FindElement(By.Id("create-user-password")).SendKeys(password);

            Driver.Wait(TimeSpan.FromSeconds(1));

            Driver.Instance.FindElement(By.Id("create-user-submit")).Click();
        }

        public static void DeleteUser(string userLogin)
        {
            var table = Driver.Instance.FindElement(By.Id("users-list"));
            var row = table.FindElement(By.XPath("//tr[contains(.,'" + userLogin + "')]//td/a[@class='js-user-deactivate icon-delete']"));
            row.Click();
            Driver.Wait(TimeSpan.FromSeconds(3));
            Driver.Instance.FindElement(By.Id("deactivate-user-submit")).Click();
        }
    }   
}
