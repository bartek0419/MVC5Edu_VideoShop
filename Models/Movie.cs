using System;

namespace VideoShop.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockNumber { get; set; }
    }

    public enum Genre
    {
        Comedy=1,
        Action=2,
        Family=3,
        Romance=4
    }
}