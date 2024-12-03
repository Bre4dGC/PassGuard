using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PassGuard.Data;
using PassGuard.Models;

namespace PassGuard.Services
{
    internal class PasswordService : IPasswordService
    {
        private readonly DbContextFactory _contextFactory;

        public PasswordService(DbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Service> Create(Guid userId, string name, string password, DateTime createdDate, ProtectionLevel protectionLevel, User user)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<Service> createdService = await context.Set<Service>().AddAsync(
                    new Service
                    {
                        UserId = userId,
                        Name = name,
                        Password = password,
                        CreatedDate = createdDate,
                        ProtectionLevel = protectionLevel,
                        User = user
                    });

                await context.SaveChangesAsync();

                return createdService.Entity;
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                var service = await context.Set<Service>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<Service>().Remove(service);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<IEnumerable<Service>> GetAll()
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                var chats = await context.Set<Service>().ToListAsync();
                return chats;
            }
        }

        public async Task<Service> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Service> Update(Guid id, Service service)
        {
            throw new NotImplementedException();
        }
    }
}
