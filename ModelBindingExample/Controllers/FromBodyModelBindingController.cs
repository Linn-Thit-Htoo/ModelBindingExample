using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FromBodyModelBindingController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] UserDataModel userDataModel)
        {
            return Ok(userDataModel);
        }
    }
}
