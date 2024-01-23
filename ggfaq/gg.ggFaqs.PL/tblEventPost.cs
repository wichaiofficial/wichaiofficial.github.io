using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblEventPost
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime Created { get; set; }

    public int EventThreadId { get; set; }

    public int CustomerId { get; set; }

    public string? ImagePath { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblEventThread EventThread { get; set; } = null!;
}
