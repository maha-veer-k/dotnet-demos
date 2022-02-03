using Microsoft.AspNetCore.Identity;
using TestWebApi.API.Model;

namespace TestWebApi.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
