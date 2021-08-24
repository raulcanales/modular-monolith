using Microsoft.AspNetCore.Mvc;

namespace ModularMonolith.Modules.MyModule1.Controllers
{
    [ApiController]
    [Route("module-1/[controller]")]
    internal class HomeController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Hi from Module 1!");
        }
    }
}
