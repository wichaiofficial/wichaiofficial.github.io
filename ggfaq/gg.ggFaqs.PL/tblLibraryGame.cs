using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblLibraryGame
{
    public int Id { get; set; }

    public int LibraryId { get; set; }

    public int GameId { get; set; }

    public DateTime DateAdded { get; set; }

    public virtual tblGame Game { get; set; } = null!;

    public virtual tblLibrary Library { get; set; } = null!;
}
