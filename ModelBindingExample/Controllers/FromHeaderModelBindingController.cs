using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromHeaderModelBindingController : ControllerBase
    {
        [HttpPost]
        public IActionResult CheckUserAgent([FromHeader(Name = "Authorization")] string token)
        {
            return Ok(token);
        }
    }
}
