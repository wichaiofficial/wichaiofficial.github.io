using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblUser
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<tblCustomer> tblCustomers { get; } = new List<tblCustomer>();
}
