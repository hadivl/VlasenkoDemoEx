using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class TipNomera
{
    public int Id { get; set; }

    public string NameNomer { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Comnatum> Comnata { get; set; } = new List<Comnatum>();
}
