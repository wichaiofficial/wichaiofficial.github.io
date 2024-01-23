using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblMembership
{
    public int Id { get; set; }

    public string Membership { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<tblCustomer> tblCustomers { get; } = new List<tblCustomer>();
}
