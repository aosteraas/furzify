using Microsoft.AspNetCore.Mvc;

namespace Furzify.API.Controllers
{
    public class BandController : Controller
    {
        public BandController() { }

        public IActionResult Index()
        {
            return Ok("Nothing to see here");
        }
    }
}