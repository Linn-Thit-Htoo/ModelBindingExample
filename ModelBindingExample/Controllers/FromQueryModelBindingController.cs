using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromQueryModelBindingController : ControllerBase
    {
        // https://localhost:7098/api/FromQueryModelBinding?query=testing
        [HttpGet]
        public IActionResult Search([FromQuery] string query)
        {
            return Ok(query);
        }
    }
}
