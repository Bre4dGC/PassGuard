using Microsoft.EntityFrameworkCore;
using PassGuard.Data;
using PassGuard.Models;

namespace PassGuard.Services
{
    internal class UserService : IUserService
    {
        private readonly DbContextFactory _contextFactory;

        public UserService(DbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<bool> Login(string name, string password)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                //bool succes = await context.Set<User>().FirstOrDefaultAsync(e => e.Name == name && e.Password == password);
                return true;
            }
        }

        public async Task<User> Register(string name, string password, ProtectionLevel protectionLevel)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                var createdUser = await context.Set<User>().AddAsync(
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Password = password,
                        ProtectionLevel = protectionLevel,
                    });

                await context.SaveChangesAsync();

                return createdUser.Entity;
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                var chat = await context.Set<User>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<User>().Remove(chat);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<User> Update(Guid id, User user)
        {
            using (PassGuardDbContext context = _contextFactory.CreateDbContext())
            {
                user.Id = id;
                context.Set<User>().Update(user);
                await context.SaveChangesAsync();

                return user;
            }
        }
    }
}
