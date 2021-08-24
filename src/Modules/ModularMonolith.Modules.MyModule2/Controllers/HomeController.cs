using Microsoft.AspNetCore.Mvc;
using ModularMonolith.Modules.MyModule2.Services;

namespace ModularMonolith.Modules.MyModule2.Controllers
{
    [ApiController]
    [Route("module-2/[controller]")]
    internal class HomeController : ControllerBase
    {
        private readonly IModule2Service _service;

        public HomeController(IModule2Service service)
        {
            _service = service;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_service.GetSentence());
        }
    }
}
