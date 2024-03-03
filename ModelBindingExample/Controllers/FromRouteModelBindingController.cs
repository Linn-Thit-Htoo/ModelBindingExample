using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromRouteModelBindingController : ControllerBase
    {
        // https://localhost:7098/api/FromRouteModelBinding/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }
    }
}
