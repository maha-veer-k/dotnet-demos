using Microsoft.EntityFrameworkCore;

namespace TestWebApi.API.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)   
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
