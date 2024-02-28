using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<string> { "Smartphones", "Watches" });
        }
    }
}
