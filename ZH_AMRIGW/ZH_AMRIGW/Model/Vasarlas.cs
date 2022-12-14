using System;
using System.Collections.Generic;

namespace ZH_AMRIGW.Model;

public partial class Vasarlas
{
    public int VasarlasId { get; set; }

    public DateTime Datum { get; set; }

    public int TetelFk { get; set; }

    public int Mennyiseg { get; set; }

    public virtual Tetel TetelFkNavigation { get; set; } = null!;
}
