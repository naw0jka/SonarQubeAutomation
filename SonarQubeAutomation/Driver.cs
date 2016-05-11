using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
namespace SonarQubeAutomation
{
    public class Driver
    {//co to jest?
        public static IWebDriver Instance { get; set; }

        public static string BaseAdress
        {
            get { return "http://localhost:9000/"; }
        }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static bool ElementIsPresent(By by)
        {
            try
            {
                return Driver.Instance.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
