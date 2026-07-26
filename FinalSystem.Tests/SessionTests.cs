using Xunit;
using النظام_النهائي.A_Data_entry_A;

namespace FinalSystem.Tests
{
    public class SessionTests
    {
        [Fact]
        public void Logout_ShouldClearUserData()
        {
            // Arrange
            Session.CurrentUserId = 101;
            Session.CurrentUserName = "AdminTest";
            Session.CurrentTeacherId = 5;

            // Act
            Session.Logout();

            // Assert
            // هنا كتبنا Xunit.Assert لنقطع الشك باليقين
            Xunit.Assert.Equal(0, Session.CurrentUserId);
            Xunit.Assert.Equal(string.Empty, Session.CurrentUserName);
            Xunit.Assert.Null(Session.CurrentTeacherId);
        }
    }
}