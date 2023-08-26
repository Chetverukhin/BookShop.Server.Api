using BookShop.Server.Models.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    public class IdentityController : ApiController
    {
        private readonly IdentityService _identityService;

        public IdentityController(IdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            var userResult = await _identityService.RegisterUserAsync(model);

            return userResult.Succeeded
                ? Ok("Created")
                : BadRequest(userResult.Errors);
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            return await _identityService.ValidateUserAsync(model)
                ? Ok(new { Token = await _identityService.CreateTokenAsync() })
                : Unauthorized();
        }
    }
}
