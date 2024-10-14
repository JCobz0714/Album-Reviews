using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumReview.Models
{
    public class AlbumGenre
    {
        public int Id { get; set; }

        public int Album { get; set; }

        public Album? AlbumId {get; set;}

        public int Genre { get; set; }

        public Genre? GenreId { get; set; }
    }
}