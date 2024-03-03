using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromFormModelBindingController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromForm] UserDataModel userDataModel)
        {
            return Ok(userDataModel);
        }
    }
}
