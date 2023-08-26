using Microsoft.AspNetCore.Identity;

namespace BookShop.Server.Features.Identity
{
    public interface IIdentityService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterRequestModel model);
        Task<bool> ValidateUserAsync(LoginRequestModel model);
        Task<string> CreateTokenAsync();
    }
}
