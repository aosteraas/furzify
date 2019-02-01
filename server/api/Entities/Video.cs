using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Furzify.API.Entities
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}