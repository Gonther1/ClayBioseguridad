using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Tipodireccion : BaseEntity
{
    

    public string Descripcion { get; set; }

    public virtual ICollection<Direccionpersona> Direccionpersonas { get; set; } = new List<Direccionpersona>();
}
