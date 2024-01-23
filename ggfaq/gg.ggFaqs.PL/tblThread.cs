using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblThread
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public DateTime Created { get; set; }

    public int CustomerId { get; set; }

    public int GameId { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblGame Game { get; set; } = null!;

    public virtual ICollection<tblFollowingThread> tblFollowingThreads { get; } = new List<tblFollowingThread>();

    public virtual ICollection<tblPost> tblPosts { get; } = new List<tblPost>();
}
