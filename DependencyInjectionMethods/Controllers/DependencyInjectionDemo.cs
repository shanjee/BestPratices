using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMethods.Controllers
{
    public class DependencyInjectionDemo : Controller
    {
        [HttpGet("example")]
        public IActionResult Example()
        {
            return Ok();
        }
    }
}
