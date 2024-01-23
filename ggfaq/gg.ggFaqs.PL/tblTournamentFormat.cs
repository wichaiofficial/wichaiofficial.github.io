using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblTournamentFormat
{
    public int Id { get; set; }

    public string FormatType { get; set; } = null!;

    public string FormatDescription { get; set; } = null!;

    public virtual ICollection<tblTournament> tblTournaments { get; } = new List<tblTournament>();
}
