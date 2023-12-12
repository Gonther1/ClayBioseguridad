using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Contactopersona : BaseEntity
{
    

    public string Descripcion { get; set; }

    public int? IdPersonaFk { get; set; }

    public int? IdTipoContactoFk { get; set; }

    public virtual Persona IdPersonaFkNavigation { get; set; }

    public virtual Tipocontacto IdTipoContactoFkNavigation { get; set; }
}
