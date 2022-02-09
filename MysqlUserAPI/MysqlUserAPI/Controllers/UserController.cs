using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MysqlUserAPI.Data;
using MysqlUserAPI.Model;
using MysqlUserAPI.Repository;

namespace MysqlUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private UserDbContext _userContext;
       
        public UserController(IUserRepository userRepository, UserDbContext userDbContext)
        {
            _userRepository = userRepository;
            _userContext = userDbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            UserModel user = new UserModel { Name = "Hari", Email = "hjdsgfds" };
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
            var users = await _userRepository.GetAsync();
            return Ok(users);
        }
    }
}
