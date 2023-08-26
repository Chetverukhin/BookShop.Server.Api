using BookShop.Server.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace BookShop.Server
{
    public interface IIdentityService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterRequestModel model);
        Task<bool> ValidateUserAsync(LoginRequestModel model);
        Task<string> CreateTokenAsync();
    }
}
