using System.Collections.Generic;

namespace HomeWork.DataAccess.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Song> Songs { get; set; } = new ();
    }
}