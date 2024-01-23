using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class LibraryGame
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public int GameId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
