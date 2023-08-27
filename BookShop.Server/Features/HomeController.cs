using BookShop.Server.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookShop.Server.Features
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
