using Microsoft.AspNetCore.Mvc;

namespace SystemLoggerAPI.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello");
    }
}
