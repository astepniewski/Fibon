using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("hello from Fibon API.");
        }
    }
}
