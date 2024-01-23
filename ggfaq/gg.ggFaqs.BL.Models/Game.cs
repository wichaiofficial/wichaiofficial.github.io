using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int SystemId { get; set; }
        public int RatingId { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
        public int GameDescriptionId { get; set; }
        public string ImagePath { get; set; }
        public string ImageSource { get; set; }
        public string SystemImageIcon { get; set; }
        public Manufacturer Publisher { get; set; }
        public Genre Genre { get; set; }
        
    }
}
