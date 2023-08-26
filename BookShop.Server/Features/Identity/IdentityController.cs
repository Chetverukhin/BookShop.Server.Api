using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Features.Identity
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
        public async Task<ActionResult> Register(RegisterRequestModel model)
        {
            var result = await _identityService.RegisterUserAsync(model);

            return result.Succeeded
                ? Ok()
                : BadRequest(result.Errors);
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginResponseModel>> Login(LoginRequestModel model)
        {
            return await _identityService.ValidateUserAsync(model)
                ? Ok(new LoginResponseModel{ Token = await _identityService.CreateTokenAsync() })
                : Unauthorized();
        }
    }
}
