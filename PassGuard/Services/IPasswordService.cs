using PassGuard.Models;

namespace PassGuard.Services
{
    internal interface IPasswordService
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetByName(string name);
        Task<Service> Create(Guid userId, string name, string password, DateTime createdDate, ProtectionLevel protectionLevel, User user);
        Task<Service> Update(Guid id, Service service);
        Task<bool> Delete(Guid id);
    }
}
