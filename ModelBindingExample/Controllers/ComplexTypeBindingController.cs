using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplexTypeBindingController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(UserDataModel user)
        {
            return Ok(user);
        }
    }
}
