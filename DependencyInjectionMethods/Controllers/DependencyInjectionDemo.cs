using DependencyInjectionMethods.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMethods.Controllers
{
    public class DependencyInjectionDemo : Controller
    {
        private readonly IService _service;
        private readonly IEnumerable<IService> _services;


        //public DependencyInjectionDemo(IService service)
        //{
        //    _service = service;
        //}

        public DependencyInjectionDemo(IEnumerable<IService> services, IService service)
        {
            _services = services;
            _service = service;
        }


        [HttpGet("example")]
        public IActionResult Example()
        {
            return Ok(_service.GetType().Name);
        }

        [HttpGet("exampleTwo")]
        public IActionResult ExampleTwo()
        {
            return Ok(_services.Select(s => s.GetType().Name));
        }
    }
}
