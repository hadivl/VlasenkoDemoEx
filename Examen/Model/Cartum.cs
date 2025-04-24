using System;
using System.Collections.Generic;

namespace Examen.Model;

public partial class Cartum
{
    public int Id { get; set; }

    public string NameCarta { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
