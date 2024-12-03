using PassGuard.Models;

namespace PassGuard.Services
{
    internal interface IUserService
    {
        Task<bool> Login(string name, string password);
        Task<User> Register(string name, string password, ProtectionLevel protectionLevel);
        Task<User> Update(Guid id, User user);
        Task<bool> Delete(Guid id);
    }
}
