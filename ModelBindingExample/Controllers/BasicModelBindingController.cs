using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicModelBindingController : ControllerBase
    {
        // https://localhost:7098/api/BasicModelBinding?email=tester%40gmail.com&password=123123
        [HttpGet]
        public IActionResult Login(string email, string password)
        {
            return Ok("Basic model binding.");
        }
    }
}
