using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQubeAutomation;

namespace SonarQubeTests
{
    [TestClass]
    public class NavigationTests : BaseForUser
    {

        [TestMethod]
        public void GoToManageDashbords()
        {
            // Arrange
            MainMenu.GoToCategory("Rules");
            // Act
            MainMenu.DropDownCategory("Dashboards", "Manage_Dashboards");
            // Asssert
            MainMenuAssertions.DropDownCategoryInMainMenuSelected("Manage_Dashboards");
        }
        
    }
}
