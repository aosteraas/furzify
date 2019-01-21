using System.ComponentModel.DataAnnotations;

namespace Furzify.API.Entities
{
    public class Band
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Url)]
        public string AppleMusic { get; set; }

        [DataType(DataType.Url)]
        public string Bandcamp { get; set; }

        [DataType(DataType.Url)]
        public string Facebook { get; set; }

        [DataType(DataType.Url)]
        public string Instagram { get; set; }

        [DataType(DataType.Url)]
        public string ReverbNation { get; set; }

        [DataType(DataType.Url)]
        public string SoundCloud { get; set; }

        [DataType(DataType.Url)]
        public string Spotify { get; set; }

        [DataType(DataType.Url)]
        public string Twitter { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        [DataType(DataType.Url)]
        public string YouTube { get; set; }
    }
}