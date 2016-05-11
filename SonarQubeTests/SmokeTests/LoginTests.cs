using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTests
{
    [TestClass]
    public class LoginTests
    {

        [TestMethod]
        public void Login_As_Admin()
        {
            // Arrange
            LoginPage.GoTo();
            // Act
            LoginPage.LogIn("admin", "admin");
            // Asssert
            AssertHomePage.IfLoggedInAs("Administrator");
        }

        [TestMethod]
        public void Login_With_Wrong_Password()
        {
            // Arrange
            LoginPage.GoTo();
            // Act
            LoginPage.LogIn("admin", "aaa");
            // Asssert
            AssertLoginPage.IfInformationWrongDataToLoginShowUp("Authentication failed.");
        }

        [TestMethod]
        public void Login_Resignation()
        {
            // Arrange
            LoginPage.GoTo();
            // Act
            LoginPage.CancelButonClick();
            // Asssert
            AssertHomePage.IfNotLoggedIn();
        }
    }
}
