using DependencyInjectionMethods.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionMethods.Controllers
{
    public class LifeTimeDemoController : Controller
    {
        public readonly ILogger _logger;
        public readonly IMyTransientService _myTransientService;
        public readonly IMyScopedService _myScopedService;
        public readonly IMySingletonService _mySingletonService;


        public LifeTimeDemoController(
            IMyTransientService myTransientService,
            IMyScopedService myScopedService,
            IMySingletonService mySingletonService,
            ILogger<LifeTimeDemoController> logger
        )
        {
            _logger = logger;
            _myTransientService = myTransientService ?? throw new ArgumentNullException(nameof(myTransientService));
            _myScopedService = myScopedService ?? throw new ArgumentNullException(nameof(myScopedService));
            _mySingletonService = mySingletonService ?? throw new ArgumentNullException(nameof(mySingletonService));
        }


        [HttpGet("LifeTimeExample")]
        public IActionResult LifeTimeExample()
        {
            _logger.LogInformation("Transient: " + _myTransientService.InstanceId);
            _logger.LogInformation("Scoped: " + _myScopedService.InstanceId);
            _logger.LogInformation("Singleton: " + _mySingletonService.InstanceId);

            var message =$"Transient: {_myTransientService.InstanceId} \n" +
                         $"Scoped: {_myScopedService.InstanceId} \n" +
                         $"Singleton: {_mySingletonService.InstanceId} ";

            return Ok(message);
        }
    }
}
