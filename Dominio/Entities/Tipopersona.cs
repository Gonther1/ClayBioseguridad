using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Tipopersona : BaseEntity
{
    

    public string Descripcion { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
