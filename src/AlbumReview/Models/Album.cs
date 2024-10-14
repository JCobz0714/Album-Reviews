using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumReview.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}