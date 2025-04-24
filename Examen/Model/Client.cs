using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class Client
{
    public int Id { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public string Pol { get; set; } = null!;

    public DateTime DataRozdeniya { get; set; }

    public double? PasportDannie { get; set; }

    public string Gorod { get; set; } = null!;

    public string Ylica { get; set; } = null!;

    public string Dom { get; set; } = null!;

    public string Cvartira { get; set; } = null!;

    public int IdCarta { get; set; }

    public int IdTipNomera { get; set; }

    public virtual Cartum IdCartaNavigation { get; set; } = null!;

    public virtual TipNomera IdTipNomeraNavigation { get; set; } = null!;
}
