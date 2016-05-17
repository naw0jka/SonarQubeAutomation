using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTests
{
    [TestClass]
    public class UserAccountsTests : BaseForAdmin
    {

        [TestMethod]
        public void CreateNewUser()
        {
            // Arrange
            UsersPage.GoTo();
            // Act
            UsersPage.CreateNewUser("user1", "User1", "testsonarqube@qmail.com", "password");
            // Asssert
            UsersPageAssertions.NewUserCreated("User1");
        }

        [TestMethod]
        public void DelateUser()
        {
            // Arrange
            UsersPage.GoTo();
            // Act
            UsersPage.DeleteUser("user1");
            // Asssert
            UsersPageAssertions.UserDeleted("user1");
        }
    }
}
