using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class EventPost
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime Created { get; set; }

        public int EventThreadId { get; set; }

        public int CustomerId { get; set; }

        public string? ImagePath { get; set; }
    }
}
