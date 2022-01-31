using Microsoft.EntityFrameworkCore;

namespace ImplementDependencyInjection.Data
{
    public class MyBookDbContext : DbContext
    {
        public MyBookDbContext(DbContextOptions<MyBookDbContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
