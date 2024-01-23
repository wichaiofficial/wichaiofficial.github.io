using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class GameUserRating
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CustomerId { get; set; }
        public int UserRating { get; set; }
    }
}
