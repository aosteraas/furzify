using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Furzify.API.Entities;
using Furzify.API.Interfaces;
using Furzify.API.Models.Band;

namespace Furzify.API.Services
{
    public class BandService : IBandService
    {
        private readonly FurzeContext _context;
        private readonly IMapper _mapper;

        public BandService(FurzeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<BandDto>> ListBandsAsync()
        {
            return await _context.Bands.ProjectTo<BandDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}