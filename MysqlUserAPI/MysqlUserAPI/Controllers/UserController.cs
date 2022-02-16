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
        private readonly UserDbContext _userContext;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userContext.Users.FindAsync(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UserModel user, [FromRoute] int id)
        {
            
            var UpdateUser = new UserModel
            {
                UserId = id,
                Name = user.Name,
                Email = user.Email
            };
            _userContext.Users.Add(UpdateUser);
            await _userContext.SaveChangesAsync();
            return Ok("New user Updated succesfully");


        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserModel user)
        {
            await _userContext.Users.AddAsync(user);
            await _userContext.SaveChangesAsync();  
            return Ok("New user added succesfully");
        }
    }
}
