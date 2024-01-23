using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblLibrary
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public virtual tblCustomer Customer { get; set; } = null!;

    public virtual ICollection<tblLibraryGame> tblLibraryGames { get; } = new List<tblLibraryGame>();
}
