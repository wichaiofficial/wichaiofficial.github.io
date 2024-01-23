using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblGameUserRating
{
    public int Id { get; set; }

    public int GameId { get; set; }

    public int CustomerId { get; set; }

    public int UserRating { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual tblGame Game { get; set; } = null!;
}
