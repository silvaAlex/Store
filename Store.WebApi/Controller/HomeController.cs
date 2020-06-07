using Microsoft.AspNetCore.Mvc;

namespace Store.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}