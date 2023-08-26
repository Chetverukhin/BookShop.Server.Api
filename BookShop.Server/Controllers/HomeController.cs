﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    public class HomeController : ApiController
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Works");
        }
    }
}