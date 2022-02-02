using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestWebApi.API.Model;

namespace TestWebApi.API.Data
{
    public class BookDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)   
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
