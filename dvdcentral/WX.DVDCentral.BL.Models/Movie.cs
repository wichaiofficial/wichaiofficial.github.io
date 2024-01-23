using System.ComponentModel;

namespace WX.DVDCentral.BL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        [DisplayName("Rating")]
        public int RatingId { get; set; }
        [DisplayName("Format")]
        public int FormatId { get; set; }
        [DisplayName("Director")]
        public int DirectorId { get; set; }
        [DisplayName("Stock Qty")]
        public int InStkQty { get; set; }
        public string ImagePath { get; set; }
        public string Rating { get; set; }
        public string Format { get; set; }
       
        [DisplayName("Director")]
        public string FullName { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; } 
        public List<Genre> Genres { get; set; }
        public Movie()
        {
            Genres = new List<Genre>();
        }

        public int Quantity { get; set; }

    }
}