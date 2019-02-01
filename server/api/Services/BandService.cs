using System.Collections.Generic;
using System.Threading.Tasks;
using Furzify.API.Entities;
using Furzify.API.Interfaces;
using Furzify.API.Models.Band;

namespace Furzify.API.Services
{
    public class BandService : IBandService
    {
        private readonly FurzeContext _context;

        public BandService(FurzeContext context)
        {
            _context = context;
        }

        public async Task<IList<BandDto>> ListBandsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}