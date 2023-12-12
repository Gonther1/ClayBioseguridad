using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Categoriapersona : BaseEntity
{
    public string Nombre { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
