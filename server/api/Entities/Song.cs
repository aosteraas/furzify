using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furzify.API.Entities
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public int BandId { get; set; }
        public string Name { get; set; }
        public string Spotify { get; set; }
        public string YouTube { get; set; }
        public string YouTubeMusic { get; set; }
        public string AppleMusic { get; set; }

        [ForeignKey("BandId")]
        public virtual Band Band { get; set; }
    }
}