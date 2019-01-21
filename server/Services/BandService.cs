using System.Collections.Generic;
using System.Threading.Tasks;
using Furzify.API.Interfaces;
using Furzify.API.Models.Band;

namespace Furzify.API.Services
{
    public class BandService : IBandService
    {
        public BandService()
        {
        }

        public async Task<IList<BandDto>> ListBandsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}