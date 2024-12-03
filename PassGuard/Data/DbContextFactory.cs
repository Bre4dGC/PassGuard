using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

namespace PassGuard.Data
{
    class DbContextFactory : IDesignTimeDbContextFactory<PassGuardDbContext>
    {
        public PassGuardDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<PassGuardDbContext>();
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PassGuardDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            return new PassGuardDbContext(options.Options);
        }
    }
}
