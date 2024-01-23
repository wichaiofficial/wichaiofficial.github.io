using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblEventThread
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public int CustomerId { get; set; }

    public byte Online { get; set; }

    public string? Zip { get; set; }

    public byte Active { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual ICollection<tblEventPost> tblEventPosts { get; } = new List<tblEventPost>();
}
