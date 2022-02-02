using DbTableRealationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DbTableRealationAPI.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public  DbSet<Classroom> Classrooms { get; set; }
    }
}
