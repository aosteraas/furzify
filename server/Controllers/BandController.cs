using Furzify.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Furzify.API.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandService _bandService;

        public BandController(IBandService bandService)
        {
            _bandService = bandService;
        }

        public IActionResult Index()
        {
            return Ok("Nothing to see here");
        }
    }
}