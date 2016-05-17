using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTests
{
    [TestClass]
    public class GroupAccountsTests : BaseForAdmin
    {

        [TestMethod]
        public void CreateNewGroup()
        {
            // Arrange
            GroupsPage.GoTo();
            // Act
            GroupsPage.CreateNewGroup("TestGroup", "Description for TestGroup.");
            // Asssert
            GroupsPageAssertions.NewGroupCreated("TestGroup");
        }

        [TestMethod]
        public void DelateGroup()
        {
            // Arrange
            GroupsPage.GoTo();
            // Act
            GroupsPage.DeleteGroup("TestGroup");
            // Asssert
            //GroupsPageAssertions.GroupDeleted("TestGroup");
        }
    }
}
