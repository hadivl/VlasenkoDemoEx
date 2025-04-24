using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class Dogovor
{
    public int Id { get; set; }

    public DateTime DataDogovora { get; set; }

    public DateTime DataZaezda { get; set; }

    public DateTime DataBiezda { get; set; }

    public decimal? SymmaOplati { get; set; }
}
