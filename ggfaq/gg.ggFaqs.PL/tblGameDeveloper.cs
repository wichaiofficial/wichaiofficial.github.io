using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblGameDeveloper
{
    public int Id { get; set; }

    public string DeveloperName { get; set; } = null!;

    public DateTime DateEstablished { get; set; }

    public virtual ICollection<tblGame> tblGames { get; } = new List<tblGame>();
}
