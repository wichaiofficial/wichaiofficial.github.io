using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblCustomerAddedGame
{
    public int AddGameId { get; set; }

    public int CustomerId { get; set; }

    public string GameTitle { get; set; } = null!;

    public string System { get; set; } = null!;

    public string? GameDeveloper { get; set; }

    public string? Rating { get; set; }

    public string? Genre { get; set; }

    public byte InSystem { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;
}
