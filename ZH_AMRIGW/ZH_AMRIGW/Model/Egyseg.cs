using System;
using System.Collections.Generic;

namespace ZH_AMRIGW.Model;

public partial class Egyseg
{
    public int EgysegId { get; set; }

    public string Nev { get; set; } = null!;

    public virtual ICollection<Tetel> Tetel { get; } = new List<Tetel>();
}
