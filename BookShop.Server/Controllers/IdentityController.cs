using BookShop.Server.Models;
using BookShop.Server.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    public class IdentityController : ApiController
    {
        private readonly UserManager<User> _userManager;

        public IdentityController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            var user = new User
            {
                UserName = model.Name,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user,model.Password);

            if (result.Succeeded)
            {
                return Ok("Created");
            }

            return BadRequest(result.Errors);
        }
    }
}
