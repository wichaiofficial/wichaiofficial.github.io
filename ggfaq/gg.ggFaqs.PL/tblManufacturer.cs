﻿using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblManufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public virtual ICollection<tblSystem> tblSystems { get; } = new List<tblSystem>();
}
