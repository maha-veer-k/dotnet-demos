using Microsoft.AspNetCore.Identity;
using TestWebApi.API.Model;

namespace TestWebApi.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> UserSignUp(SignUpModel signUpModel);
    }
}
