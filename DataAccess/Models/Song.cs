using System;
using System.Collections.Generic;

namespace HomeWork.DataAccess.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual List<ArtistSong> ArtistSongs { get; set; } = new ();
    }
}