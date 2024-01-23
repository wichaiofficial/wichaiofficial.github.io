using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblGenre
{
    public int Id { get; set; }

    public string Genre { get; set; } = null!;

    public string GenreDescription { get; set; } = null!;

    public virtual ICollection<tblGame> tblGames { get; } = new List<tblGame>();
}
