using Microsoft.AspNetCore.Mvc;

namespace RequestHeadersAspNetCore6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet("HeaderTest")]
        public ActionResult HeaderTest()
        {
            var example = HttpContext.Request.Headers["Example"].FirstOrDefault(); 
            return Content(example ?? "Header is empty"); 
        }
    }
}