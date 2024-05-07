using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7_.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required]
        public string Name { get; set; }

        public int AlbumId { get; set; }

        // Collection navigation property
        public virtual ICollection<SongArtist>? SongArtists { get; set; }
    }
}
