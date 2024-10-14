using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumReview.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string GenreName { get; set; }

        //Representing the relationship from many to many with Genre, object level
        public virtual ICollection<Album>? Albums { get; set; }

        public virtual ICollection<AlbumGenre>? AlbumGenres { get; set; }
    }
}