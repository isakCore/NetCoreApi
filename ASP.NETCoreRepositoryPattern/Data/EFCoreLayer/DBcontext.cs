using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreRepositoryPattern.Models
{
    public class DBcontext : DbContext
    {
        public DBcontext (DbContextOptions<DBcontext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
