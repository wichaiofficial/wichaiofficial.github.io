using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblRating
{
    public int Id { get; set; }

    public string Rating { get; set; } = null!;

    public string RatingDescription { get; set; } = null!;

    public virtual ICollection<tblGame> tblGames { get; } = new List<tblGame>();
}
