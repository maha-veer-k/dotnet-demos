using Microsoft.EntityFrameworkCore;
using SeedDataImplementation.Data;
using SeedDataImplementation.Model;

namespace SeedDataImplementation.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public   List<Student> GetStudents()
        {
            var students =  _context.Students.ToList();
            return students;
        }
    }
}
