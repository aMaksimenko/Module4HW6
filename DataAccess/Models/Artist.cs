using System;
using System.Collections.Generic;

namespace HomeWork.DataAccess.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = null;
        public string Email { get; set; } = null;
        public string InstagramUrl { get; set; } = null;
        public virtual List<ArtistSong> ArtistSongs { get; set; } = new ();
    }
}