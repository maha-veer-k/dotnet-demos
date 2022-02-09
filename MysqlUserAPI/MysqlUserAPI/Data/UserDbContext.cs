using Microsoft.EntityFrameworkCore;
using MysqlUserAPI.Model;

namespace MysqlUserAPI.Data
{
    public class UserDbContext : DbContext
    {
        
        public DbSet<UserModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; port=3306; database=UserDb; user=root; password=Welcome@123");
        }
        public UserDbContext() :base()
        {
           
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel { UserId = 1, Name = "Mahaver", Email = "Mahaveer@gmail.com" },
                new UserModel { UserId = 2, Name = "Sharma", Email = "Sharma@gmail.com" },
                new UserModel { UserId = 5, Name = "Sinu", Email = "Sinu@gmail.com" }
                );
        }
    }
}
