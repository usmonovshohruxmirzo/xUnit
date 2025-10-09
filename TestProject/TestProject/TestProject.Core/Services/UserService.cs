using TestProject.Core.Models;
using TestProject.Core.Interfaces;
using System.Threading.Tasks;

namespace TestProject.Core.Services
{

    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public string GetUserName(int id)
        {
            var user = _repo.GetUserById(id);
            return user?.Name ?? "Unknown";
        }

        public async Task<string> GetUserNameAsync(int id)
        {
            var user = await _repo.GetUserByIdAsync(id);
            return user?.Name ?? "Unknown";
        }

        public void AddUserIfNotExists(User user)
        {
            var existing = _repo.GetUserById(user.Id);
            if (existing == null)
                _repo.AddUser(user);
        }
    }
}
