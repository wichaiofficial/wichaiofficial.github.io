using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblSystem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ManufacturerId { get; set; }

    public DateTime Release { get; set; }

    public virtual tblManufacturer Manufacturer { get; set; } = null!;

    public virtual ICollection<tblGame> tblGames { get; } = new List<tblGame>();
}
