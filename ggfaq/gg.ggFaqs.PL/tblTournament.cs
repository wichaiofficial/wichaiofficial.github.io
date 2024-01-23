using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblTournament
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int FormatId { get; set; }

    public byte Online { get; set; }

    public string? Zip { get; set; }

    public decimal CostPerPlayer { get; set; }

    public byte Active { get; set; }

    public virtual tblTournamentFormat Format { get; set; } = null!;

    public virtual tblGame Game { get; set; } = null!;

    public virtual ICollection<tblRegistration> tblRegistrations { get; } = new List<tblRegistration>();
}
