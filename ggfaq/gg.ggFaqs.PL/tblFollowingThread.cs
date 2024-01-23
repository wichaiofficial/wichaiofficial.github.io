using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblFollowingThread
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ThreadId { get; set; }

    public byte Following { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblThread Thread { get; set; } = null!;
}
