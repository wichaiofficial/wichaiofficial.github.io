﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime Created { get; set; }
        public int CustomerId { get; set; }
        public int GameId { get; set; }

    }
}
