using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Furzify.API.Entities
{
    public class FurzeContext : DbContext
    {
        public FurzeContext(DbContextOptions<FurzeContext> options) : base(options) { }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}