using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTests
{
    public class BaseForUser
    {
        [TestInitialize]
        public void Init()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("TestUser").WithPassword("testpassword").Login();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}