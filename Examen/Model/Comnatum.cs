using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class Comnatum
{
    public int Id { get; set; }

    public int IdtipNomera { get; set; }

    public int Etaz { get; set; }

    public decimal Cena { get; set; }

    public int ColvoMest { get; set; }

    public int Idoboznachenie { get; set; }

    public virtual Oboznachenie IdoboznachenieNavigation { get; set; } = null!;

    public virtual TipNomera IdtipNomeraNavigation { get; set; } = null!;
}
