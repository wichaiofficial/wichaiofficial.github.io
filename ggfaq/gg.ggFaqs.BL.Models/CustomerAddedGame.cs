using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class CustomerAddedGame
    {
        public int AddedGameId { get; set; }
        public int CustomerId { get; set; }
        public string GameTitle { get; set; }
        public string System { get; set; }
        public string GameDeveloper { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public byte InSystem { get; set; }
    }
}
