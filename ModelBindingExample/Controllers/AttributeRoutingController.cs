using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeRoutingController : ControllerBase
    {
        // https://localhost:7098/api/AttributeRouting/1
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(id);
        }
    }
}
