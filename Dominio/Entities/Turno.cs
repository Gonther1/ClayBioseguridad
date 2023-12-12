using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Turno : BaseEntity
{
    

    public string Nombre { get; set; }

    public DateTime? HoraInicio { get; set; }

    public DateTime? HoraFin { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
