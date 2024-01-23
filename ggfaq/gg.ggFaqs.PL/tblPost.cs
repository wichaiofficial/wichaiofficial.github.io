using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblPost
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime Created { get; set; }

    public int ThreadId { get; set; }

    public int CustomerId { get; set; }

    public string ImagePath { get; set; } = null!;

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblThread Thread { get; set; } = null!;
}
