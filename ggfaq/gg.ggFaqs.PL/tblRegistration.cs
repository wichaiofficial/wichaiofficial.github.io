using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblRegistration
{
    public int Id { get; set; }

    public int TournamentId { get; set; }

    public int CustomerId { get; set; }

    public decimal AmountDue { get; set; }

    public decimal TotalCost { get; set; }

    public int TeamId { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblTeam Team { get; set; } = null!;

    public virtual tblTournament Tournament { get; set; } = null!;
}
