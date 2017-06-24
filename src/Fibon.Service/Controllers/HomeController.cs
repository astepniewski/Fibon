﻿using Microsoft.AspNetCore.Mvc;

namespace Fibon.Service.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("hello from Fibon Service.");
        }
    }
}
