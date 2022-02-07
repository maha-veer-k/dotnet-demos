using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeedDataImplementation.Repository;

namespace SeedDataImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository _studentRepository)
        {
            this._studentRepository = _studentRepository;
        }
        [HttpGet("")]
        public IActionResult GetStudents()
        { 
            var Students = _studentRepository.GetStudents();
            return Ok(Students);
        }
    }
}
