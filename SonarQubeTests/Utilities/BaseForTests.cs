using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTest
{
    public class BaseForTests
    {
        [TestInitialize]

        public void Init()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("admin").Login();
        }

        [TestCleanup]

        public void CleanUp()
        {
            Driver.Close();
        }
    }
}