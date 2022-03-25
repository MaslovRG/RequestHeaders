using System.Web.Mvc;

namespace RequestHeadersAspNetMvc48.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HeaderTest()
        {
            var example = HttpContext.Request.Headers["Example"];
            return Content(example ?? "Header is empty");
        }
    }
}
