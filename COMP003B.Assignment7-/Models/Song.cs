using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7_.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Required]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
    }
}
