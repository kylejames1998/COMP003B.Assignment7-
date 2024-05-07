using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7_.Models
{
    public class SongArtist
    {
        [Required]
        public int SongArtistId { get; set; }
        public int SongId { get; set; }
        public int ArtistId { get; set; }

        // Nullable navigation properties
        public virtual Song? Songs { get; set; }
        public virtual Artist? Artists { get; set; }
    }
}
