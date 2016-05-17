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
            HomePageAssertions.LoggedInAs("Administrator");
        }

        [TestMethod]
        public void Login_With_Wrong_Password()
        {
            // Arrange
            LoginPage.GoTo();
            // Act
            LoginPage.LogIn("admin", "aaa");
            // Asssert
            LoginPageAssertions.LoginError("Authentication failed.");
        }

        [TestMethod]
        public void Login_Resignation()
        {
            // Arrange
            LoginPage.GoTo();
            // Act
            LoginPage.CancelButonClick();
            // Asssert
            HomePageAssertions.NotLoggedIn();
        }

        [TestMethod]
        public void Deselect_CheckBox()
        {
            // Arrange
            LoginPage.GoTo();
            LoginPage.CheckIfCheckBoxSelected();
            // Act
            LoginPage.RememberMeCheckBoxClick();
            // Asssert
            LoginPageAssertions.CheckBoxNotSelected();
        }

    }
}
