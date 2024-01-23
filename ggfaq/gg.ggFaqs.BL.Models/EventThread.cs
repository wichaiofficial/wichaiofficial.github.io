using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class EventThread
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int CustomerId { get; set; }
        public byte Online { get; set; }
        public string Zip { get; set; }
        public byte Active { get; set; }
    }
}
