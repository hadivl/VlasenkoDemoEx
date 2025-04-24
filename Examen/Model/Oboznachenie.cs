using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class Oboznachenie
{
    public int Id { get; set; }

    public string Nazvanie { get; set; } = null!;

    public virtual ICollection<Comnatum> Comnata { get; set; } = new List<Comnatum>();
}
