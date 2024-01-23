using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblTeam
{
    public int Id { get; set; }

    public string TeamName { get; set; } = null!;

    public string PlayerFirstName { get; set; } = null!;

    public string PlayerLastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Age { get; set; }

    public decimal AmountDue { get; set; }

    public decimal AmountPaid { get; set; }

    public virtual ICollection<tblRegistration> tblRegistrations { get; } = new List<tblRegistration>();
}
