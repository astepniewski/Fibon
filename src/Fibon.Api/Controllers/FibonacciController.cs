using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace Fibon.Api.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        private readonly IBusClient _busclient;

        public FibonacciController(IBusClient busClient)
        {
            _busclient = busClient;
        }

        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {
            await Task.CompletedTask;
            return Content(number.ToString());
        }

        [HttpPost("{number}")]
        public async Task<IActionResult> Post(int number)
        {
            await Task.CompletedTask;
            return Accepted($"fibonnacci/{number}", null);
        }
    }
}
