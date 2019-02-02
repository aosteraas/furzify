using System.Threading.Tasks;
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

        public async Task<IActionResult> Index()
        {
            var bands = await _bandService.ListBandsAsync();
            return Ok(bands);
        }
    }
}