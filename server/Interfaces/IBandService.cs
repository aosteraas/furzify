using System.Collections.Generic;
using System.Threading.Tasks;
using Furzify.API.Models.Band;

namespace Furzify.API.Interfaces
{
    public interface IBandService
    {
        Task<IList<BandDto>> ListBandsAsync();
    }
}