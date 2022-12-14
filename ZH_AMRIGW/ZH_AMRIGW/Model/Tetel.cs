using System;
using System.Collections.Generic;

namespace ZH_AMRIGW.Model;

public partial class Tetel
{
    public int TetelId { get; set; }

    public string Nev { get; set; } = null!;

    public int EgysegFk { get; set; }

    public int EgysegAr { get; set; }

    public virtual Egyseg EgysegFkNavigation { get; set; } = null!;

    public virtual ICollection<Vasarlas> Vasarlas { get; } = new List<Vasarlas>();
}
