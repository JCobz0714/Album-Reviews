using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumReview.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Artist { get; set; }

        public DateOnly ReleaseDate { get; set; }

        //Representing the album cover image
        public IFormFile? AlbumCover { get; set; }

        //Representing the relationship from many to many with Genre, object level
        public virtual ICollection<Genre>? Genres { get; set; }

        public virtual ICollection<AlbumGenre>? AlbumGenres { get; set; }
    }
}