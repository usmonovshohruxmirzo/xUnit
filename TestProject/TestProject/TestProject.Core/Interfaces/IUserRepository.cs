using System.Threading.Tasks;
using TestProject.Core.Models;

namespace TestProject.Core.Interfaces
{
    public interface IUserRepository
    {
        User? GetUserById(int id);
        Task<User?> GetUserByIdAsync(int id);
        void AddUser(User user);
    }
}
