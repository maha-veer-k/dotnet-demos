using Microsoft.EntityFrameworkCore;
using SeedDataImplementation.Model;



namespace SeedDataImplementation.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {


        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasData(
                  new Student
                  {
                      Id = 1,
                      Name = "Mahaveer",
                      Email = "Mahaveer@gmail.com"
                  },
                  new Student
                  {
                      Id = 2,
                      Name = "Ujjwal",
                      Email = "Ujjwal@gmail.com"
                  },
                  new Student
                  {
                      Id = 3,
                      Name = "Tushar",
                      Email = "tushar@gmail.com"
                  }
                );
        }

    }
}
