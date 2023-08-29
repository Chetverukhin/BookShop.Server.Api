using Microsoft.AspNetCore.Identity;

namespace API.Controllers.Identity
{
    public interface IIdentityService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterRequestModel model);
        Task<bool> ValidateUserAsync(LoginRequestModel model);
        Task<string> CreateTokenAsync();
    }
}
