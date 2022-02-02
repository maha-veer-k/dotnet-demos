using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.API.Model;
using TestWebApi.API.Repository;

namespace TestWebApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> UserSignUp([FromBody] SignUpModel signUpModel)
        {
            var result = await _accountRepository.UserSignUp(signUpModel);
            if (result.Succeeded)
            {
                return Ok("New Account Created !!!!!");
            }
            return Unauthorized();
        }
    }
}
