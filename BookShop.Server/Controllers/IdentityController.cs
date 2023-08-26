using BookShop.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : Controller
    {
        [HttpPost]
        [Route(nameof(Register))]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            return Ok("Done");
        }
    }
}
