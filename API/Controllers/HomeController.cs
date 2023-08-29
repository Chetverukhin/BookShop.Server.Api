using API.Configurations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class HomeController : ApiController
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var userId = User.GetId();
            return Ok($"Works for userId : {userId}");
        }
    }
}
