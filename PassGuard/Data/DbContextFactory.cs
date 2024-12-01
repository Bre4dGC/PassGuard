using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PassGuard.Data
{
    class DbContextFactory : IDesignTimeDbContextFactory<PassGuardDbContext>
    {
        public PassGuardDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<PassGuardDbContext>();
            options.UseSqlite("");

            return new PassGuardDbContext(options.Options);
        }
    }
}
