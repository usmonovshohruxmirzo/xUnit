using Xunit;
using Moq;
using System.Threading.Tasks;
using TestProject.Core.Models;
using TestProject.Core.Interfaces;
using TestProject.Core.Services;

namespace TestProject.Test.Services
{
    public class UserServiceTests
    {
        [Fact]
        public void GetUserName_UserExists_ReturnsName()
        {
            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(r => r.GetUserById(1))
                    .Returns(new User { Id = 1, Name = "Shohruxmirzo" });

            var service = new UserService(mockRepo.Object);
            var result = service.GetUserName(1);

            Assert.Equal("Shohruxmirzo", result);
        }
    }
}
